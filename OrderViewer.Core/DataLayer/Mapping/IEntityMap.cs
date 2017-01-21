using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderViewer.Core.DataLayer.Mapping
{
    public interface IEntityMap
    {
        void Map(ModelBuilder modelBuilder);
    }
}
