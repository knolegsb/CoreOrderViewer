using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OrderViewer.Core.DataLayer.Mapping
{
    public class EntityMapper : IEntityMapper
    {
        public IEnumerable<IEntityMap> Mappings { get; protected set; }        

        public void MapEntities(ModelBuilder modelBuilder)
        {
            foreach (var item in Mappings)
            {
                item.Map(modelBuilder);
            }
        }
    }
}
