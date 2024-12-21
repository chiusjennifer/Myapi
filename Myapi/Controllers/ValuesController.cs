using Myapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Myapi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }
        [Route("api/find/users/{age}")]
        [HttpGet]
        public UsersResponse FindUsers(int age)
        {
            var users = new List<User>
            {
                new User{Age = 10, Name="Alice"},
                new User{Age = 20, Name="Bob"},
                new User{Age = 30, Name="Chris"}
            };
            var data = users.Where(d => d.Age >=age).ToList();
            return new UsersResponse
            {
                Code = 200,
                Message = "",
                Data = data
            };
        }
        [Route("api/adduser/")]
        [HttpPost]
        public BaseResponse AddUser([FromBody]User user)
        {
            return new BaseResponse
            {
                Code = 1,
                Message = "Ok"
            };
        }
        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
