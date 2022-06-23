using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OData_IQ_API.Entities
{
    public class RecordStore
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string? Name { get; set; }

        public Address? StoreAddress { get; set; }

        [StringLength(500)]
        public Uri? StoreUri { get; set; }

        public List<string> Tags { get; set; } = new List<string>();

        public ICollection<MusicRecord> Records { get; set; } = new List<MusicRecord>();

        public ICollection<Rating> Ratings { get; set; } = new List<Rating>();
    }
}
