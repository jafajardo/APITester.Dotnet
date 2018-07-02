using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using APITester.DataAccess.DTO;
using APITester.DataAccess.Parser;

namespace APITester.DataAccess.DB
{
    public class ServiceDB : DALBase
    {
        private const string _procGetServicesByOrganisationId = "GetServicesByOrganisationId";
        private const string _procGetServicesByOrganisationName = "GetServicesByOrganisationName";
        public ServiceDB(string connectionString) : base(connectionString)
        {
        }

        public List<ServiceDTO> GetServicesByOrganisationId(int organisationId)
        {
            List<ServiceDTO> services = new List<ServiceDTO>();

            using (var command = GetSqlCommand(_procGetServicesByOrganisationId))
            {
                command.Parameters.Add(CreateParameter("@organisationId", organisationId, SqlDbType.Int));

                using (command.Connection = GetSqlConnection())
                {
                    command.Connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            services.Add(new ServiceDTOParser(reader).GetDTO());
                        }
                    }
                }
            }

            return services;
        }

        public List<ServiceDTO> GetServicesByOrganisationName(string organisationName)
        {
            List<ServiceDTO> services = new List<ServiceDTO>();

            using (var command = GetSqlCommand(_procGetServicesByOrganisationName))
            {
                command.Parameters.Add(CreateParameter("@organisationName", organisationName, SqlDbType.NVarChar));

                using (command.Connection = GetSqlConnection())
                {
                    command.Connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            services.Add(new ServiceDTOParser(reader).GetDTO());
                        }
                    }
                }
            }
            return services;
        }
    }
}
