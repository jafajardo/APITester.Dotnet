using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using APITester.DataAccess.DTO;

namespace APITester.DataAccess.Parser
{
    public class OrganisationDTOParser
    {
        private int ord_OrganisationID = -1;
        private int ord_OrganisationName = -1;

        private SqlDataReader _reader;
        public OrganisationDTOParser(SqlDataReader reader)
        {
            _reader = reader;
        }

        private void populateOrdinals()
        {
            if (_reader != null && _reader.HasRows)
            {
                ord_OrganisationID = _reader.GetOrdinal("OrganisationId");
                ord_OrganisationName = _reader.GetOrdinal("OrganisationName");
            }
        }

        public OrganisationDTO GetDTO()
        {
            OrganisationDTO dto = new OrganisationDTO();
            if (_reader != null && _reader.HasRows)
            {
                dto.OrganisationId = _reader.GetInt32(ord_OrganisationID);
                dto.OrganisationName = _reader.GetString(ord_OrganisationName);
            }
            return dto;
        }
    }
}
