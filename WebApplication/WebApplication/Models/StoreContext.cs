using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class StoreContext
    {
        public string ConnectionString { get; set; }//biết thành viên 

        public StoreContext(string connectionString) //phuong thuc khoi tao
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection() //lấy connection 
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Book> GetBook()
        {
            List<Book> list = new List<Book>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from booklist limit 60";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Book()
                        {
                            Masach = Convert.ToInt32(reader["masach"]),
                            Tensach = reader["tensach"].ToString(),
                            Hinhanh = reader["hinhanh"].ToString(),
                            Theloai = reader["theloai"].ToString(),
                            Giaban = Convert.ToInt32(reader["giaban"]),
                            Giagoc = Convert.ToInt32(reader["giagoc"]),
                            Giamgia = Convert.ToInt32(reader["giamgia"]),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }

        public List<Book> FlashSales()
        {
            List<Book> list = new List<Book>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from booklist where giamgia > 23";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Book()
                        {
                            Masach = Convert.ToInt32(reader["masach"]),
                            Tensach = reader["tensach"].ToString(),
                            Hinhanh = reader["hinhanh"].ToString(),
                            Theloai = reader["theloai"].ToString(),
                            Giaban = Convert.ToInt32(reader["giaban"]),
                            Giagoc = Convert.ToInt32(reader["giagoc"]),
                            Giamgia = Convert.ToInt32(reader["giamgia"]),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }

        public Book ViewBook(int name)
        {
            Book bo = new Book();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from booklist where masach=@tensach";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("tensach", name);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    bo.Masach = Convert.ToInt32(reader["masach"]);
                    bo.Tensach = reader["tensach"].ToString();
                    bo.Tacgia = reader["tacgia"].ToString();
                    bo.Hinhanh = reader["hinhanh"].ToString();
                    bo.Theloai = reader["theloai"].ToString();
                    bo.Giagoc = Convert.ToInt32(reader["giagoc"]);
                    bo.Giaban = Convert.ToInt32(reader["giaban"]);
                    bo.Nxb = reader["nxb"].ToString();
                    bo.Hinhthuc = reader["hinhthuc"].ToString();
                    bo.Mota = reader["mota"].ToString();
                    bo.Giamgia = Convert.ToInt32(reader["giamgia"]);
                }
            }
            return (bo);
        }

        public List<Book> DsLienQuan(int name)
        {
            List<Book> list = new List<Book>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from booklist where theloai in (select theloai from booklist where masach = @tensach)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("tensach", name);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Book()
                        {
                            Tensach = reader["tensach"].ToString(),
                            Hinhanh = reader["hinhanh"].ToString(),
                            Theloai = reader["theloai"].ToString(),
                            Giaban = Convert.ToInt32(reader["giaban"]),
                            Giagoc = Convert.ToInt32(reader["giagoc"]),
                            Giamgia = Convert.ToInt32(reader["giamgia"]),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }

        public int DangKy(client_accounts kh)
        {
            DateTime ngaytao = DateTime.Now;
            string value = "chưa có";
            string tinhtrang = "đang sử dụng";
            int sl = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "insert into client_accounts (`diachi`, `diem`, `email`, `gioitinh`, `hoten`, `tentk`, `matkhau`, `ngaysinh`, `ngaytao`, `sl_giohang`, `sodt`,`tinhtrang` " +
                    ") values(@diachi, @diem, @email, @gioitinh, @hoten, @tentk, @matkhau, @ngaysinh, @ngaytao, @sl_giohang, @sodt, @tinhtrang)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("diachi", value);
                cmd.Parameters.AddWithValue("email", value);
                cmd.Parameters.AddWithValue("diem", sl);
                cmd.Parameters.AddWithValue("sodt", kh.Sodt);
                cmd.Parameters.AddWithValue("giohang", value);
                cmd.Parameters.AddWithValue("gioitinh", value);
                cmd.Parameters.AddWithValue("hoten", value);
                cmd.Parameters.AddWithValue("tentk", kh.Tentk);
                cmd.Parameters.AddWithValue("matkhau", kh.Matkhau);
                cmd.Parameters.AddWithValue("ngaysinh", value);
                cmd.Parameters.AddWithValue("ngaytao", ngaytao);
                cmd.Parameters.AddWithValue("sl_giohang", sl);
                cmd.Parameters.AddWithValue("tinhtrang", tinhtrang);
                return (cmd.ExecuteNonQuery());

            }
        }

        public List<vouchers> GetVoucher()
        {
            List<vouchers> list = new List<vouchers>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from khuyenmais";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new vouchers()
                        {
                            Makm = reader["makm"].ToString(),
                            Img = reader["img"].ToString(),
                            Noidung = reader["noidung"].ToString(),
                            Phantram = Convert.ToInt32(reader["phantram"]),
                            Dieukien = Convert.ToInt32(reader["dieukien"]),
                            Sl = Convert.ToInt32(reader["sl"]),
                            Daluu = Convert.ToInt32(reader["daluu"]),
                            Manhap = reader["manhap"].ToString(),
                            Loai = reader["loai"].ToString(),
                            Ngaybd = Convert.ToDateTime(reader["ngaybd"]),
                            Ngaykt = Convert.ToDateTime(reader["ngaykt"]),


                        });
                    }
                    reader.Close();
                }

                conn.Close();
            }
            return list;
        }

        public client_accounts Client_Accounts(string tentk)
        {
            client_accounts tk = new client_accounts();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from client_accounts where tentk = @tentk";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("tentk", tentk);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    tk.Matk = reader["matk"].ToString();
                    tk.Tentk = reader["tentk"].ToString();
                    tk.Diachi = reader["diachi"].ToString();
                    tk.Tinhtrang = reader["tinhtrang"].ToString();
                    tk.Email = reader["email"].ToString();
                    tk.Matkhau = reader["matkhau"].ToString();
                    tk.Gioitinh = reader["gioitinh"].ToString();
                    tk.Sodt = reader["sodt"].ToString();
                    tk.Hoten = reader["hoten"].ToString();
                    tk.Diem = Convert.ToInt32(reader["diem"]);
                    tk.Sl_giohang = Convert.ToInt32(reader["sl_giohang"]);
                    /*    tk.Ngaytao = Convert.ToDateTime(reader["ngaytao"]);*/
                    tk.Ngaysinh = Convert.ToDateTime(reader["ngaysinh"]);
                }
            }
            
            return tk;
        }

        public List<vouchers> User_Voucher(string tentk)
        {

            List<vouchers> list = new List<vouchers>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "Select vc.makm, loai, img, noidung, phantram, dieukien, sl, daluu, manhap,ngaybd, ngaykt" +
                    " from khuyenmais k, user_voucher vc, client_accounts c where k.makm = vc.makm and vc.matk = c.matk and c.tentk = @tentk";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("tentk", tentk);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new vouchers()
                        {
                            Makm = reader["makm"].ToString(),
                            Img = reader["img"].ToString(),
                            Noidung = reader["noidung"].ToString(),
                            Phantram = Convert.ToInt32(reader["phantram"]),
                            Dieukien = Convert.ToInt32(reader["dieukien"]),
                            Sl = Convert.ToInt32(reader["sl"]),
                            Daluu = Convert.ToInt32(reader["daluu"]),
                            Manhap = reader["manhap"].ToString(),
                            Loai = reader["loai"].ToString(),
                            Ngaybd = Convert.ToDateTime(reader["ngaybd"]),
                            Ngaykt = Convert.ToDateTime(reader["ngaykt"]),
                        });
                    }
                    reader.Close();
                }

                conn.Close();
            }
            return list;
        }

        public List<object> Cart(string matk)
        {
            List<object> list = new List<object>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select booklist.masach as masach, tensach, hinhanh, giaban, cart.soluong as soluong, theloai " +
                    "from booklist,cart,client_accounts WHERE booklist.masach=cart.masach and client_accounts.matk=cart.matk and client_accounts.matk=@matk";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("matk", matk);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            Masach = Convert.ToInt32(reader["masach"]),
                            Tensach = reader["tensach"].ToString(),
                            Hinhanh = reader["hinhanh"].ToString(),
                            Theloai = reader["theloai"].ToString(),
                            Giaban = Convert.ToInt32(reader["giaban"]),
                            Soluong = Convert.ToInt32(reader["soluong"]),
                            Thanhtien = Convert.ToInt32(reader["giaban"])* Convert.ToInt32(reader["soluong"]),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }

        public client_accounts Login(string username, string password)
        {
            client_accounts client_Accounts = new client_accounts();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from client_accounts where tentk=@username and matkhau=@password";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        client_Accounts.Diachi = reader["diachi"].ToString();
                        client_Accounts.Diem = Convert.ToInt32(reader["diem"]);
                        client_Accounts.Email = reader["email"].ToString();
                        client_Accounts.Gioitinh = reader["gioitinh"].ToString();
                        client_Accounts.Hoten = reader["hoten"].ToString();
                        client_Accounts.Matk = reader["matk"].ToString();
                        client_Accounts.Matkhau = reader["matkhau"].ToString();
                        client_Accounts.Ngaysinh = DateTime.Parse(reader["ngaysinh"].ToString());
                        client_Accounts.Ngaytao = DateTime.Parse(reader["ngaytao"].ToString());
                        client_Accounts.Sl_giohang = Convert.ToInt32(reader["sl_giohang"]);
                        client_Accounts.Sodt = reader["sodt"].ToString();
                        client_Accounts.Tinhtrang = reader["tinhtrang"].ToString();
                        client_Accounts.Tentk = reader["tentk"].ToString();

                    }
                    reader.Close();
                }
                conn.Close();

            }
            return client_Accounts;
        }

        public List<Book> Search_Book(string ten_sach)
        {
            List<Book> list = new List<Book>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from booklist where tensach like" + "'" + "%" + ten_sach + "%" + "'" + " or tacgia like" + "'" + "%" + ten_sach + "%" + "'" + "limit 40"; 
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ten_sach", ten_sach);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Book()
                        {
                            Tensach = reader["tensach"].ToString(),
                            Hinhanh = reader["hinhanh"].ToString(),
                            Theloai = reader["theloai"].ToString(),
                            Giaban = Convert.ToInt32(reader["giaban"]),
                            Giagoc = Convert.ToInt32(reader["giagoc"]),
                            Giamgia = Convert.ToInt32(reader["giamgia"]),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        public List<Book> Search_Category(string cate)
        {
            List<Book> list = new List<Book>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from booklist where theloai like" + "'" + "%" + cate + "%" + "'" + "limit 40";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("cate", cate);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Book()
                        {
                            Tensach = reader["tensach"].ToString(),
                            Hinhanh = reader["hinhanh"].ToString(),
                            Theloai = reader["theloai"].ToString(),
                            Giaban = Convert.ToInt32(reader["giaban"]),
                            Giagoc = Convert.ToInt32(reader["giagoc"]),
                            Giamgia = Convert.ToInt32(reader["giamgia"]),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        public List<Book> Search_Filter( string ngonngu, string nxb)
        {
            List<Book> list = new List<Book>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from booklist where ngonngu in (@ngonngu) intersect (select * from booklist where nxb in (@nxb)) limit 40";
                MySqlCommand cmd = new MySqlCommand(str, conn);
               /* cmd.Parameters.AddWithValue("price", price);*/
                cmd.Parameters.AddWithValue("ngonngu", ngonngu);
                cmd.Parameters.AddWithValue("nxb", nxb);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Book()
                        {
                            Tensach = reader["tensach"].ToString(),
                            Hinhanh = reader["hinhanh"].ToString(),
                            Theloai = reader["theloai"].ToString(),
                            Giaban = Convert.ToInt32(reader["giaban"]),
                            Giagoc = Convert.ToInt32(reader["giagoc"]),
                            Giamgia = Convert.ToInt32(reader["giamgia"]),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        public List<comment> binhluan(int masach)
        {
            List<comment> list = new List<comment>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from user_cmt cmt, client_accounts c where cmt.matk = c.matk and masach = @tensach";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("tensach", masach);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new comment()
                        {
                            Matk = reader["tentk"].ToString(),
                            Masach = reader["masach"].ToString(),
                            Binhluan = reader["binhluan"].ToString(),
                            Ngaybl = Convert.ToDateTime(reader["ngaybl"]),
                            Sosao = Convert.ToInt32(reader["sosao"]),
                        });
                    }
                    reader.Close();
                }
                conn.Close(); 
            }
            return list;
        }

        public int thembinhluan(comment c)
        {
            DateTime Ngaybl = DateTime.Now;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "insert into user_cmt (`matk`, `masach`,`binhluan`, `ngaybl`, `sosao`) values" +
                    "(@matk, @masach, @binhluan, @ngaybl, @sosao);";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("masach", c.Masach);
                cmd.Parameters.AddWithValue("matk", c.Matk);
                cmd.Parameters.AddWithValue("binhluan", c.Binhluan);
                cmd.Parameters.AddWithValue("ngaybl", Ngaybl);
                cmd.Parameters.AddWithValue("sosao", c.Sosao);
                return cmd.ExecuteNonQuery();
            }
        }

        public List<orders> DonHang(string matk)
        {
            List<orders> list = new List<orders>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from orders where matk = @matk";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("matk", matk);
                
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new orders()
                        {

                            Madh = Convert.ToInt32(reader["madh"]),
                            Matk = Convert.ToInt32(reader["matk"]),
                            Makm = Convert.ToInt32(reader["makm"]),

                            Tienship = Convert.ToInt32(reader["tienship"]),
                            Phanhoi = reader["phanhoi"].ToString(),
                            Tinhtrangdonhang = reader["tinhtrangdonhang"].ToString(),
                            Tinhtrangthanhtoan = reader["tinhtrangthanhtoan"].ToString(),
                            Tongtien = Convert.ToInt32(reader["tongtien"]),
                            Hinhthucthanhtoan = reader["hinhthucthanhtoan"].ToString(),

                            Ngaycapnhat = Convert.ToDateTime(reader["ngaycapnhat"]),
                            Ngaylap = Convert.ToDateTime(reader["ngaylap"]),


                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }


        public List<detail_orders> Detail_Orders(string madh)
        {
            List<detail_orders> list = new List<detail_orders>();
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from detail_order where madh = @madh";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("madh", madh);
                using(var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new detail_orders()
                        {
                            Madh = Convert.ToInt32(reader["madh"]),
                            Masach = Convert.ToInt32(reader["masach"]),
                            Soluong = Convert.ToInt32(reader["soluong"]),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<Book> BookOfOrder(string matk)
        {
            List<Book> list = new List<Book>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select b.masach, b.hinhanh, theloai, giaban, giagoc,giamgia, d.soluong, d.madh, b.tensach from booklist b," +
                    " detail_order d, orders o where b.masach = d.masach and o.madh = d.madh and o.matk = @matk";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("matk", matk);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Book()
                        {
                            Tensach = reader["tensach"].ToString(),
                            Hinhanh = reader["hinhanh"].ToString(),
                            Masach = Convert.ToInt32(reader["madh"]),
                            Giaban = Convert.ToInt32(reader["giaban"]),
                            Giagoc = Convert.ToInt32(reader["giagoc"]),
                            Giamgia = Convert.ToInt32(reader["giamgia"]),
                            Soluong = Convert.ToInt32(reader["soluong"]),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        public int capnhattaikhoan(string Matk, string Email, string Sodt, string Gioitinh, string Ngaysinh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "update client_accounts set email = @email, sodt = @sodt, ngaysinh = @ngaysinh, gioitinh = @gioitinh where tentk = @matk";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("matk", Matk);
                cmd.Parameters.AddWithValue("sodt", Sodt);
                cmd.Parameters.AddWithValue("gioitinh", Gioitinh);
                cmd.Parameters.AddWithValue("ngaysinh", Ngaysinh);
                cmd.Parameters.AddWithValue("email", Email);

                return (cmd.ExecuteNonQuery());
            }

        }

        public int capnhatdiachi(string Matk, string Sodt, string Diachi, string Hoten)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "update client_accounts set hoten = @hoten, sodt = @sodt, diachi = @diachi where tentk = @matk";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("matk", Matk);
                cmd.Parameters.AddWithValue("sodt", Sodt);
                cmd.Parameters.AddWithValue("diachi", Diachi);
                cmd.Parameters.AddWithValue("hoten", Hoten);

                return (cmd.ExecuteNonQuery());
            }

        }

        public int capnhatmatkhau(string Matk, string Matkhau)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "update client_accounts set matkhau = @matkhau where tentk = @matk";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("matk", Matk);
                cmd.Parameters.AddWithValue("matkhau", Matkhau);

                return (cmd.ExecuteNonQuery());
            }

        }


    }
}
