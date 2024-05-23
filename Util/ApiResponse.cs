using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Util
{
    public class ApiResponseError(string message)
    {
        public string Message { get; set; } = message;
        
    }
}