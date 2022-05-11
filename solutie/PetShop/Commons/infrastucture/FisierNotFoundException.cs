using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.infrastucture
{
    public class FisierNotFoundException : Exception
    {
        public string Message { get; }
        public FisierNotFoundException(string message)
        {
            Message = $"{message}";
        }

    }
}
