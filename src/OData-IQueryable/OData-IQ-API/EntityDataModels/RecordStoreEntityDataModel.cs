using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using OData_IQ_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OData_IQ_API.EntityDataModels
{
    public class RecordStoreEntityDataModel
    {
        public IEdmModel GetEntityDataModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.Namespace = "RecordStore";
            builder.ContainerName = "RecordStoreContainer";

            builder.EntitySet<Person>("People");
            builder.EntitySet<RecordStore>("RecordStores");
            builder.EntitySet<MusicRecord>("MusicRecords");

            return builder.GetEdmModel();
        }
    }
}
