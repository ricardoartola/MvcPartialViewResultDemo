using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPartialViewResultDemo.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string DoorNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PinNumber { get; set; }
    }
}