using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Data
{
    // inheritance from Candidate 
    public class Education : Candidate
    {
        public List<Education>edulist = new List<Education>();

        // Creating Fields

        public int EducationId { get; set; }
        public int UserId { get; set; }

        // UserId will take CandidateId
        // for 
        public Education()
        {
        }    


        public Education ( int educationId, int candidateId)
        {
            UserId = candidateId;
            EducationId = educationId;
        }


        public void Add(int educationId, int candidateId)
        {
            list.Add(new Education(educationId, candidateId));


        }


    }
}
