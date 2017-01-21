using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderViewer.Core.EntityLayer
{
    public class Store
    {
        public Int32? BusinessEntityId { get; set; }
        public string Name { get; set; }
        public Int32? SalesPersonId { get; set; }
        public string Demographics { get; set; }
        public Guid? Rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
