using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderViewer.Core.EntityLayer
{
    public class Customer
    {
        public Int32? CustomerId { get; set; }
        public Int32? PersonId { get; set; }
        public Int32? StoreId { get; set; }
        public Int32? TerritoryId { get; set; }
        public string AccountNumber { get; set; }
        public Guid? Rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public virtual Person PersonFk { get; set; }
        public virtual Store StoreFk { get; set; }
    }
}
