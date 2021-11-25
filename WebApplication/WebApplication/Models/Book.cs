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

        public string Tensach { get => tensach; set => tensach = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }
        public string Theloai { get => theloai; set => theloai = value; }
        public int Giaban { get => giaban; set => giaban = value; }
        public string Giagoc { get => giagoc; set => giagoc = value; }
        public int Giamgia { get => giamgia; set => giamgia = value; }

        public Book(string TENSACH, string HINHANH, string THELOAI, int GIABAN, string GIAGOC, int GIAMGIA)
        {
            this.tensach = TENSACH;
            this.hinhanh = HINHANH;
            this.theloai = THELOAI;
            this.giaban = GIABAN;
            this.giagoc = GIAGOC;
            this.giamgia = GIAMGIA;
        }

        public Book()
        {
        }
    }
}
