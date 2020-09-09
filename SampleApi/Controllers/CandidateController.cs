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
    public class CandidateController : ControllerBase
    {
        // in absence of any server or database 
        // creating a private list (by default function)


        private static List<Candidate> list = new List<Candidate>();
        
        // to get list values

        // creating some pre- added values 


        // GET: api/<CandidateController>
        [HttpGet]
        public IEnumerable<Candidate> Get()
        {

            // ON GET ACTION SENDING BACK THE STORED LIST 

            return list;
        }

        // GET api/<CandidateController>/5
        [HttpGet("{id}")]
        public Candidate Get(int id)
        {
            return list.Where(record => record.CandidateId == id).FirstOrDefault();
        }

        // POST api/<CandidateController>
        [HttpPost]
        public void Post([FromBody] Candidate candidate)
        {
            list.Add(candidate);
        }

        // PUT api/<CandidateController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Candidate candidate)
        {
            var candidateById = list.Where(record => record.CandidateId == id).FirstOrDefault();

            candidateById.Email = candidate.Email;
            candidateById.FirstName = candidate.FirstName;
            candidateById.LastName = candidate.LastName;

        }

        // DELETE api/<CandidateController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var candidateById = list.Where(record => record.CandidateId == id).FirstOrDefault();
            list.Remove(candidateById);

        }
    }
}
