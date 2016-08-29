using RESTService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTService.Controllers
{
    public class ValuesController : ApiController
    {
        private List<SimpleDataObject> _items = new List<SimpleDataObject>(){
            new SimpleDataObject() { Name = "First", StartDate = DateTime.Now.AddDays(-2), Count = 1 },
            new SimpleDataObject() { Name = "Second", StartDate = DateTime.Now.AddHours(-2), Count = 2 }
    };


    // GET api/values
    public IEnumerable<SimpleDataObject> Get()
        {
            return _items;
        }

        // GET api/values/5
        public SimpleDataObject Get(int id)
        {
            return _items.Where(o => o.Count == id).SingleOrDefault();
        }

        // POST api/values
        public void Post([FromBody]SimpleDataObject value)
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
