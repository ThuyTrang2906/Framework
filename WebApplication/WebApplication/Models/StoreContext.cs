using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

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

        public List<Book> GetBook(int x)
        {
            List<Book> list = new List<Book>();
            int size = 0;
            if(x == -1)
            {
                size = 0;
            }
            else
            {
                size = 60 * x;
            }
             
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from booklist limit 60 offset @size";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("size", size);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int gia_ban = Convert.ToInt32(reader["giaban"]);
                        string Gia_ban = gia_ban.ToString("N1");
                        list.Add(new Book()
                        {
                            Danhgia = Convert.ToInt32(reader["danhgia"]),
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
                var str = "select * from booklist where masach=@masach";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("masach", name);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
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
                        bo.Danhgia = Convert.ToInt32(reader["danhgia"]);
                    }
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
                            Thanhtien = Convert.ToInt32(reader["giaban"]) * Convert.ToInt32(reader["soluong"]),
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

        public List<Book> Search_Filter(string giaban, string ngonngu, string nhaxuatban)
        {
            List<Book> list = new List<Book>();
            string str = "select * from booklist where ";
            string str2 = "select * from booklist where ";
            string str3 = "";

            Boolean flag1 = false;
            Boolean flag2 = false;

            if (Convert.ToInt32(giaban) == 50000)
            {
                str3 = "select * from booklist where giaban < 50000";
            }else if (Convert.ToInt32(giaban) == 100000)
            {
                str3 = "select * from booklist where giaban between 50000 and 100000";
            }else if (Convert.ToInt32(giaban) == 150000)
            {
                str3 = "select * from booklist where giaban between 100000 and 150000";
            }else if (Convert.ToInt32(giaban) == 200000)
            {
                str3 = "select * from booklist where giaban between 150000 and 200000";
            }else if (Convert.ToInt32(giaban) == 200001)
            {
                str3 = "select * from booklist where giaban > 200000";
            }

            if (ngonngu != null)
            {
                string[] list_ngonngu = ngonngu.Split("$$");
                for (int i = 0; i < list_ngonngu.Length; i++)
                {
                    if (flag1 == false)
                    {
                        flag1 = true;
                        str += "ngonngu like " + "'%" + list_ngonngu[i] + "%'";
                    }
                    else
                    {
                        str += "or ngonngu like " + "'%" + list_ngonngu[i] + "%'";
                    }
                }
            }
            else{
                str += "ngonngu like " + "'%" + "" + "%'" ;
            }

            if (nhaxuatban != null)
            {
                string[] list_nxb = nhaxuatban.Split("$$");

                for (int i = 0; i < list_nxb.Length; i++)
                {
                    if (flag2 == false)
                    {
                        flag2 = true;
                        str2 += "nxb like " + "'%" + list_nxb[i] + "%'";
                    }
                    else
                    {
                        str2 += "or nxb like " + "'%" + list_nxb[i] + "%'";
                    }
                }
            }
            else
            {
                str2 += "nxb like " + "'%" + "" + "%'";
            }


            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str_com =str3 + " intersect " + "(" + str + " intersect " + "(" + str2 + ")" + ")";
                MySqlCommand cmd = new MySqlCommand(str_com, conn); 
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
            int Masach = Convert.ToInt32(c.Masach);
            if(Update_danhgia(Masach) > 0)
            {
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
            else
            {
                return 0;
            }
           
        
        }

        public int Update_danhgia(int masach)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "update booklist set danhgia = danhgia+1 where masach = @masach";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("masach", masach);
                return (cmd.ExecuteNonQuery());
            }
        }
        public List<orders> DonHang(int matk)
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
                        if (reader["madh"] != DBNull.Value)
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
                        }
                    
                   
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }

        public orders ViewDonHang(int matk)
        {
            orders o = new orders();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from orders where matk = @matk";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("matk", matk);

                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    o.Madh = Convert.ToInt32(reader["madh"]);
                    o.Matk = Convert.ToInt32(reader["matk"]);
                    o.Makm = Convert.ToInt32(reader["makm"]);
                    o.Tienship = Convert.ToInt32(reader["tienship"]);
                    o.Phanhoi = reader["phanhoi"].ToString();
                    o.Tinhtrangdonhang = reader["tinhtrangdonhang"].ToString();
                    o.Tinhtrangthanhtoan = reader["tinhtrangthanhtoan"].ToString();
                    o.Tongtien = Convert.ToInt32(reader["tongtien"]);
                    o.Hinhthucthanhtoan = reader["hinhthucthanhtoan"].ToString();
                    o.Ngaycapnhat = Convert.ToDateTime(reader["ngaycapnhat"]);
                    o.Ngaylap = Convert.ToDateTime(reader["ngaylap"]);
                }
            }
            return o;
        }


        public int SoluongMua(int madh)
        {
            int soluong;
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select sum(soluong) as soluong from detail_order where madh = @madh group by madh";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("madh", madh);
                using(var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    soluong = Convert.ToInt32(reader["soluong"]);
                }
            }
            return soluong;
        }
        public int Tamtinh(int madh)
        {
            int tamtinh;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select sum(giaban * d.soluong) as tamtinh from booklist b," +
                    " detail_order d where b.masach = d.masach and d.madh = @madh group by d.madh";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("madh", madh);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    tamtinh = Convert.ToInt32(reader["tamtinh"]);
                }
            }
            return tamtinh;
        }
        public List<Book> BookOfOrder(int matk)
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

        public List<Book> chitietdh(int madh)
        {
            List<Book> list = new List<Book>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select b.masach, b.hinhanh, theloai, giaban, giagoc,giamgia, d.soluong, d.madh, b.tensach from booklist b," +
                    " detail_order d, orders o where b.masach = d.masach and o.madh = d.madh and d.madh = @madh";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("madh", madh);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Book()
                        {

                            Tensach = reader["tensach"].ToString(),
                            Hinhanh = reader["hinhanh"].ToString(),
                            Masach = Convert.ToInt32(reader["masach"]),
                            Giaban = Convert.ToInt32(reader["giaban"]),
                            Giamgia = Convert.ToInt32(reader["giaban"]) * Convert.ToInt32(reader["soluong"]), //thanh tien nha
                            Soluong = Convert.ToInt32(reader["soluong"]), // so luong mua
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

        public int Save_voucher(int matk, int makm)
        {
            int count = Update_khuyenmai(makm);
            if(count > 0)
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string str = "insert into user_voucher values (@matk, @makm)";
                            MySqlCommand cmd = new MySqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("matk", matk);
                    cmd.Parameters.AddWithValue("makm", makm);
                    return (cmd.ExecuteNonQuery());
                }
            }
            else { return 0; }
        }

        public int Update_khuyenmai(int makm)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "update khuyenmais set sl = sl-1 where makm = @makm";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("makm", makm);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int User_Vouchers(int matk)
        {
            int count = 0;
            List<int> termsList = new List<int>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select matk from user_voucher";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        termsList.Add(Convert.ToInt32(reader["matk"]));
                    }
                    var ob = matk;
                }
            }
           
            
            for(int i = 0; i < termsList.Count; i++)
            {
                if (termsList[i] == matk)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        public void updategiohang(string matk, string masach, string soluong)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update cart set soluong=@soluong where matk=@matk and masach=@masach";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("matk", matk);
                cmd.Parameters.AddWithValue("masach", masach);
                cmd.Parameters.AddWithValue("soluong", soluong);
                cmd.ExecuteNonQuery();
            }
        }

        public class sach
        {
            public string masach { get; set; }
            public string tensach { get; set; }
            public string giaban { get; set; }
            public string soluong { get; set; }
            public string tongtien { get; set; }
            public string hinhanh { get; set; }
            public string theloai { get; set; }
        }

        public class voucher
        {
            public string makm { get; set; }
            public string matk { get; set; }
            public string manhap { get; set; }
            public string phantram { get; set; }
            public string dieukien { get; set; }
            public string ngaybd { get; set; }
            public string ngaykt { get; set; }
            public string loaikm { get; set; }

        }

        public int thanhyou(string matk, string data, string tongtien, string soluong, string hinhthucthanhtoan, string tinhtrangthanhtoan, string tinhtrangdonhang, string phiship, string voucher_used)
        {
            DateTime Ngaylap = DateTime.Now;
            int madh = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "SELECT madh FROM orders ORDER BY madh DESC LIMIT 1";
                MySqlCommand mySql = new MySqlCommand(str, conn);
                using (var reader = mySql.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        madh = Convert.ToInt32(reader["madh"]);
                    }
                }


                var str1 = "insert into orders(hinhthucthanhtoan, matk, ngaylap,tinhtrangdonhang,tinhtrangthanhtoan,tongtien,tienship) " +
                    "values(@hinhthucthanhtoan,@matk, @ngaylap, @tinhtrangdonhang,@tinhtrangthanhtoan,@tongtien,@tienship)";

                MySqlCommand mySql1 = new MySqlCommand(str1, conn);

                mySql1.Parameters.AddWithValue("hinhthucthanhtoan", hinhthucthanhtoan);
                mySql1.Parameters.AddWithValue("matk", matk);
                mySql1.Parameters.AddWithValue("tinhtrangdonhang", tinhtrangdonhang);
                mySql1.Parameters.AddWithValue("tinhtrangthanhtoan", tinhtrangthanhtoan);
                mySql1.Parameters.AddWithValue("tongtien", tongtien);
                mySql1.Parameters.AddWithValue("tienship", phiship);
                mySql1.Parameters.AddWithValue("ngaylap", Ngaylap);
                mySql1.Parameters.AddWithValue("makm", voucher_used);
                mySql1.ExecuteNonQuery();



                var str2 = "insert into detail_order values(@madh,@masach,@soluong)";
                var str_anhhungtraidat = "update booklist set soluongban=soluongban+@soluongmua where masach=@masach";
                var list_sach = JsonSerializer.Deserialize<sach[]>(data);
                foreach(var item in list_sach)
                {
                    MySqlCommand mySql2 = new MySqlCommand(str2, conn);
                    mySql2.Parameters.AddWithValue("madh", madh + 1);
                    mySql2.Parameters.AddWithValue("masach", item.masach);
                    mySql2.Parameters.AddWithValue("soluong", item.soluong);
                    mySql2.ExecuteNonQuery();

                    MySqlCommand mySql3 = new MySqlCommand(str_anhhungtraidat, conn);
                    mySql3.Parameters.AddWithValue("soluongmua", item.soluong);
                    mySql3.Parameters.AddWithValue("masach", item.masach);
                    mySql3.ExecuteNonQuery();
                }

                /*var list_voucher_used = JsonSerializer.Deserialize<voucher[]>(listvoucher);
                var str3 = "delete from user_voucher where matk=@matk and makm=@makm";
                foreach (var item in list_voucher_used)
                {
                    MySqlCommand mySql3 = new MySqlCommand(str3, conn);
                    mySql3.Parameters.AddWithValue("matk", matk);
                    mySql3.Parameters.AddWithValue("makm", item.makm);
                }*/


                conn.Close();

            }
            return madh + 1;
        }

        public List<object> get_voucher(string matk)
        {
            List<object> list = new List<object>();
            using (MySqlConnection conn = GetConnection())
            {
                var str = "select user_voucher.matk as matk, user_voucher.makm as makm ,manhap ,phantram ,dieukien ,ngaybd ,ngaykt, loai from user_voucher,khuyenmais where khuyenmais.makm=user_voucher.makm and user_voucher.matk=@matk";
                MySqlCommand mySql = new MySqlCommand(str, conn);
                mySql.Parameters.AddWithValue("matk", matk);
                conn.Open();
                using (var reader = mySql.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new 
                        { 
                            Matk= reader["matk"].ToString(),
                            Makm = reader["makm"].ToString(),
                            MaNhap = reader["manhap"].ToString(),
                            PhanTram = reader["phantram"].ToString(),
                            DieuKien = reader["dieukien"].ToString(),
                            NgayBD = Convert.ToDateTime(reader["ngaybd"]).ToString("MM/dd/yyyy"),
                            NgayKT = Convert.ToDateTime(reader["ngaykt"]).ToString("MM/dd/yyyy"),
                            Loai = reader["loai"].ToString()
                        });
                    }
                }
            }
            return list;
        }
        
        public void deletevoucher(string matk,string data)
        {
            int Matk = Convert.ToInt32(matk);
            var list_voucher_used = JsonSerializer.Deserialize<voucher[]>(data);
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str3 = "delete from user_voucher where matk=@matk and makm=@makm";
                foreach (var item in list_voucher_used)
                {
                    int Makm = Convert.ToInt32(item.makm);
                    MySqlCommand mySql3 = new MySqlCommand(str3, conn);
                    mySql3.Parameters.AddWithValue("matk", Matk);
                    mySql3.Parameters.AddWithValue("makm", Makm);
                    mySql3.ExecuteNonQuery();
                }
            }
        }

        public void xoagiohang(string matk,string masach)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str3 = "delete from cart where matk=@matk and masach=@masach";
                MySqlCommand sql_com = new MySqlCommand(str3, conn);
                sql_com.Parameters.AddWithValue("matk", matk);
                sql_com.Parameters.AddWithValue("masach", masach);
                sql_com.ExecuteNonQuery();

                var str4 = "update client_accounts set sl_giohang=sl_giohang-1 where matk=@matk";
                MySqlCommand mySql = new MySqlCommand(str4, conn);
                mySql.Parameters.AddWithValue("matk", matk);
                mySql.ExecuteNonQuery();


            }
        }


        public void themvaogiohang(string matk, string masach, string soluong)
        {
            int Matk = Convert.ToInt32(matk);
            int Masach = Convert.ToInt32(masach);
            int Soluong = Convert.ToInt32(soluong);
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into cart values(@matk,@masach,@soluong)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("matk", Matk);
                cmd.Parameters.AddWithValue("masach", Masach);
                cmd.Parameters.AddWithValue("soluong", Soluong);
                cmd.ExecuteNonQuery();
                str = "update client_accounts set sl_giohang=sl_giohang+1 where matk=@matk";
                MySqlCommand cmd2 = new MySqlCommand(str, conn);
                cmd2.Parameters.AddWithValue("matk", Matk);
                cmd2.ExecuteNonQuery();
                conn.Close();
            }
        }

        public client_accounts CheckLoginFacebook(string id, string first_name, string last_name, string email, string gender)
        {
            client_accounts client_Accounts = new client_accounts();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str2 = "select * from client_accounts where tentk=@username";
                MySqlCommand cmd2 = new MySqlCommand(str2, conn);
                cmd2.Parameters.AddWithValue("username", id);
                int dem = 0;
                using (var res = cmd2.ExecuteReader())
                {

                    while (res.Read())
                    {
                        dem++;
                    }
                }


                if (dem == 0)
                {
                    var cmm = "insert into client_accounts(hoten,tentk,matkhau,email,gioitinh,diem,tinhtrang,ngaysinh,ngaytao,sl_giohang) " +
                        "values(@hoten,@tentk,@matkhau,@email,@gioitinh,@diem,@tinhtrang,@ngaysinh,@ngaytao,@sl_giohang)";
                    MySqlCommand Cmm = new MySqlCommand(cmm, conn);
                    Cmm.Parameters.AddWithValue("hoten", first_name + " " + last_name);
                    Cmm.Parameters.AddWithValue("matkhau", "asdialhdashdawuqihydiuashiu23y94y2837yh893yr98hyefyu832yr9f8ywhe98f");
                    Cmm.Parameters.AddWithValue("tentk", id);
                    Cmm.Parameters.AddWithValue("email", email);
                    Cmm.Parameters.AddWithValue("gioitinh", gender);
                    Cmm.Parameters.AddWithValue("diem", "0");
                    Cmm.Parameters.AddWithValue("tinhtrang", "Đang sử dụng");
                    Cmm.Parameters.AddWithValue("ngaysinh", "0000-00-00");
                    Cmm.Parameters.AddWithValue("ngaytao", "0000-00-00");
                    Cmm.Parameters.AddWithValue("sl_giohang", "0000-00-00");
                    Cmm.ExecuteNonQuery();
                }

                var str = "select * from client_accounts where tentk=@username and matkhau=@password";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("username", id);
                cmd.Parameters.AddWithValue("password", "asdialhdashdawuqihydiuashiu23y94y2837yh893yr98hyefyu832yr9f8ywhe98f");
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

            }
            Console.WriteLine(client_Accounts);
            return client_Accounts;
        }
    }
}
