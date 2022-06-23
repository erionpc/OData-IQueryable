using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OData_IQ_API.Entities
{
    public class PersonMusicRecord
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PersonId { get; set; }

        [Required]
        public int StoreRecordId { get; set; }

        public StoreMusicRecord? Record { get; set; }

        public DateTime? DateBought { get; set; }
    }
}
