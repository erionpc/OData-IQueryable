using System.ComponentModel.DataAnnotations;

namespace OData_IQ_API.DTOs
{
    public class RatingDto
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public PersonDto? RatedByPerson { get; set; }
        public DateTime RatedDate { get; set; }
        public MusicRecordDto? Record { get; set; }
        public RecordStoreDto? Store { get; set; }
    }
}
