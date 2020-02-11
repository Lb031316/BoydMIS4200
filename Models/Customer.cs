using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoydMIS4200.Models
{
    public class Customer
    {
        public int customerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime customerSince { get; set; }

        public ICollection<Order> Order { get; set; }
    }
}
  