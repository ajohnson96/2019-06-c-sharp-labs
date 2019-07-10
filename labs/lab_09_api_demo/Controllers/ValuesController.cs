using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace lab_09_api_demo.Controllers
{
    public class ValuesController : ApiController
    {
        static List<String> list01 = new List<string>()
        {
            "first","second","third", "fourth", "fifth"
        };

        // GET api/values
        public IEnumerable<string> Get()
        {
            return list01;
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            string returnData = $"You requested data about the number {id} ";
            returnData = returnData.Replace(Environment.NewLine, "<br />");
            returnData = returnData + $"-- The data you want is {list01[id]} ";
            return returnData;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
