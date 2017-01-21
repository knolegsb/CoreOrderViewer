using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderViewer.Core.DataLayer.DataContracts
{
    public class ProductSubcategoryViewModel
    {
        public Int32? ProductSubcategoryId { get; set; }
        public Int32? ProductCategoryId { get; set; }
        public string Name { get; set; }
        public Guid? Rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
