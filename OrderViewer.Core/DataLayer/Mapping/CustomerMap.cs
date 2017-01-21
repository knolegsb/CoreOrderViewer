using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderViewer.Core.EntityLayer;

namespace OrderViewer.Core.DataLayer.Mapping
{
    public class CustomerMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Customer>();
            entity.ToTable("Customer", "Sales");
            entity.HasKey(p => p.CustomerId);
            entity.Property(p => p.CustomerId).UseSqlServerIdentityColumn();
        }
    }
}
