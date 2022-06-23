using Microsoft.OData.ModelBuilder;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OData_IQ_API.Entities
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Email { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [Required]
        [StringLength(50)]
        public string? Surname { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTimeOffset DateOfBirth { get; set; }

        [Contained]
        public ICollection<PersonMusicRecord> Records { get; set; } = new List<PersonMusicRecord>();
    }
}
