using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderViewer.Core.EntityLayer;

namespace OrderViewer.Core.DataLayer.Mapping
{
    public class SalesOrderDetailMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<SalesOrderDetail>();
            entity.ToTable("SalesOrderDetail", "Sales");
            entity.HasKey(p => new { p.SalesOrderId, p.SalesOrderDetailId });
            entity.Property(p => p.SalesOrderDetailId).UseSqlServerIdentityColumn();
        }
    }
}
