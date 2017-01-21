using OrderViewer.Core.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderViewer.Core.DataLayer.DataContracts
{
    public class OrderDetailViewModel
    {
        public OrderDetailViewModel(SalesOrderDetail entity)
        {
            SalesOrderId = entity.SalesOrderId;
            SalesOrderDetailId = entity.SalesOrderDetailId;
            CarrierTrackingNumber = entity.CarrierTrackingNumber;
            OrderQty = entity.OrderQty;
            ProductId = entity.ProductId;
            ProductName = entity.ProductFk.Name;
            SpecialOfferId = entity.SpecialOfferId;
            UnitPrice = entity.UnitPrice;
            UnitPriceDiscount = entity.UnitPriceDiscount;
            LineTotal = entity.LineTotal;
            ModifiedDate = entity.ModifiedDate;
        }

        public Int32? SalesOrderId { get; set; }
        public Int32? SalesOrderDetailId { get; set; }
        public string CarrierTrackingNumber { get; set; }
        public Int16? OrderQty { get; set; }
        public Int32? ProductId { get; set; }
        public string ProductName { get; set; }
        public Int32? SpecialOfferId { get; set; }
        public Decimal? UnitPrice { get; set; }
        public Decimal? UnitPriceDiscount { get; set; }
        public Decimal? LineTotal { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
