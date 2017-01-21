using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderViewer.Core.EntityLayer
{
    public class Person
    {
        public Int32? BusinessEntityId { get; set; }
        public string PersonType { get; set; }
        public Boolean? NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public Int32? EmailPromotion { get; set; }
        public string AdditionalContactInfo { get; set; }
        public string Demographics { get; set; }
        public Guid? Rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
