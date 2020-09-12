using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleApi.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private static List<Contact> list = new List<Contact>();
        // GET: api/<ContactController>
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            return list;
        }

        // GET api/<ContactController>/5
        [HttpGet("{id}")]
        public Contact Get(int id)
        {
            return list.Where(Record => Record.ContactId == id).FirstOrDefault();
        }

        // POST api/<ContactController>
        [HttpPost]
        public void Post([FromBody] Contact contact)
        {
            list.Add(contact);
        }

        // PUT api/<ContactController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Contact contact )
        {
            var contactById = list.Where(Record => Record.ContactId == id).FirstOrDefault();
            contactById.ContactId = contact.ContactId;
            contactById.OrganizationPhoneNumber = contact.OrganizationPhoneNumber;
            contactById.OrganizationEmail =contact.OrganizationEmail;
        }

        // DELETE api/<ContactController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var contactById = list.Where(Record => Record.ContactId == id).FirstOrDefault();
            list.Remove(contactById);
        }
    }
}
