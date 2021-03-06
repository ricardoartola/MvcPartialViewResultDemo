using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPartialViewResultDemo.Models
{
    public class CustomerModel
    {
        public int CustmerId { get; set; }
        public string CustomerName { get; set; }
        public CustomerAddressViewModel PermanantAddress { get; set; }
        public CustomerAddressViewModel PresentAddress { get; set; }

    }

    public class CustomerAddressViewModel
    {
        public string DoorNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PinNumber { get; set; }
    }
}