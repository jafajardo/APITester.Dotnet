using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace APITester.DataAccess.DTO
{
    public class ConfigurationDTO
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Organisation { get; set; }
        public IEnumerable<ServiceDTO> Services { get; set; }
    }
}
