using Member_Workshop.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Member_Workshop.Controllers
{
    public class ValuesController : ApiController
    {
        private DatabaseEntities _database = new DatabaseEntities(); 

        [Route("api/account/login")]
        public string PostLogin()
        {
            return "Login POST Page.";
        }

        // GET api/values
        public IEnumerable<Member> Get()
        {
            return this._database.Members.ToList();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
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
