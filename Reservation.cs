using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBS
{
    public class Reservation
    {
        public Client c { get; set; }
        public Room r{ get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public double total { get; set; }

        public Reservation(Client c, Room r, DateTime CheckIn, DateTime CheckOut)
        {
            this.c = c;
            this.r = r;
            this.CheckIn = CheckIn;
            this.CheckOut = CheckOut;

            int days = (CheckOut - CheckIn).Days;

            total = days * r.PriceNight;
        }

    }
}
