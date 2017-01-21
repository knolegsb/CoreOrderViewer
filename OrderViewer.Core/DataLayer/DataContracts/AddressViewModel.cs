using OrderViewer.Core.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderViewer.Core.DataLayer.DataContracts
{
    public class AddressViewModel
    {
        public AddressViewModel(Address entity)
        {
            AddressId = entity.AddressId;
            AddressLine1 = entity.AddressLine1;
            AddressLine2 = entity.AddressLine2;
            City = entity.City;
            StateProvinceId = entity.StateProvinceId;
            PostalCode = entity.PostalCode;
        }

        public Int32? AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public Int32? StateProvinceId { get; set; }
        public string PostalCode { get; set; }
    }
}
