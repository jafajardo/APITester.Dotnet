using System;
using System.Collections.Generic;
using System.Text;

namespace APITester.Business.Domain
{
    public class Environment
    {
        public int EnvironmentId { get; set; }
        public string EnvironmentName { get; set; }
        public string EnvironmentHostURL { get; set; }
        public bool EnvironmentEnsureTLS { get; set; }
    }
}
