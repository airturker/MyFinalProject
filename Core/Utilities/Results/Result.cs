using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        
        public Result(bool success, string message): this(success) //success i buraya atar.
        {
            Message = message;
        }

        public Result(bool success) //overloading - birden fazla aynı isimli method
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
