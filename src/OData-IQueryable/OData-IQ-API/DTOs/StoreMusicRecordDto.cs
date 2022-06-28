using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OData_IQ_API.DTOs
{
    public class StoreMusicRecordDto
    {
        public int Id { get; set; }
        public RecordStoreDto? Store { get; set; }
        public MusicRecordDto? Record { get; set; }
        public DateTime? DateFirstArrived { get; set; }
    }
}
