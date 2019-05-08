using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Models
{
    public class Response<T>
    {
        public bool Status { get; set; }

        public string Message { get; set; }
        
        public T Data { get; set; }

        public static Response<T> CreateResponse(bool status, string message, T data)
        {
            return new Response<T>
            {
                Data = data,
                Status = status,
                Message = message
            };
        }
    }
}
