using OData_IQ_API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OData_IQ_API.Abstractions.Data
{
    public interface IPeopleRepository
    {
        IQueryable<PersonDto> Query();
    }
}
