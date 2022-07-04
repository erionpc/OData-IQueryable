using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OData_IQ_API.DTOs.Requests
{
    public class PeopleSearchRequestDto
    {
        public int? Id { get; set; }
        public string? Email { get; set; }
        public string? EmailLike { get; set; }
        public string? Name { get; set; }
        public string? NameLike { get; set; }
        public string? Surname { get; set; }
        public string? SurnameLike { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }
        public DateTimeOffset? DateOfBirthBefore { get; set; }
        public DateTimeOffset? DateOfBirthAfter { get; set; }
    }
}
