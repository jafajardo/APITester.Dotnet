using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;

namespace APITester.DataAccess.DTO
{
    public class EnvironmentDTO
    {
        public int EnvironmentId { get; set; }
        public string EnvironmentName { get; set; }
        public string EnvironmentHostURL { get; set; }
        public bool EnvironmentEnsureTLS { get; set; }
    }
}
