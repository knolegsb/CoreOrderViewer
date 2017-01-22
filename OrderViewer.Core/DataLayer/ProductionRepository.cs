using OrderViewer.Core.DataLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderViewer.Core.DataLayer.DataContracts;
using OrderViewer.Core.EntityLayer;

namespace OrderViewer.Core.DataLayer
{
    public class ProductionRepository : Repository, IProductionRepository
    {
        public ProductionRepository(AdventureWorksDbContext dbContext) : base(dbContext)
        {

        }
        public IEnumerable<ProductSubcategoryViewModel> GetProductSubcategories(int pageSize, int pageNumber)
        {
            var query = from productSubcategory in DbContext.Set<ProductSubcategory>()
                        select new ProductSubcategoryViewModel
                        {
                            ProductSubcategoryId = productSubcategory.ProductSubcategoryId,
                            ProductCategoryId = productSubcategory.ProductCategoryId,
                            Name = productSubcategory.Name,
                            ModifiedDate = productSubcategory.ModifiedDate
                        };
            return pageSize > 0 && pageNumber > 0 ? query.Skip((pageNumber - 1) * pageSize).Take(pageSize) : query;
        }
    }
}
