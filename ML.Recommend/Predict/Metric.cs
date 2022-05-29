using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Recommend.Predict
{
    public class Metric
    {
        /// <summary>
        ///RSquared - RS. 
        ///R-Squared metric is a more intuitive approach than RMSE and MSE. 
        ///R squared shows how well the model fits the data. 
        ///It is also known as the coefficient of determination and R-Squared closer to 1 indicates a better fitted model.
        /// </summary>
        public double RSquared { get; set; }
        /// <summary>
        /// RootMeanSquaredError - RMSE.
        /// Root Mean Square Error is a variation of the MSE metric,
        /// it is the square root of the mean of the squared difference between the prediction and the actual observation
        /// </summary>
        public double RMSE { get; set; }
        /// <summary>
        ///MeanSquaredError - MSE. 
        ///The mean square error of an estimator is the average of the squares of the errors. 
        ///Means the difference between the predict and what is evaluated. 
        ///This is probably the most popular metric of all regression metrics.
        ///And it is often used as a loss function of a machine learning model. 
        /// </summary>
        public double MSE { get; set; }
        /// <summary>
        ///MeanAbsoluteError - MAE. 
        ///The Mean Absolute Error measure is average size of errors in a set of predictions without considering their direction. 
        ///It is the test sample mean of the absolute difference between the prediction and the actual observation,
        ///where all individual differences are weighted equally
        /// </summary>
        public double MAE { get; set; }
        /// <summary>
        /// This is LossFunction, we can use RMSE instead.
        /// This is the average of a loss function defined by the user, computed over all the instances in the test set.
        /// </summary>
        public double LossFunction { get; set; }
    }
}
