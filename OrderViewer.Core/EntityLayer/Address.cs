using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace OrderViewer.Core.EntityLayer
{
    public class Address
    {
        public Int32? AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public Int32? StateProvinceId { get; set; }
        public string PostalCode { get; set; }
        public Guid? Rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public virtual Collection<SalesOrderHeader> BillingOrders { get; set; }
        public virtual Collection<SalesOrderHeader> ShippingOrders { get; set; }
    }
}
