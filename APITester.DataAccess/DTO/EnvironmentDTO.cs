using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;

namespace APITester.DataAccess.DTO
{
    public class EnvironmentDTO
    {
        public string Host { get; set; }
        public string Name { get; set; }
        public bool ValidateSSL { get; set; }
    }
}
