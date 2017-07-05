using NetBeeTicket.BLL;
using NetBeeTicket.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace NetBeeTicket.API.Controllers
{
    public class CustomerController : ApiController
    {
        CustomerBs customerObjBs;

        public CustomerController()
        {
            customerObjBs = new CustomerBs();
        }

        [ResponseType(typeof(IEnumerable<Customer>))]
        public IHttpActionResult Get()
        {
            return Ok(customerObjBs.GetALL());
        }

        [ResponseType(typeof(Customer))]
        public IHttpActionResult Get(string id)
        {
            Customer customer = customerObjBs.GetByID(id);
            if (customer != null)
                return Ok(customer);
            else
                return NotFound();
        }

        [ResponseType(typeof(Customer))]
        public IHttpActionResult Post(Customer customer)
        {
            if (ModelState.IsValid)
            {
                customerObjBs.Insert(customer);
                return CreatedAtRoute("DefaultApi", new { id = customer.CustomerId }, customer);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [ResponseType(typeof(Customer))]
        public IHttpActionResult Put(int id, Customer customer)
        {
            if (ModelState.IsValid)
            {
                customerObjBs.Update(customer);
                return Ok(customer);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [ResponseType(typeof(Customer))]
        public IHttpActionResult Delete(string id)
        {
            Customer customer = customerObjBs.GetByID(id);
            if (customer != null)
            {
                customerObjBs.Delete(id);
                return Ok(customer);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
