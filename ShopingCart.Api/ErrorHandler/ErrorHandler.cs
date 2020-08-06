using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopingCart.Api.ErrorHandler
{
    public  class ErrorHandler
    {
        public int StatusCode { get; set; }
        public string Message { get; set; } 


        public override string ToString()
        {
            return JsonConvert.SerializeObject(this); //JsonConvert is part of Newtonsoft.Json package.
        }
    }
}
