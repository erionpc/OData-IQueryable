using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OData_IQ_API.DTOs
{
    public class RecordStoreDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public AddressDto? StoreAddress { get; set; }
        public Uri? StoreUri { get; set; }
        public List<string> Tags { get; set; } = new();
        public IEnumerable<MusicRecordDto>? Records { get; set; } = new List<MusicRecordDto>();
        public IEnumerable<RatingDto>? Ratings { get; set; } = new List<RatingDto>();
    }
}
