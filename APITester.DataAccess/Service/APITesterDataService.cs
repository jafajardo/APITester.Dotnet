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
        private APITesterRepository _repository;

        private IEnumerable<ServiceDTO> _services;
        public APITesterDataService()
        {
            //_repository = new APITesterRepository("mongodb://admin:password123@ds163300.mlab.com:63300/apitesterconfiguration", "apitesterconfiguration");
        }

        public IEnumerable<EndpointDTO> GetEndpoints(string organisationName, string serviceName)
        {
            return DBServiceLocator.EndpointProvider.Value.GetEndpoints(organisationName, serviceName);
        }

        public IEnumerable<EnvironmentDTO> GetEnvironments(string serviceName)
        {
            return DBServiceLocator.EnvironmentProvider.Value.GetEnvironmentsByServiceName(serviceName);
        }

        public IEnumerable<ServiceDTO> GetServices(string organisationName)
        {
            return DBServiceLocator.ServiceDataProvider.Value.GetServicesByOrganisationName(organisationName);
        }

        public OrganisationDTO GetOrganisation(int organisationId)
        {
            return DBServiceLocator.OrganisationDataProvider.Value.GetOrganisationByOrganisationId(organisationId);
        }
    }
}
