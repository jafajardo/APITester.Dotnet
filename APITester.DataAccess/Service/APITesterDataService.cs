using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using APITester.DataAccess.DTO;
using APITester.DataAccess.Repository;
using APITester.DataAccess.Interface;

namespace APITester.DataAccess.Service
{
    public class APITesterDataService : IAPITesterDataService
    {
        private IDBServiceLocator _dbServiceLocator;
        public APITesterDataService(IDBServiceLocator dbServiceLocator)
        {
            _dbServiceLocator = dbServiceLocator;
        }

        public IEnumerable<EndpointDTO> GetEndpoints(string organisationName, string serviceName)
        {
            return _dbServiceLocator.GetEndpointProvider().GetEndpoints(organisationName, serviceName);
        }

        public IEnumerable<EnvironmentDTO> GetEnvironments(string serviceName)
        {
            return _dbServiceLocator.GetEnvironmentProvider().GetEnvironmentsByServiceName(serviceName);
        }

        public IEnumerable<ServiceDTO> GetServices(string organisationName)
        {
            return _dbServiceLocator.GetServiceDataProvider().GetServicesByOrganisationName(organisationName);
        }

        public OrganisationDTO GetOrganisation(int organisationId)
        {
            return _dbServiceLocator.GetOrganisationDataProvider().GetOrganisationByOrganisationId(organisationId);
        }
    }
}
