using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderViewer.Core.EntityLayer
{
    public class Product
    {
        public Int32? ProductId { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public Boolean? MakeFlag { get; set; }
        public Boolean? FinishedGoodsFlag { get; set; }
        public Int16? SafetyStockLevel { get; set; }
        public Int16? ReorderPoint { get; set; }
        public Decimal? StandardCost { get; set; }
        public Decimal? ListPrice { get; set; }
        public Int32? DaysToManufacture { get; set; }
        public DateTime? SellStartDate { get; set; }
        public Guid? Rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
