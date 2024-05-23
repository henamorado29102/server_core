using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Util
{
    public class ApiResponseSusses<T>(string message, T data)
    {
        public string Message { get; set; } = message;

        public T Data { get; set; } = data;
    }
}