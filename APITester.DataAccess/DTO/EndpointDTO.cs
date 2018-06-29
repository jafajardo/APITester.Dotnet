using System;
using System.Collections.Generic;
using System.Text;

namespace APITester.DataAccess.DTO
{
    public class EndpointDTO
    {
        public int EndpointId { get; set; }
        public string EndpointURL { get; set; }
        public string EndpointMethod { get; set; }
    }
}
