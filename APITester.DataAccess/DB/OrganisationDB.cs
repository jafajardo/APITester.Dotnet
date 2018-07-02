using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using APITester.DataAccess.DTO;
using APITester.DataAccess.Parser;

namespace APITester.DataAccess.DB
{
    public class OrganisationDB : DALBase
    {
        private const string procGetOrganisationByOrganisationId = "GetOrganisationByOrganisationId";
        private const string procGetOrganisationByOrganisationName = "GetOrganisationByOrganisationName";
        public OrganisationDB(string connectionString) : base(connectionString)
        { }

        public OrganisationDTO GetOrganisationByOrganisationId(int organisationId)
        {
            OrganisationDTO dto = new OrganisationDTO();

            using (var command = GetSqlCommand(procGetOrganisationByOrganisationId))
            {
                command.Parameters.Add(CreateParameter("@organisationId", organisationId, SqlDbType.Int));

                using (command.Connection = GetSqlConnection())
                {
                    command.Connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows && reader.Read())
                    {
                        dto = new OrganisationDTOParser(reader).GetDTO();
                    }
                }
            }

            return dto;
        }

        public OrganisationDTO GetOrganisationByOrganisationName(string organisationName)
        {
            OrganisationDTO dto = new OrganisationDTO();

            using (var command = GetSqlCommand(procGetOrganisationByOrganisationName))
            {
                command.Parameters.Add(CreateParameter("@organisationName", organisationName, SqlDbType.NChar));

                using (command.Connection = GetSqlConnection())
                {
                    command.Connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader != null && reader.Read())
                    {
                        dto = new OrganisationDTOParser(reader).GetDTO();
                    }
                }
            }

            return dto;
        }
    }
}
