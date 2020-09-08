using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Data
{
    public class Vacancy : Organization 
    {
        public bool IsVacanyAvailable { get; set; }
        public string ExperienceDuration { get; set; }
        public string JobTitle { get; set; }

        public Vacancy() 
        { 
        }
    }
}
