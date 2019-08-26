using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiApp.Models;
namespace WebApiApp.Controllers
{
    public class CustomerApi : ApiController
    {
        Customer customer = new Customer();
        // GET api/<controller>
        [HttpGet]
        [Route("api/CustomerApi")]
        public IEnumerable<Customer> Get()
        {
            return this.customer.GetAllCust();
        }

        // GET api/<controller>/5
        public Customer Get(int id)
        {
            return this.customer.GetCustById(id);
        }

        // POST api/<controller>
        public bool Post([FromBody]Customer value)
        {
         return   this.customer.AddCust(value);
        }

        // PUT api/<controller>/5
        public bool Put(int id, [FromBody]Customer value)
        {
            return this.customer.UpdateCust(id, value);
        }

        // DELETE api/<controller>/5
        public bool Delete(int id)
        {
            return this.customer.DeleteCust(id);
        }
    }
}