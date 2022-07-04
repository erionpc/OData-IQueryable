using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using OData_IQ_API.Abstractions.Data;
using OData_IQ_API.DbContexts;
using OData_IQ_API.DTOs;
using OData_IQ_API.DTOs.Requests;
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
        private readonly RecordStoreDbContext _dbContext;
        private readonly ILogger<PeopleController> _logger;

        public PeopleController(IPeopleRepository peopleRepository, RecordStoreDbContext dbContext, ILogger<PeopleController> logger)
        {
            _peopleRepository = peopleRepository;
            _dbContext = dbContext;
            _logger = logger;
        }

        [EnableQuery]
        [HttpGet("odata-dto/People")]
        public IActionResult GetQueryableDto()
        {
            try
            {
                return Ok(_peopleRepository.Query());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting people");
                return StatusCode(500, null);
            }
        }

        [EnableQuery]
        [HttpGet("odata-dto/EnumerablePeople")]
        public async Task<IActionResult> GetEnumerableDto([FromQuery]PeopleSearchRequestDto searchCriteria)
        {
            try
            {
                return Ok(await _peopleRepository.GetAll(searchCriteria));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting people");
                return StatusCode(500, null);
            }
        }



        [EnableQuery(MaxExpansionDepth = 0)]
        [HttpGet("odata/People")]
        public IActionResult GetQueryable()
        {
            try
            {
                return Ok(_dbContext.People);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting people");
                return StatusCode(500, null);
            }
        }
    }
}
