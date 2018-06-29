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
            _repository = new APITesterRepository("mongodb://admin:password123@ds163300.mlab.com:63300/apitesterconfiguration", "apitesterconfiguration");
        }

        public IEnumerable<EndpointDTO> GetEndpoints(string organisation, string serviceName)
        {
            //var service = _repository.GetServices(organisation).FirstOrDefault(s => s.Name == serviceName);
            //return service != null ? service.Endpoints : new List<EndpointDTO>();

            return new List<EndpointDTO>();
        }

        public IEnumerable<EnvironmentDTO> GetEnvironments(string organisation, string serviceName)
        {
            //var service = _repository.GetServices(organisation).FirstOrDefault(s => s.Name == serviceName);
            //return service != null ? service.Environments : new List<EnvironmentDTO>();

            return new List<EnvironmentDTO>();
        }

        public IEnumerable<ServiceDTO> GetServices(string organisation)
        {
            return _repository.GetServices(organisation);
        }
    }
}
