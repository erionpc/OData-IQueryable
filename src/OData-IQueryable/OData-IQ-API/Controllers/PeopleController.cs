using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using OData_IQ_API.Abstractions.Data;
using OData_IQ_API.DbContexts;
using OData_IQ_API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OData_IQ_API.Controllers
{
    public class PeopleController : ODataController
    {
        private readonly IPeopleRepository _peopleRepository;
        private readonly ILogger<PeopleController> _logger;

        public PeopleController(IPeopleRepository peopleRepository, ILogger<PeopleController> logger)
        {
            _peopleRepository = peopleRepository;
            _logger = logger;
        }

        [EnableQuery(MaxExpansionDepth = 0)]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_peopleRepository.Query());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(500, null);
            }
        }
    }
}
