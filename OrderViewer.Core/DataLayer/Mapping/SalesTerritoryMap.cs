﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderViewer.Core.EntityLayer;

namespace OrderViewer.Core.DataLayer.Mapping
{
    public class SalesTerritoryMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<SalesTerritory>();
            entity.ToTable("SalesTerritory", "Sales");
            entity.HasKey(p => p.TerritoryId);
            entity.Property(p => p.TerritoryId).UseSqlServerIdentityColumn();
        }
    }
}
