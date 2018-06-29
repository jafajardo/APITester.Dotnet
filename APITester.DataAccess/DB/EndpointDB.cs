using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using APITester.DataAccess.DTO;
using APITester.DataAccess.Parser;

namespace APITester.DataAccess.DB
{
    public class EndpointDB : DALBase
    {
        public EndpointDB(string connectionString) : base(connectionString)
        { }

        public IEnumerable<EndpointDTO> GetEndpoints(string organisationName, string serviceName)
        {
            List<EndpointDTO> endpoints = new List<EndpointDTO>();

            using (var command = GetSqlCommand("GetEndpoints"))
            {
                command.Parameters.Add(CreateParameter("@organisationName", organisationName, SqlDbType.NVarChar));
                command.Parameters.Add(CreateParameter("@serviceName", serviceName, SqlDbType.NVarChar));

                using (command.Connection = GetSqlConnection())
                {
                    command.Connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            endpoints.Add(new EndpointDTOParser(reader).GetDTO());
                        }
                    }

                }
            }

            return endpoints;
        }
    }
}
