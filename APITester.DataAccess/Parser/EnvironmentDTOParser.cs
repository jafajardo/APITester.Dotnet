using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using APITester.DataAccess.DTO;

namespace APITester.DataAccess.Parser
{
    public class EnvironmentDTOParser
    {
        private int ord_EnvironmentId = -1;
        private int ord_EnvironmentName = -1;
        private int ord_EnvironmentHostURL = -1;
        private int ord_EnvironmentEnsureTLS = -1;

        private SqlDataReader _reader;

        public EnvironmentDTOParser(SqlDataReader reader)
        {
            _reader = reader;
            populateOrdinals();
        }

        private void populateOrdinals()
        {
            if (_reader != null && _reader.HasRows)
            {
                ord_EnvironmentId = _reader.GetOrdinal("EnvironmentId");
                ord_EnvironmentName = _reader.GetOrdinal("EnvironmentName");
                ord_EnvironmentHostURL = _reader.GetOrdinal("EnvironmentHostURL");
                ord_EnvironmentEnsureTLS = _reader.GetOrdinal("EnvironmentEnsureTLS");
            }
        }

        public EnvironmentDTO GetDTO()
        {
            EnvironmentDTO dto = new EnvironmentDTO();

            if (_reader != null && _reader.HasRows)
            {
                dto.EnvironmentId = _reader.GetInt32(ord_EnvironmentId);
                dto.EnvironmentName = _reader.GetString(ord_EnvironmentName);
                dto.EnvironmentHostURL = _reader.GetString(ord_EnvironmentHostURL);
                dto.EnvironmentEnsureTLS = _reader.GetBoolean(ord_EnvironmentEnsureTLS);
            }
            return dto;
        }
    }
}
