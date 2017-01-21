using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderViewer.Core.DataLayer.DataContracts
{
    public class OrderSummaryViewModel
    {
        public Int32? SalesOrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public string SalesOrderNumber { get; set; }
        public Int32? CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string StoreName { get; set; }
        public Int32 Lines { get; set; }
        public Decimal? TotalDue { get; set; }
    }
}
