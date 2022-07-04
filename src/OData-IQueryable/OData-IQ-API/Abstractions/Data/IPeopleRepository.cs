using OData_IQ_API.DTOs;
using OData_IQ_API.DTOs.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OData_IQ_API.Abstractions.Data
{
    public interface IPeopleRepository
    {
        Task<List<PersonDto>> GetAll(PeopleSearchRequestDto searchCriteria);
        IQueryable<PersonDto> Query();
    }
}
