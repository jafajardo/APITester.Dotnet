using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APITester.Business.Interface;
using Microsoft.AspNetCore.Mvc;
using APITester.Business.Domain;

namespace APITester.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class TestsController : Controller
    {
        private IAPITesterBusinessService _apiTesterBusinessService;
        public TestsController(IAPITesterBusinessService apiTesterBusinessService)
        {
            _apiTesterBusinessService = apiTesterBusinessService;
        }

        [HttpGet]
        public IActionResult IsAlive()
        {
            return Ok("Alive");
        }

        [HttpGet("services/{organisation}")]
        public IActionResult GetServices(string organisation)
        {
            return Ok(_apiTesterBusinessService.GetServices(organisation).ToList());
        }

        [HttpGet("endpoints/{organisation}/{serviceName}")]
        public IActionResult GetEndpoints(string organisation, string serviceName)
        {
            return Ok(_apiTesterBusinessService.GetEndpoints(organisation, serviceName).ToList());
        }

        [HttpGet("environments/{serviceName}")]
        public IActionResult GetEnvironments(string serviceName)
        {
            return Ok(_apiTesterBusinessService.GetEnvironments(serviceName).ToList());
        }
    }
}
