using Microsoft.OData.ModelBuilder;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OData_IQ_API.DTOs
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }
        public IEnumerable<PersonMusicRecordDto> Records { get; set; } = new List<PersonMusicRecordDto>();
    }
}
