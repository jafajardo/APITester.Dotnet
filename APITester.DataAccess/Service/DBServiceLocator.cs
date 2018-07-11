using System;
using System.Collections.Generic;
using System.Text;
using APITester.DataAccess.DB;
using APITester.DataAccess.Interface;

namespace APITester.DataAccess.Service
{
    public class DBServiceLocator : IDBServiceLocator
    {
        private static string _connectionString;

        //public static Lazy<OrganisationDB> GetOrganisationDataProvider => new Lazy<OrganisationDB>(getOrganisationDataProvider);
        //public static Lazy<ServiceDB> GetServiceDataProvider => new Lazy<ServiceDB>(getServiceDataProvider);
        //public static Lazy<EnvironmentDB> GetEnvironmentProvider => new Lazy<EnvironmentDB>(getEnvironmentProvider);
        //public static Lazy<EndpointDB> GetEndpointProvider => new Lazy<EndpointDB>(getEndpointProvider);

        public DBServiceLocator(string connectionString)
        {
            _connectionString = connectionString;
        }

        public OrganisationDB GetOrganisationDataProvider()
        {
            return new OrganisationDB(_connectionString);
        }

        public ServiceDB GetServiceDataProvider()
        {
            return new ServiceDB(_connectionString);
        }

        public EnvironmentDB GetEnvironmentProvider()
        {
            return new EnvironmentDB(_connectionString);
        }

        public EndpointDB GetEndpointProvider()
        {
            return new EndpointDB(_connectionString);
        }

        //private static OrganisationDB getOrganisationDataProvider()
        //{
        //    return new OrganisationDB(_connectionString);
        //}

        //private static ServiceDB getServiceDataProvider()
        //{
        //    return new ServiceDB(_connectionString);
        //}

        //private static EnvironmentDB getEnvironmentProvider()
        //{
        //    return new EnvironmentDB(_connectionString);
        //}

        //private static EndpointDB getEndpointProvider()
        //{
        //    return new EndpointDB(_connectionString);
        //}
    }
}
