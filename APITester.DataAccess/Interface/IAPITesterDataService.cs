using System;
using System.Collections.Generic;
using System.Text;
using APITester.DataAccess.DTO;

namespace APITester.DataAccess.Interface
{
    public interface IAPITesterDataService
    {
        IEnumerable<EnvironmentDTO> GetEnvironments(string organisation, string serviceName);
        IEnumerable<EndpointDTO> GetEndpoints(string organisation, string serviceName);
        IEnumerable<ServiceDTO> GetServices(string organisation);
    }
}
