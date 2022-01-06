using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class user_voucher
    {
        private string matk, makm;

        public string Matk { get => matk; set => matk = value; }
        public string Makm { get => makm; set => makm = value; }

        public user_voucher() { }
        public user_voucher(string matk, string makm)
        {
            this.makm = makm;
            this.matk = matk;
        }
    }
}
