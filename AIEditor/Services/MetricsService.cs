using AIEditor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIEditor.Services
{
    public class MetricsService
    {
        public static List<MetricsInfo> Metrics { get; }

        static MetricsService()
        {
            Metrics =
            [
                new()
                {
                    Name = "accuracy",
                    Description = "The classification accuracy, also known as the classification rate or accuracy rate, is a measure of the correct predictions made by a classification model. It is calculated as the number of correct predictions divided by the total number of predictions made. The classification accuracy is often expressed as a percentage and provides an indication of how well the model is performing in terms of making correct classifications. However, it should be used in conjunction with other evaluation metrics, especially in cases of imbalanced datasets, where accuracy alone may not provide a complete picture of the model's performance."
                },
                new()
                {
                    Name = "f1",
                    Description = @"The F1 score is a metric that combines precision and recall into a single value and is particularly useful when dealing with imbalanced datasets. When calculating the F1 score with 'macro' averaging, the precision and recall for each class are computed independently, and then the average of these values is taken.\r\n\r\nMathematically, for a binary classification problem, the F1 score is defined as:\r\n\r\n[ F1 = \\frac{2 \\cdot \\text{precision} \\cdot \\text{recall}}{\\text{precision} + \\text{recall}} ]\r\n\r\nFor a multi-class problem with 'macro' averaging, the F1 score is calculated separately for each class, and the macro-average is obtained by taking the unweighted mean of these individual F1 scores. This ensures that each class contributes equally to the final score, regardless of its size in the dataset.\r\n\r\nThe 'macro' averaging is particularly useful when you want to evaluate the overall performance of the model across all classes without being biased by the class distribution."
                }
            ];
        }

    }
}
