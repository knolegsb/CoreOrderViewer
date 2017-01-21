using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderViewer.Core.EntityLayer;

namespace OrderViewer.Core.DataLayer.Mapping
{
    public class SalesOrderHeaderMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<SalesOrderHeader>();
            entity.ToTable("SalesOrderHeader", "Sales");
            entity.HasKey(p => p.SalesOrderId);
            entity.Property(p => p.SalesOrderId).UseSqlServerIdentityColumn();
            entity.HasOne(p => p.BillAddressFk).WithMany(p => p.BillingOrders).HasForeignKey(p => p.BillToAddressId);
            entity.HasOne(p => p.ShipAddressFk).WithMany(p => p.ShippingOrders).HasForeignKey(p => p.ShipToAddressId);
        }
    }
}
