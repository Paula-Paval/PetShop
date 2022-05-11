using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.infrastucture
{
    public class PretNegativException : Exception
    {
        public string Message { get; }
        public PretNegativException(string message)
        {
            Message = $"{message}";
        }
    }
}
