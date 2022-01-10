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

        public List<Book> GetBook()
        {
            List<Book> list = new List<Book>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from booklist limit 40";
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

        public Book ViewBook(string name)
        {
            Book bo = new Book();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from booklist where tensach=@tensach";
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

        public List<Book> DsLienQuan(string name)
        {
            List<Book> list = new List<Book>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from booklist where theloai in (select theloai from booklist where tensach = @tensach)";
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
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into client_accounts values(@danhsach_km, @diachigh, @diachigoc, @diem, @email, @giohang, @gioitinh, @hoten, @matk, @matkhau, @ngaysinh, current_timestamp(), @sl_giohang, @sodt, @tinhtrang)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("danhsach_km", "0");
                cmd.Parameters.AddWithValue("diachigh", "null");
                cmd.Parameters.AddWithValue("diachigoc", "null");
                cmd.Parameters.AddWithValue("diem", 0);
                cmd.Parameters.AddWithValue("email", kh.Email);
                cmd.Parameters.AddWithValue("giohang", "null");
                cmd.Parameters.AddWithValue("gioitinh", "null");
                cmd.Parameters.AddWithValue("hoten", "null");
                cmd.Parameters.AddWithValue("matk", kh.Matk);
                cmd.Parameters.AddWithValue("matkhau", kh.Matkhau);
                cmd.Parameters.AddWithValue("ngaysinh", "null");
                cmd.Parameters.AddWithValue("ngaytao", "current_timestamp()");
                cmd.Parameters.AddWithValue("sl_giohang", 0);
                cmd.Parameters.AddWithValue("sodt", "null");
                cmd.Parameters.AddWithValue("tinhtrang", "Đang sử dụng");

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

        public void thanhyou(string matk, string data, string tongtien, string soluong, string hinhthucthanhtoan, string tinhtrangthanhtoan, string tinhtrangdonhang)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "SELECT madh FROM orders ORDER BY madh DESC LIMIT 1";
                MySqlCommand mySql = new MySqlCommand(str, conn);
                var madh = 0;
                using (var reader = mySql.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        madh = Convert.ToInt32(reader["madh"]);
                    }
                }


                var str1 = "insert into orders(hinhthucthanhtoan,matk,tinhtrangdonhang,tinhtrangthanhtoan,tongtien) " +
                    "values(@hinhthucthanhtoan,@matk,@tinhtrangdonhang,@tinhtrangthanhtoan,@tongtien)";
                MySqlCommand mySql1 = new MySqlCommand(str1, conn);

                mySql1.Parameters.AddWithValue("hinhthucthanhtoan", hinhthucthanhtoan);
                mySql1.Parameters.AddWithValue("matk", matk);
                mySql1.Parameters.AddWithValue("tinhtrangdonhang", tinhtrangdonhang);
                mySql1.Parameters.AddWithValue("tinhtrangthanhtoan", tinhtrangthanhtoan);
                mySql1.Parameters.AddWithValue("tongtien", tongtien);

                mySql1.ExecuteNonQuery();



                var str2 = "insert into detail_order values(@madh,@masach,@soluong)";
                var list_sach = JsonSerializer.Deserialize<sach[]>(data);
                foreach(var item in list_sach)
                {
                    MySqlCommand mySql2 = new MySqlCommand(str2, conn);
                    mySql2.Parameters.AddWithValue("madh", madh + 1);
                    mySql2.Parameters.AddWithValue("masach", item.masach);
                    mySql2.Parameters.AddWithValue("soluong", item.soluong);
                    mySql2.ExecuteNonQuery();
                }

               /* var list_voucher_used = JsonSerializer.Deserialize<voucher[]>(listvoucher);
                var str3 = "delete from user_voucher where matk=@matk and makm=@makm";
                foreach(var item in list_voucher_used)
                {
                    MySqlCommand mySql3 = new MySqlCommand(str3, conn);
                    mySql3.Parameters.AddWithValue("matk", matk);
                    mySql3.Parameters.AddWithValue("makm", item.makm);
                }*/
                

                conn.Close();

            }
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
            var list_voucher_used = JsonSerializer.Deserialize<voucher[]>(data);

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str3 = "delete from user_voucher where matk=@matk and makm=@makm";
                foreach (var item in list_voucher_used)
                {
                    MySqlCommand mySql3 = new MySqlCommand(str3, conn);
                    mySql3.Parameters.AddWithValue("matk", matk);
                    mySql3.Parameters.AddWithValue("makm", item.makm);
                    mySql3.ExecuteNonQuery();
                }
            }
        }
    }
}
