from sklearn.svm import SVC, NuSVC
from sklearn.tree import DecisionTreeClassifier, ExtraTreeClassifier
from sklearn.neighbors import KNeighborsClassifier, RadiusNeighborsClassifier
from sklearn.linear_model import SGDClassifier, RidgeClassifier, PassiveAggressiveClassifier
from sklearn.ensemble import (
    BaggingClassifier, RandomForestClassifier, AdaBoostClassifier, GradientBoostingClassifier,
    ExtraTreesClassifier, VotingClassifier, HistGradientBoostingClassifier
)
from sklearn.naive_bayes import GaussianNB, BernoulliNB, MultinomialNB

__MODEL__DICT__ = {
    'SVC': SVC, 'NuSVC': NuSVC,
    'DecisionTreeClassifier': DecisionTreeClassifier, 'ExtraTreeClassifier': ExtraTreeClassifier,
    'KNeighborsClassifier': KNeighborsClassifier, 'RadiusNeighborsClassifier': RadiusNeighborsClassifier,
    'SGDClassifier': SGDClassifier, 'RidgeClassifier': RidgeClassifier,
    'PassiveAggressiveClassifier': PassiveAggressiveClassifier,
    'BaggingClassifier': BaggingClassifier, 'RandomForestClassifier': RandomForestClassifier,
    'AdaBoostClassifier': AdaBoostClassifier,
    'GradientBoostingClassifier': GradientBoostingClassifier, 'ExtraTreesClassifier': ExtraTreesClassifier,
    'HistGradientBoostingClassifier': HistGradientBoostingClassifier,
    'GaussianNB': GaussianNB, 'BernoulliNB': BernoulliNB, 'MultinomialNB': MultinomialNB
}


def list_models():  
    return list(__MODEL__DICT__.keys())

def query_model_parameters(model):
    model = __MODEL__DICT__[model]()
    return model.get_params()