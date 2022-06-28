using OData_IQ_API.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OData_IQ_API.Repositories
{
    public class BaseRepository
    {
        protected readonly RecordStoreDbContext DataContext;

        public BaseRepository(RecordStoreDbContext dataContext)
        {
            DataContext = dataContext;
        }
    }
}
