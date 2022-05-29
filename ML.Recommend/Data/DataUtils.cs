using ML.Recommend.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ML.Recommend.Data
{
    public class DataUtils
    {
        public static List<Customer> LoadCustomers(string dataset)
        {
            try
            {
                string jsonString = File.ReadAllText(dataset);
                List<Customer> customers = JsonSerializer.Deserialize<List<Customer>>(jsonString)!;
                return customers;
            }
            catch (Exception ex)
            {
                throw new DataPreprocessingError(ex.Message);
            }
        }
        public static List<Product> LoadProducts(string dataset)
        {
            try
            {
                string jsonString = File.ReadAllText(dataset);
                List<Product> products = JsonSerializer.Deserialize<List<Product>>(jsonString)!;
                return products;
            }
            catch (Exception ex)
            {
                throw new DataPreprocessingError(ex.Message);
            }
        }
        public static List<Rating> LoadRatings(string dataset)
        {
            try
            {
                string jsonString = File.ReadAllText(dataset);
                List<Rating> ratings = JsonSerializer.Deserialize<List<Rating>>(jsonString)!;
                return ratings;
            }
            catch (Exception ex)
            {
                throw new DataPreprocessingError(ex.Message);
            }
        }
        public static List<Rating> LoadRatings(string dataset,DateTime from,DateTime to)
        {
            try
            {
                string jsonString = File.ReadAllText(dataset);
                List<Rating> ratings = JsonSerializer.Deserialize<List<Rating>>(jsonString)!;
                List<Rating> ratings_time_factor = ratings.Where(x => {
                    DateTime d = DateTime.Parse(x.CreateDate);
                    return d>=from && d<=to; 
                }).ToList();
                return ratings_time_factor;
            }
            catch (Exception ex)
            {
                throw new DataPreprocessingError(ex.Message);
            }
        }
        public static List<Rating> LoadRatings(string dataset, int from_year, int to_year)
        {
            try
            {
                string jsonString = File.ReadAllText(dataset);
                List<Rating> ratings = JsonSerializer.Deserialize<List<Rating>>(jsonString)!;
                List<Rating> ratings_time_factor= ratings.Where(x => {
                    DateTime d = DateTime.Parse(x.CreateDate);
                    return d.Year >= from_year && d.Year <= to_year;
                }).ToList();
                return ratings_time_factor;
            }
            catch (Exception ex)
            {
                throw new DataPreprocessingError(ex.Message);
            }
        }
    }
}
