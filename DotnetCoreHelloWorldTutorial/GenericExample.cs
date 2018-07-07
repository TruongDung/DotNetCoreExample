using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetCoreHelloWorldTutorial
{
    class GenericExample
    {
        public class Response<T>
        {
            public bool Success { get; set; }
            public int StatusCode { get; set; }
            public T Data { get; set; }
        }

        public class ResponseString
        {
            public bool Success { get; set; }
            public int StatusCode { get; set; }
            public string Data { get; set; }
        }

        public class ResponseDecimal
        {
            public bool Success { get; set; }
            public int StatusCode { get; set; }
            public decimal? Data { get; set; }
        }

        public class ResponseDateTime
        {
            public bool Success { get; set; }
            public int StatusCode { get; set; }
            public DateTime Data { get; set; }
        }
    }
}
