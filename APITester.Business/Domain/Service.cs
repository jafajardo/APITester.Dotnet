using System;
using System.Collections.Generic;
using System.Text;

namespace APITester.Business.Domain
{
    public class Service
    {
        public string Name { get; set; }
        public IEnumerable<Environment> Environments { get; set; }
        public IEnumerable<Endpoint> Endpoints { get; set; }
    }
}
