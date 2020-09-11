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
    public class organizationController : ControllerBase
    {
        private static List<Organization> list = new List<Organization>();

        // GET: api/<organizationController>
        [HttpGet]
        public IEnumerable<Organization> Get()
        {
            return list;
        }

        // GET api/<organizationController>/5
        [HttpGet("{id}")]
        public Organization Get(int id)
        {
            return list.Where(Record => Record.OrganizationId == id ).FirstOrDefault(); 
        }

        // POST api/<organizationController>
        [HttpPost]
        public void Post([FromBody] Organization organization)
        {
            list.Add(organization);
        }

        // PUT api/<organizationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Organization organization)
        {
            var organizationById = list.Where(record => record.OrganizationId == id).FirstOrDefault();


            organizationById.OrganizationName = organization.OrganizationName;
          
        }

        // DELETE api/<organizationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var organizationById = list.Where(record => record.OrganizationId == id).FirstOrDefault();
            list.Remove(organizationById); 
        }
    }
}
