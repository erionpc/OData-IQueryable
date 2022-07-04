using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using OData_IQ_API.DTOs;
using OData_IQ_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OData_IQ_API.EntityDataModels
{
    public class RecordStoreDtoEntityDataModel
    {
        public IEdmModel GetEntityDataModel()
        {
            var builder = new ODataConventionModelBuilder
            {
                Namespace = "RecordStore",
                ContainerName = "RecordStoreContainer"
            };

            builder.EntitySet<PersonDto>("People");
            builder.EntitySet<RecordStoreDto>("RecordStores");
            builder.EntitySet<MusicRecordDto>("MusicRecords");

            var getEnumerablePeople = builder.Function("EnumerablePeople");
            getEnumerablePeople.ReturnsCollectionFromEntitySet<PersonDto>("People");
            getEnumerablePeople.Namespace = "RecordStore.Functions";

            return builder.GetEdmModel();
        }
    }
}
