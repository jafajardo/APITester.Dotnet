using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APITester.DataAccess.DTO;
using MongoDB.Driver;

namespace APITester.DataAccess.Repository
{
    public class APITesterRepository
    {
        private IMongoDatabase _apiTesterMongoDatabase;
        private IMongoCollection<ConfigurationDTO> _configurationCollection;
        
        public APITesterRepository(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _apiTesterMongoDatabase = client.GetDatabase(databaseName);

            if (_apiTesterMongoDatabase != null)
            {
                _configurationCollection = _apiTesterMongoDatabase.GetCollection<ConfigurationDTO>("OrganisationServices");
            }
        }

        public IEnumerable<ServiceDTO> GetServices(string organisation)
        {
            var services = new List<ServiceDTO>();
            if (_configurationCollection != null)
            {
                var organisationConfiguration = _configurationCollection.Find(c => c.Organisation == organisation).Limit(1).FirstOrDefault();

                if (organisationConfiguration != null)
                {
                    services = organisationConfiguration.Services.ToList();
                }
            }
            return services;
        }
    }
}
