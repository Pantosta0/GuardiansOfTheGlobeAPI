﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Wrappers
{
    public class Response<T>
    {
        public Response(int? id)
        {
            
        }
        public Response(T data, string message = null)
        {
            Succeeded = true;
            Message = message;
            Data = data;
        }
        public Response(string message)
        {   
            Succeeded = false;
            Message = message;
            Errors = new List<string> { message };
            
        }

        public Response()
        {
        }

        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }   
        public T Data { get; set; } 
    }
}
