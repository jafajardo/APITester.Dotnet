using System;
using System.Collections.Generic;
using System.Text;
using APITester.DataAccess.DTO;

namespace APITester.DataAccess.Interface
{
    public interface IAPITesterDataService
    {
        IEnumerable<EnvironmentDTO> GetEnvironments(string serviceName);
        IEnumerable<EndpointDTO> GetEndpoints(string organisationName, string serviceName);
        IEnumerable<ServiceDTO> GetServices(string organisationName);
        OrganisationDTO GetOrganisation(int organisationId);
    }
}
