using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OData_IQ_API.Entities
{
    public class MusicRecord
    {
        [Key]
        public int Id { get; set; }

        [StringLength(150)]
        [Required]
        public string? Title { get; set; }

        [StringLength(150)]
        [Required]
        public string? Artist { get; set; }

        public int? Year { get; set; }

        public ICollection<Rating> Ratings { get; set; } = new List<Rating>();
    }
}
