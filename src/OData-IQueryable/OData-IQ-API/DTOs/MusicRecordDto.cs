using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OData_IQ_API.DTOs
{
    public class MusicRecordDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Artist { get; set; }
        public int? Year { get; set; }
        public IEnumerable<RatingDto>? Ratings { get; set; } = new List<RatingDto>();
    }
}
