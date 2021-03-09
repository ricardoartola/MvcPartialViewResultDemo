using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPartialViewResultDemo.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address PermanentAdress { get; set; }
        public Address PresentAdress { get; set; }
    }
}