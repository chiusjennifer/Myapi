using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Myapi.Models
{
    public class UsersResponse : BaseResponse
    {
        public List<User> Data { get; set; }
    }
}