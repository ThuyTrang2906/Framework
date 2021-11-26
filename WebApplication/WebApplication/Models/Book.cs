using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Book
    {
        private string tensach;
        private string hinhanh;
        private string theloai;
        private int giaban;
        private string giagoc;
        private int giamgia;
        private string mota;
        private string tacgia;
        private DateTime namxb;
        private string nxb;
        private string hinhthuc;


        public string Tensach { get => tensach; set => tensach = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }
        public string Theloai { get => theloai; set => theloai = value; }
        public int Giaban { get => giaban; set => giaban = value; }
        public string Giagoc { get => giagoc; set => giagoc = value; }
        public int Giamgia { get => giamgia; set => giamgia = value; }
        public string Mota { get => mota; set => mota = value; }
        public string Tacgia { get => tacgia; set => tacgia = value; }
        public DateTime Namxb { get => namxb; set => namxb = value; }
        public string Nxb { get => nxb; set => nxb = value; }
        public string Hinhthuc { get => hinhthuc; set => hinhthuc = value; }

        public Book(string TENSACH, string HINHANH, string THELOAI, int GIABAN, string GIAGOC, int GIAMGIA, string MOTA, string TACGIA, DateTime NAMXB, string NXB, string HINHTHUC)
        {
            this.tensach = TENSACH;
            this.hinhanh = HINHANH;
            this.theloai = THELOAI;
            this.giaban = GIABAN;
            this.giagoc = GIAGOC;
            this.giamgia = GIAMGIA;
            this.mota = MOTA;
            this.tacgia = TACGIA;
            this.namxb = NAMXB;
            this.nxb = NXB;
            this.hinhthuc = HINHTHUC;
        }

        public Book()
        {
        }
    }
}
