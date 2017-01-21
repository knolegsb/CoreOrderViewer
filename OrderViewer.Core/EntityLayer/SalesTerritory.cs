using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderViewer.Core.EntityLayer
{
    public class SalesTerritory
    {
        public Int32? TerritoryId { get; set; }
        public string Name { get; set; }
        public string CountryRegionCode { get; set; }
        public string Group { get; set; }
        public Decimal? SalesYTD { get; set; }
        public Decimal? SalesLastYear { get; set; }
        public Decimal? CostYTD { get; set; }
        public Decimal? CostLastYear { get; set; }
        public Guid? Rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
