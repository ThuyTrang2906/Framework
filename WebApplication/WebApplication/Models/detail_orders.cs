using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class detail_orders
    {
        private int madh;
        private int masach;
        private int soluong;

        public int Madh { get => madh; set => madh = value; }
        public int Masach { get => masach; set => masach = value; }
        public int Soluong { get => soluong; set => soluong = value; }

        public detail_orders(int madh, int masach, int soluong)
        {
            this.madh = madh;
            this.masach = masach;
            this.soluong = soluong;
        }

    }
}
