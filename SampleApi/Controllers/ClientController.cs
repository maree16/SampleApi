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
    public class ClientController : ControllerBase
    {

        private static List<Client> list = new List<Client>();

        // GET: api/<ClientController>
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return list; 
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public Client Get(int id)
        {
            return list.Where (Record => Record.ClientId == id ).FirstOrDefault();
        }

        // POST api/<ClientController>
        [HttpPost]
        public void Post([FromBody] Client client)
        {
            list.Add(client);
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Client client)
        {
            var clientbyId = list.Where(Record => Record.ClientId == id).FirstOrDefault();
            clientbyId.ClientName = client.ClientName;
            clientbyId.ClientLocation = client.ClientLocation;
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var clientbyId = list.Where(Record => Record.ClientId == id).FirstOrDefault();
            list.Remove(clientbyId);
        }
    }
}
