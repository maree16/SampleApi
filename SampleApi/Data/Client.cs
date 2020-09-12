using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Data
{
    public class Client:Organization    
    {
        public string ClientName { get; set; }
        public int ClientId { get; set; }
        public string ClientLocation { get; set; }
        public int ClientOf { get; set; }
        public Client() 
        { 
        }
        public Client( string clientName, int clientId , string clientLocation)
        {
            ClientName = clientName ;
            ClientId = clientId;
            ClientLocation = clientLocation ;
            ClientOf = OrganizationId; 
        }

    } 
}
