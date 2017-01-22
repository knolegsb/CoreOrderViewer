using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using OrderViewer.Core.DataLayer.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderViewer.Core.DataLayer
{
    public class AdventureWorksDbContext : DbContext
    {
        public AdventureWorksDbContext(IOptions<AppSettings> appSettings, IEntityMapper entityMapper)
        {
            ConnectionString = appSettings.Value.ConnectionString;
            EntityMapper = entityMapper;
        }

        public string ConnectionString { get; }
        public IEntityMapper EntityMapper { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            EntityMapper.MapEntities(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
