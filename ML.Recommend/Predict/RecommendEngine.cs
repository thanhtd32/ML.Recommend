using Microsoft.ML;
using Microsoft.ML.Trainers;
using ML.Recommend.Data;
using ML.Recommend.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.ML.DataOperationsCatalog;

namespace ML.Recommend.Predict
{
    public class RecommendEngine
    {
        MLContext context = new MLContext();
        TrainTestData trainTestData;
        ITransformer model;
        public bool ImportAndSplitDataset(List<Rating> ratings, double testRatio)
        {
            try
            {
                IDataView dataView = context.Data.LoadFromEnumerable(ratings);
                trainTestData = context.Data.TrainTestSplit(dataView, testRatio);
                return true;
            }
            catch(Exception ex)
            {
                throw new RecommendError(ex.Message);
            }            
        }

        public bool BuildModel(int Iterator, int rank)
        {
            try
            {
                IEstimator<ITransformer> estimator =
                     context.Transforms.Conversion.MapValueToKey(
                         outputColumnName: "CustomerIDEncoded", 
                         inputColumnName: "CustomerID")
                    .Append(context.Transforms.Conversion.MapValueToKey(
                        outputColumnName: "ProductIDEncoded", 
                        inputColumnName: "ProductID"));

                var options = new MatrixFactorizationTrainer.Options
                {
                    MatrixColumnIndexColumnName = "CustomerIDEncoded",
                    MatrixRowIndexColumnName = "ProductIDEncoded",
                    LabelColumnName = "Rate",
                    NumberOfIterations = Iterator,
                    ApproximationRank = rank
                };
                MatrixFactorizationTrainer mfTrainer = context.Recommendation()
                    .Trainers.MatrixFactorization(options);
                var trainerEstimator = estimator.Append(mfTrainer);

                model = trainerEstimator.Fit(trainTestData.TrainSet);
                return true;
            }
            catch (Exception ex)
            {
                throw new RecommendError(ex.Message);
            }
        }

        public Metric Evaluate()
        {
            try
            {
                var prediction = model.Transform(trainTestData.TestSet);
                var metrics = context.Regression.Evaluate(
                    prediction, 
                    labelColumnName: "Rate", 
                    scoreColumnName: "Score");
            
                Metric metric = new Metric();
                metric.LossFunction = metrics.LossFunction;
                metric.MAE = metrics.MeanAbsoluteError;
                metric.RMSE = metrics.RootMeanSquaredError;
                metric.MSE = metrics.MeanSquaredError;
                metric.RSquared = metrics.RSquared;
                
                return metric;
            }
            catch (Exception ex)
            {
                throw new RecommendError(ex.Message);
            }
        }
        public bool SaveModel(string modelFileName)
        {
            try
            {
                context.Model.Save(model, 
                    trainTestData.TrainSet.Schema, 
                    modelFileName);

                return true;
            }
            catch (Exception ex)
            {
                throw new RecommendError(ex.Message);
            }
        }

        public bool LoadModel(string modelFileName)
        {
            try
            {
                DataViewSchema modelSchema;

                model = context.Model.Load(modelFileName, out modelSchema);

                return true;
            }
            catch (Exception ex)
            {
                throw new RecommendError(ex.Message);
            }
        }

        public RatingPrediction Predict(int customerId,int productId)
        {
            try
            {
                var input = new Rating { CustomerID = customerId, ProductID = productId };
                var predictionEngine = context.Model.CreatePredictionEngine<Rating, RatingPrediction>(model);
                var output = predictionEngine.Predict(input);
                return output;
            }
            catch (Exception ex)
            {
                throw new RecommendError(ex.Message);
            }
        }
        public RatingPrediction Predict(Rating input)
        {
            try
            {
                var predictionEngine = context.Model.CreatePredictionEngine<Rating, RatingPrediction>(model);
                var output = predictionEngine.Predict(input);
                return output;
            }
            catch (Exception ex)
            {
                throw new RecommendError(ex.Message);
            }
        }

        public List<Product> Predict(Customer customer, List<Product> products, float expectedScore)
        {
            try
            {
                var predictionEngine = context.Model.CreatePredictionEngine<Rating, RatingPrediction>(model);
                List<Product> recommendProducts = new List<Product>();
                foreach (Product product in products)
                {
                    var input = new Rating { CustomerID = customer.Id, ProductID = product.Id };
                    var output = predictionEngine.Predict(input);
                    if (Math.Round(output.Score, 1) >= expectedScore)
                    {
                        product.Score = output.Score;
                        recommendProducts.Add(product);
                    }
                }
                return recommendProducts;
            }
            catch (Exception ex)
            {
                throw new RecommendError(ex.Message);
            }
        }
        public List<Product> Predict(Customer customer, List<Product> products)
        {
            try
            {
                var predictionEngine = context.Model.CreatePredictionEngine<Rating, RatingPrediction>(model);
                List<Product> recommendProducts = new List<Product>();
                foreach (Product product in products)
                {
                    var input = new Rating { CustomerID = customer.Id, ProductID = product.Id };
                    var output = predictionEngine.Predict(input);
                    product.Score = output.Score;
                    recommendProducts.Add(product);                    
                }
                return recommendProducts;
            }
            catch (Exception ex)
            {
                throw new RecommendError(ex.Message);
            }
        }
    }
}
