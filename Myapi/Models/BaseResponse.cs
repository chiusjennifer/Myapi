using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Myapi.Models
{
    public class BaseResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }
    }
}