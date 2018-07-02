using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using APITester.DataAccess.DTO;
using APITester.DataAccess.Parser;

namespace APITester.DataAccess.DB
{
    public class EnvironmentDB : DALBase
    {
        private const string procGetEnvironmentByServiceId = "GetEnvironmentByServiceId";
        private const string procGetEnvironmentByServiceName = "GetEnvironmentsByServiceName";
        public EnvironmentDB(string connectionString) : base(connectionString)
        {}

        public List<EnvironmentDTO> GetEnvironmentsByServiceId(int serviceId)
        {
            List<EnvironmentDTO> environments = new List<EnvironmentDTO>();

            using (var command = GetSqlCommand(procGetEnvironmentByServiceId))
            {
                command.Parameters.Add(CreateParameter("@serviceId", serviceId, SqlDbType.Int));

                using (command.Connection = GetSqlConnection())
                {
                    command.Connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            environments.Add(new EnvironmentDTOParser(reader).GetDTO());
                        }
                    }
                }
            }

            return environments;
        }

        public List<EnvironmentDTO> GetEnvironmentsByServiceName(string serviceName)
        {
            List<EnvironmentDTO> environments = new List<EnvironmentDTO>();

            using (var command = GetSqlCommand(procGetEnvironmentByServiceName))
            {
                command.Parameters.Add(CreateParameter("@serviceName", serviceName, SqlDbType.NVarChar));

                using (command.Connection = GetSqlConnection())
                {
                    command.Connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            environments.Add(new EnvironmentDTOParser(reader).GetDTO());
                        }
                    }
                }
            }

            return environments;
        }
    }
}
