using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Recommend.Data
{
    public class Rating
    {
        public float CustomerID { get;set; }
        public float ProductID { get;set; }
        public float Rate { get; set; }        
        public string CreateDate { get;set;}
    }
}
