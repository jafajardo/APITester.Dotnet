using System;
using System.Collections.Generic;
using System.Linq;
using APITester.Business.Domain;
using APITester.Business.Extensions;
using APITester.Business.Interface;
using APITester.DataAccess.Interface;
using Environment = APITester.Business.Domain.Environment;

namespace APITester.Business.Service
{
    public class APITesterBusinessService : IAPITesterBusinessService
    {
        private IAPITesterDataService _apiTesterDataService;
        public APITesterBusinessService(IAPITesterDataService apiTesterDataService)
        {
            _apiTesterDataService = apiTesterDataService;
        }

        public IEnumerable<Domain.Environment> GetEnvironments(string serviceName)
        {
            return _apiTesterDataService.GetEnvironments(serviceName).Select(e => e.TranslateDTOToDomain()).ToList();
        }

        public IEnumerable<Domain.Endpoint> GetEndpoints(string organisation, string serviceName)
        {
            return _apiTesterDataService.GetEndpoints(organisation, serviceName).Select(e => e.TranslateDTOToDomain()).ToList();
        }

        public IEnumerable<Domain.Service> GetServices(string organisation)
        {
            return _apiTesterDataService.GetServices(organisation).Select(s => s.TranslateDTOToDomain()).ToList();
        }

        public Organisation GetOrganisation(int organisationId)
        {
            return _apiTesterDataService.GetOrganisation(organisationId).TranslateDTOToDomain();
        }
    }
}
