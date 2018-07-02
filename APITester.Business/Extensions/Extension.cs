using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using APITester.Business.Domain;
using APITester.DataAccess.DTO;

namespace APITester.Business.Extensions
{
    public static class Extension
    {
        public static Endpoint TranslateDTOToDomain(this EndpointDTO endpointDTO)
        {
            return new Endpoint
            {
                EndpointId = endpointDTO.EndpointId,
                EndpointMethod = endpointDTO.EndpointMethod,
                EndpointURL = endpointDTO.EndpointURL
            };
        }

        public static Domain.Environment TranslateDTOToDomain(this EnvironmentDTO environmentDTO)
        {
            return new Domain.Environment
            {
                EnvironmentId = environmentDTO.EnvironmentId,
                EnvironmentName = environmentDTO.EnvironmentName,
                EnvironmentHostURL = environmentDTO.EnvironmentHostURL,
                EnvironmentEnsureTLS = environmentDTO.EnvironmentEnsureTLS
            };
        }

        public static Domain.Service TranslateDTOToDomain(this ServiceDTO serviceDTO)
        {
            return new Domain.Service
            {
                ServiceId = serviceDTO.ServiceId,
                ServiceName = serviceDTO.ServiceName
            };
        }

        public static Organisation TranslateDTOToDomain(this OrganisationDTO organisationDTO)
        {
            return new Organisation()
            {
                OrganisationId = organisationDTO.OrganisationId,
                OrganisationName = organisationDTO.OrganisationName
            };
        }
    }
}
