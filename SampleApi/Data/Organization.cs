﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Data
{
    public class Organization
    {
        // creating field 
        public string OrganizationName { get; set; }
        public int OrganizationId { get; set; }

        public Organization()
        { }

        public Organization(string organizationName, int organizationId)
        {
            OrganizationName = organizationName;
            OrganizationId = organizationId;
        }




    }

}
