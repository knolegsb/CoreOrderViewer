using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderViewer.Core.EntityLayer;

namespace OrderViewer.Core.DataLayer.Mapping
{
    public class ProductSubcategoryMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<ProductSubcategory>();
            entity.ToTable("ProductSubcategory", "Production");
            entity.HasKey(p => p.ProductSubcategoryId);
            entity.Property(p => p.ProductSubcategoryId).UseSqlServerIdentityColumn();
        }
    }
}
