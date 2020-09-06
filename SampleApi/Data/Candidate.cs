using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Data
{
    public class Candidate
    {

        public List<Candidate> list = new List<Candidate>();
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string Email { get; set; }
        public int  CandidateId { get; set; }
        public Candidate()
        { }
        public Candidate(string firstName, string lastName, int candidateId, string email)
        {   
            FirstName = firstName;
            LastName = lastName;
            CandidateId = candidateId;
            Email = email; 
        }

        public void Add(string firstName, string lastName, int candidateId, string email)
        {
            list.Add(new Candidate(firstName, lastName, candidateId, email));
        
        
        }



        public void DisplayList()
        {

            foreach (var candidate in list)
                Console.WriteLine($"Name :{candidate.FirstName} {candidate.LastName}, Email : {candidate.Email } , CandidateId :{candidate.CandidateId}");
        
        
        }
    }
}
