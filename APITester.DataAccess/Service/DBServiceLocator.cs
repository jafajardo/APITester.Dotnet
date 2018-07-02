using System;
using System.Collections.Generic;
using System.Text;
using APITester.DataAccess.DB;
using APITester.DataAccess.Interface;

namespace APITester.DataAccess.Service
{
    public static class DBServiceLocator
    {
        private static string _connectionString =
            "Data Source=localhost;Initial Catalog=APITester;Integrated Security=True";

        public static Lazy<OrganisationDB> OrganisationDataProvider => new Lazy<OrganisationDB>(getOrganisationDataProvider);
        public static Lazy<ServiceDB> ServiceDataProvider => new Lazy<ServiceDB>(getServiceDataProvider);
        public static Lazy<EnvironmentDB> EnvironmentProvider => new Lazy<EnvironmentDB>(getEnvironmentProvider);
        public static Lazy<EndpointDB> EndpointProvider => new Lazy<EndpointDB>(getEndpointProvider);

        private static OrganisationDB getOrganisationDataProvider()
        {
            return new OrganisationDB(_connectionString);
        }

        private static ServiceDB getServiceDataProvider()
        {
            return new ServiceDB(_connectionString);
        }

        private static EnvironmentDB getEnvironmentProvider()
        {
            return new EnvironmentDB(_connectionString);
        }

        private static EndpointDB getEndpointProvider()
        {
            return new EndpointDB(_connectionString);
        }
    }
}
