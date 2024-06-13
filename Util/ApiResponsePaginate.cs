using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Util
{
    public class ApiResponsePaginate<T>(string message, int total, T data)
    {
        public string Message { get; set; } = message;
        public int Total { get; set; } = total;

        public T Data { get; set; } = data;
    }
}