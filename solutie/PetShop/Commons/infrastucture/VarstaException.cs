using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.infrastucture
{
    public class VarstaException : Exception
    {
        public string Message { get; }
        public VarstaException(string message)
        {
            Message = $"{message}";
        }
    }
}
