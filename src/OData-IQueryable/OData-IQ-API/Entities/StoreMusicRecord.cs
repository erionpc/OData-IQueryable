using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OData_IQ_API.Entities
{
    public class StoreMusicRecord
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int RecordStoreId { get; set; }

        public RecordStore? Store { get; set; }

        [Required]
        public int RecordId { get; set; }

        public MusicRecord? Record { get; set; }

        public DateTime? DateFirstArrived { get; set; }
    }
}
