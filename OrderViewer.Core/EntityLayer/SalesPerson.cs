using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderViewer.Core.EntityLayer
{
    public class SalesPerson
    {
        public Int32? BusinessEntityId { get; set; }
        public Int32? TerrotoryId { get; set; }
        public Decimal? SalesQuota { get; set; }
        public Decimal? Bonus { get; set; }
        public Decimal? CommissionPct { get; set; }
        public Decimal? SalesYTD { get; set; }
        public Decimal? SalesLastYear { get; set; }
        public Guid? Rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public virtual Person PersonFk { get; set; }
    }
}
