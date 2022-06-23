using System.ComponentModel.DataAnnotations;

namespace OData_IQ_API.Entities
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Value { get; set; }

        [Required]
        public int RatedByPersonId { get; set; }

        public Person? RatedByPerson { get; set; }

        public DateTime RatedDate { get; set; }

        [Required]
        public int MusicRecordId { get; set; }

        public MusicRecord? Record { get; set; }
    }
}
