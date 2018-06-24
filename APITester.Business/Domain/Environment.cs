using System;
using System.Collections.Generic;
using System.Text;

namespace APITester.Business.Domain
{
    public class Environment
    {
        public string Host { get; set; }
        public string Name { get; set; }
        public bool ValidateSSL { get; set; }
    }
}
