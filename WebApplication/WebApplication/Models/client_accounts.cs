using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class client_accounts
    {
        private string danhsach_km, diachigh, diachigoc, email, giohang, gioitinh, hoten, matk, matkhau, sl_giohang, sodt, tinhtrang;
        private DateTime ngaysinh, ngaytao;
        private int diem;

        public string Danhsach_km { get => danhsach_km; set => danhsach_km = value; }
        public string Diachigh { get => diachigh; set => diachigh = value; }
        public string Diachigoc { get => diachigoc; set => diachigoc = value; }
        public int Diem { get => diem; set => diem = value; }
        public string Email { get => email; set => email = value; }
        public string Giohang { get => giohang; set => giohang = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Matk { get => matk; set => matk = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public DateTime Ngaytao { get => ngaytao; set => ngaytao = value; }
        public string Sl_giohang { get => sl_giohang; set => sl_giohang = value; }
        public string Sodt { get => sodt; set => sodt = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }

        public client_accounts() {  }
        public client_accounts(string danhsach_km, string diachigh, string diachigoc, int diem, string email, string giohang, string gioitinh, string hoten, string matk, string matkhau, DateTime ngaysinh, DateTime ngaytao, string sl_giohang, string sodt, string tinhtrang)
        {

            this.danhsach_km = danhsach_km;
            this.diachigh = diachigh;
            this.diachigoc = diachigoc;
            this.diem = diem;
            this.email = email;
            this.giohang = giohang;
            this.gioitinh = gioitinh;
            this.hoten = hoten;
            this.matk = matk;
            this.matkhau = matkhau;
            this.ngaysinh = ngaysinh;
            this.ngaytao = ngaytao;
            this.sl_giohang = sl_giohang;
            this.sodt = sodt;
            this.tinhtrang = tinhtrang;
        }


    }
}
