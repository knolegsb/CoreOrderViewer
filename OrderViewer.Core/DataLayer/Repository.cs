using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderViewer.Core.DataLayer
{
    public abstract class Repository
    {
        protected readonly AdventureWorksDbContext DbContext;
        protected Boolean Disposed;

        public Repository(AdventureWorksDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public void Dispose()
        {
            if (DbContext != null)
            {
                DbContext.Dispose();
                Disposed = true;
            }
        }
    }
}
