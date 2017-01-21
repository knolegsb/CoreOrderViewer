using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderViewer.Core.EntityLayer
{
    public class ShipMethod
    {
        public Int32? ShipMethodId { get; set; }
        public string Name { get; set; }
        public Decimal? ShipBase { get; set; }
        public Decimal? ShipRate { get; set; }
        public Guid? Rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; } 
    }
}
