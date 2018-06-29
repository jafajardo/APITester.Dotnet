using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using APITester.DataAccess.DTO;

namespace APITester.DataAccess.Parser
{
    public class EndpointDTOParser
    {
        private int ord_EndpointId = -1;
        private int ord_EndpointURL = -1;
        private int ord_EndpointMethod = -1;

        private SqlDataReader _reader;

        public EndpointDTOParser(SqlDataReader reader)
        {
            _reader = reader;
            populateOrdinals(_reader);
        }

        private void populateOrdinals(SqlDataReader reader)
        {
            if (reader != null)
            {
                ord_EndpointId = reader.GetOrdinal("EndpointId");
                ord_EndpointURL = reader.GetOrdinal("EndpointURL");
                ord_EndpointMethod = reader.GetOrdinal("endpointmethod");
            }
        }

        public EndpointDTO GetDTO()
        {
            EndpointDTO dto = new EndpointDTO();
            if (_reader != null)
            {
                dto.EndpointId = _reader.GetInt32(ord_EndpointId);
                dto.EndpointURL = _reader.GetString(ord_EndpointURL);
                dto.EndpointMethod = _reader.GetString(ord_EndpointMethod);
            }
            return dto;
        }
    }
}
