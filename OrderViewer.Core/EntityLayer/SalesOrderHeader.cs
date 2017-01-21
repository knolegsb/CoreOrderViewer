using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace OrderViewer.Core.EntityLayer
{
    public class SalesOrderHeader
    {
        public Int32? SalesOrderId { get; set; }
        public Byte? RevitionNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public Byte? Status { get; set; }
        public Boolean? OnlineOrderFlag { get; set; }
        public string SalesOrderNumber { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string AccountNumber { get; set; }
        public Int32? CustomerId { get; set; }
        public Int32? SalesPersonId { get; set; }
        public Int32? TerritoryId { get; set; }
        public Int32? BillToAddressId { get; set; }
        public Int32? ShipToAddressId { get; set; }
        public Int32? ShipMethodId { get; set; }
        public Int32? CreditCardId { get; set; }
        public string CreditCardApprovalCode { get; set; }
        public Int32? CurrencyRateId { get; set; }
        public Decimal? SubTotal { get; set; }
        public Decimal? TaxAmt { get; set; }
        public Decimal? Freight { get; set; }
        public Decimal? TotalDue { get; set; }
        public string Comment { get; set; }
        public Guid? Rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public virtual Customer CustomerFk { get; set; }
        public virtual SalesPerson SalesPersonFk { get; set; }
        public virtual SalesTerritory SalesTerritoryFk { get; set; }
        public virtual Address BillAddressFk { get; set; }
        public virtual Address ShipAddressFk { get; set; }
        public virtual ShipMethod ShipMethodFk { get; set; }
        public virtual Collection<SalesOrderDetail> SalesOrderDetails { get; set; }
    }
}
