using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderViewer.Core.EntityLayer;

namespace OrderViewer.Core.DataLayer.Mapping
{
    public class ProductMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Product>();
            entity.ToTable("Product", "Production");
            entity.HasKey(p => p.ProductId);
            entity.Property(p => p.ProductId).UseSqlServerIdentityColumn();
        }
    }
}
