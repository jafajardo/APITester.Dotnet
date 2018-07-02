using System;
using System.Collections.Generic;
using System.Text;

namespace APITester.Business.Interface
{
    public interface IAPITesterBusinessService
    {
        IEnumerable<Domain.Environment> GetEnvironments(string serviceName);
        IEnumerable<Domain.Endpoint> GetEndpoints(string organisation, string serviceName);
        IEnumerable<Domain.Service> GetServices(string organisation);
    }
}
