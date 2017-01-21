using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderViewer.Core.EntityLayer
{
    public class SalesOrderDetail
    {
        public Int32? SalesOrderId { get; set; }
        public Int32? SalesOrderDetailId { get; set; }
        public string CarrierTrackingNumber { get; set; }
        public Int16? OrderQty { get; set; }
        public Int32? ProductId { get; set; }
        public Int32? SpecialOfferId { get; set; }
        public Decimal? UnitPrice { get; set; }
        public Decimal? UnitPriceDiscount { get; set; }
        public Decimal? LineTotal { get; set; }
        public Guid? Rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public virtual Product ProductFk { get; set; }
    }
}
