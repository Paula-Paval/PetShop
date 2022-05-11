using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.infrastucture
{
    public class IdNegativExcetion : Exception
    {

        public string Message { get; }
        public IdNegativExcetion(string message)
        {
            Message = $"{message}";
        }
    }
}
