using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderViewer.Core.DataLayer.Contracts
{
    public interface IProductionRepository : IDisposable
    {
        IEnumerable<ProductSubcategoryViewModel> GetProductSubcategories(Int32 pageSize, Int32 pageNumber);
    }
}
