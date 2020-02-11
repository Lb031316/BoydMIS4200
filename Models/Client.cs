using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoydMIS4200.Models
{
    public class Client
    {
        public int clientID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime clientSince { get; set; }

        public ICollection<Appointment> Appointment { get; set; }
    }
}