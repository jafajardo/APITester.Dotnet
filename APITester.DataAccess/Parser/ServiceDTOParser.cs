using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using APITester.DataAccess.DTO;

namespace APITester.DataAccess.Parser
{
    public class ServiceDTOParser
    {
        private int ord_ServiceId = -1;
        private int ord_ServiceName = -1;
        private SqlDataReader _reader;
        public ServiceDTOParser(SqlDataReader reader)
        {
            _reader = reader;
            populateOrdinals(_reader);
        }

        private void populateOrdinals(SqlDataReader reader)
        {
            if (reader != null && reader.HasRows)
            {
                ord_ServiceId = reader.GetOrdinal("ServiceId");
                ord_ServiceName = reader.GetOrdinal("ServiceName");
            }
        }

        public ServiceDTO GetDTO()
        {
            ServiceDTO dto = new ServiceDTO();
            if (_reader != null)
            {
                dto.ServiceId = _reader.GetInt32(ord_ServiceId);
                dto.ServiceName = _reader.GetString(ord_ServiceName);
            }
            return dto;
        }
    }
}
