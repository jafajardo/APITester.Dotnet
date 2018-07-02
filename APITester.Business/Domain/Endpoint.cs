using System;
using System.Collections.Generic;
using System.Text;

namespace APITester.Business.Domain
{
    public class Endpoint
    {
        public int EndpointId { get; set; }
        public string EndpointURL { get; set; }
        public string EndpointMethod { get; set; }
    }
}
