using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Recommend.Error
{
    public class DataPreprocessingError : ApplicationException
    {
        public string Message { get; set; }
        public DataPreprocessingError(string message)
        {
            Message = message;
        }
    }
}
