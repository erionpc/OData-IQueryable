using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OData_IQ_API.DTOs
{
    public class PersonMusicRecordDto
    {
        public int Id { get; set; }
        public StoreMusicRecordDto? StoreRecord { get; set; }
        public DateTime? DateBought { get; set; }
    }
}
