using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace APITester.DataAccess.DB
{
    public class DALBase
    {
        private string _connectionString;

        public DALBase(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlParameter CreateParameter(string parameterName, string value, SqlDbType dbType)
        {
            return new SqlParameter()
            {
                ParameterName = parameterName,
                Value = value,
                SqlDbType = dbType,
                Direction = ParameterDirection.Input
            };
        }

        public SqlParameter CreateParameter(string parameterName, int value, SqlDbType dbType)
        {
            return new SqlParameter()
            {
                ParameterName = parameterName,
                Value = value,
                SqlDbType = dbType,
                Direction = ParameterDirection.Input
            };
        }

        public SqlCommand GetSqlCommand(string proceedureName)
        {
            return new SqlCommand(proceedureName) { CommandType = CommandType.StoredProcedure };
        }

        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
