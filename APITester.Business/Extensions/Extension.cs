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
        //public static Endpoint TranslateDTOToDomain(this EndpointDTO endpointDTO)
        //{
        //    return new Endpoint
        //    {
        //        Host = endpointDTO.Host,
        //        Route = endpointDTO.Route
        //    };
        //}

        //public static Domain.Environment TranslateDTOToDomain(this EnvironmentDTO environmentDTO)
        //{
        //    return new Domain.Environment
        //    {
        //        Host = environmentDTO.Host,
        //        Name = environmentDTO.Name,
        //        ValidateSSL = environmentDTO.ValidateSSL
        //    };
        //}

        //public static Domain.Service TranslateDTOToDomain(this ServiceDTO serviceDTO)
        //{
        //    return new Domain.Service
        //    {
        //        Name = serviceDTO.Name,
        //        Environments = serviceDTO.Environments.Select(e => e.TranslateDTOToDomain()),
        //        Endpoints = serviceDTO.Endpoints.Select(e => e.TranslateDTOToDomain())
        //    };
        //}
    }
}
