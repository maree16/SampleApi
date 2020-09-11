using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Data
{
    public class Candidate
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string Email { get; set; }
        public int  CandidateId { get; set; }
       
        // for error handling 
        public Candidate()
        { }
        
        public Candidate(string firstName, string lastName, int candidateId, string email)
        {   
            FirstName = firstName;
            LastName = lastName;
            CandidateId = candidateId;
            Email = email; 
        }

       
        
        
        
     
    }
}
