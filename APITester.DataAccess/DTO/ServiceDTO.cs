using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;

namespace APITester.DataAccess.DTO
{
    public class ServiceDTO
    {
        public string Name { get; set; }
        public IEnumerable<EnvironmentDTO> Environments { get; set; }
        public IEnumerable<EndpointDTO> Endpoints { get; set; }
    }
}
