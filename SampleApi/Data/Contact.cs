using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Data
{
    public class Contact : Organization
    {
        public int ContactId { get; set; }
        public string OrganizationPhoneNumber { get; set;  }
        public string OrganizationEmail { get; set; }
        public int ContactOf { get; set; }

        public Contact() 
        { 
        }
        public Contact(int contactId,string organizationPhoneNumber, string organizationEmail ) {
            ContactId = contactId;
            OrganizationPhoneNumber = OrganizationPhoneNumber;
            ContactOf = OrganizationId;
            OrganizationEmail = OrganizationEmail;
        }
    }
}
