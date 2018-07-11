using System;
using System.Collections.Generic;
using System.Text;
using APITester.DataAccess.DB;

namespace APITester.DataAccess.Interface
{
    public interface IDBServiceLocator
    {
        OrganisationDB GetOrganisationDataProvider();
        ServiceDB GetServiceDataProvider();
        EnvironmentDB GetEnvironmentProvider();
        EndpointDB GetEndpointProvider();
    }
}
