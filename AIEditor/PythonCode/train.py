import os
import random
import string

import numpy as np
import pandas as pd
from sklearn.preprocessing import MinMaxScaler
from sklearn.model_selection import train_test_split, KFold
from sklearn.svm import SVC, NuSVC
from sklearn.tree import DecisionTreeClassifier, ExtraTreeClassifier
from sklearn.neighbors import KNeighborsClassifier, RadiusNeighborsClassifier
from sklearn.linear_model import SGDClassifier, RidgeClassifier, PassiveAggressiveClassifier
from sklearn.ensemble import (
    BaggingClassifier, RandomForestClassifier, AdaBoostClassifier, GradientBoostingClassifier,
    ExtraTreesClassifier, VotingClassifier, HistGradientBoostingClassifier
)
from sklearn.naive_bayes import GaussianNB, BernoulliNB, MultinomialNB
from sklearn.metrics import accuracy_score, f1_score, confusion_matrix

import socket
import seaborn
import matplotlib.pyplot as plt
import json
import joblib

__MODEL__DICT__ = {
    'SVC': SVC, 'NuSVC': NuSVC,
    'DecisionTreeClassifier': DecisionTreeClassifier, 'ExtraTreeClassifier': ExtraTreeClassifier,
    'KNeighborsClassifier': KNeighborsClassifier, 'RadiusNeighborsClassifier': RadiusNeighborsClassifier,
    'SGDClassifier': SGDClassifier, 'RidgeClassifier': RidgeClassifier,
    'PassiveAggressiveClassifier': PassiveAggressiveClassifier,
    'BaggingClassifier': BaggingClassifier, 'RandomForestClassifier': RandomForestClassifier,
    'AdaBoostClassifier': AdaBoostClassifier,
    'GradientBoostingClassifier': GradientBoostingClassifier, 'ExtraTreesClassifier': ExtraTreesClassifier,
    'VotingClassifier': VotingClassifier,
    'HistGradientBoostingClassifier': HistGradientBoostingClassifier,
    'GaussianNB': GaussianNB, 'BernoulliNB': BernoulliNB, 'MultinomialNB': MultinomialNB
}

__METRICS__ = {
    'accuracy': accuracy_score,
    'f1': lambda y_ture, y_pred: f1_score(y_ture, y_pred, average='micro')
}


def convert(data):
    try:
        value = float(data)
    except:
        if data == 'False':
            return False
        elif data == 'True':
            return True
        elif data == 'None' or data == '':
            return None
        elif ',' in data:
            return [convert(k) for k in data.split(',')]
        else:
            return data

    if isinstance(value, (int, float)):
        if value.is_integer():
            return int(value)
        else:
            return float(value)


def train(estimator, params, path, feature_columns, label_columns, normalize_columns, encode_columns, metrics, cv):
    def send(content):
        client, address = context.accept()
        client.sendall(content)
        client.close()

    def json_dumps(data):
        def encode(obj):
            if isinstance(obj, np.ndarray):
                return obj.tolist()
            else:
                return obj

        return json.dumps(data, ensure_ascii=False, default=encode)

    address = ("0.0.0.0", 6240)
    context = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    context.bind(address)
    context.listen(1)

    params = {key: convert(params[key]) for key in params}
    estimator = __MODEL__DICT__[estimator](**params)
    validator = KFold(n_splits=cv, shuffle=True)

    dataframe = pd.read_csv(path)
    scaler = MinMaxScaler()

    for column in encode_columns:
        dataframe[column], _ = pd.factorize(dataframe[column])

    for column in normalize_columns:
        dataframe[column] = scaler.fit_transform(dataframe[column].to_numpy().reshape(-1, 1))

    features = dataframe[feature_columns]
    labels = dataframe[label_columns]

    metrics = {metric: __METRICS__[metric] for metric in metrics}

    send(json_dumps({
        'message': f'accept train config, the model {str(estimator)} with the dataset length {features.to_numpy().shape}'}).encode(
        'utf-8'))

    features, labels = features.to_numpy(), labels.to_numpy().reshape(-1)
    total_train_scores = []
    total_test_scores = []
    for i, (train_index, test_index) in enumerate(validator.split(features)):
        train_features = features[train_index]
        train_labels = labels[train_index]
        test_features = features[test_index]
        test_labels = labels[test_index]

        estimator.fit(train_features, train_labels)

        train_predictions = estimator.predict(train_features)
        test_predictions = estimator.predict(test_features)

        train_scores = {metric: np.round(func(train_labels, train_predictions), 2) for (metric, func) in
                        metrics.items()}
        test_scores = {metric: np.round(func(test_labels, test_predictions), 2) for (metric, func) in metrics.items()}

        send(json_dumps({'k': i + 1, 'train_scores': train_scores,
                         'test_scores': test_scores}).encode('utf-8'))

        total_train_scores.append(train_scores)
        total_test_scores.append(test_scores)

    train_features, test_features, train_labels, test_labels = train_test_split(features, labels, train_size=1 / cv)
    estimator.fit(train_features, train_labels)

    predict_labels = estimator.predict(test_features)
    matrix = confusion_matrix(test_labels, predict_labels)

    path = f"{os.getenv('TEMP')}/{''.join(random.choices(string.digits + string.ascii_letters, k=10))}"
    os.makedirs(path, exist_ok=True)
    figure_path = f'{path}/Eval Confusion Matrix.png'
    estimator_path = f'{path}/Estimator.m'

    plt.figure()
    seaborn.heatmap(matrix.T, square=True, annot=True, fmt='g', cmap='Blues', cbar=False)
    plt.xlabel('Exact Label')
    plt.ylabel('Predict Label')
    plt.title('Confusion Matrix')

    plt.savefig(figure_path, dpi=1000, bbox_inches='tight', pad_inches=0.0)
    joblib.dump(estimator, estimator_path)

    send(json_dumps({'root': path, 'figure': figure_path, 'estimator': estimator_path}).encode('utf-8'))

    train_results = {}
    for key in total_train_scores[0]:
        value = sum(map(lambda x: x[key], total_train_scores))
        train_results[key] = np.round(value / cv, 2)

    test_results = {}
    for key in total_test_scores[0]:
        value = sum(map(lambda x: x[key], total_test_scores))
        test_results[key] = np.round(value / cv, 2)

    send(json_dumps({'train_results': train_results, 'test_results': test_results}).encode('utf-8'))
