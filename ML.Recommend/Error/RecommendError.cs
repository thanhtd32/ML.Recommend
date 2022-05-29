using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Recommend.Error
{
    public class RecommendError : ApplicationException
    {
        public string Message { get; set; }
        public RecommendError(string message)
        {
            Message = message;
        }
    }
}
