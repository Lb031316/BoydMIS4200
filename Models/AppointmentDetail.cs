using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoydMIS4200.Models
{
    public class AppointmentDetail
    {
        public int AppointmentdetailID { get; set; }
        
        public decimal cost { get; set; }
        // the next two properties link the orderDetail to the Order
        public int appointmentID { get; set; }
        public virtual Appointment Appointment { get; set; }
        // the next two properties link the appointmentDetail to the Product
        public int vetID { get; set; }
        public virtual Vet vet { get; set; }
    }
}