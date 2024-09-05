using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_IMDb.Models
{
    public class ReservationDAO
    {
        public int requestID { get; set; }
        public string movieID { get; set; }
        public int userID { get; set; }
        public string reservationDate { get; set; }
        public string deliveryDate { get; set; }
        public bool delivered { get; set; }
    }
}
