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
                string str = "select * from booklist limit 40";
                MySqlCommand cmd = new MySqlCommand(str, conn);
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
                    bo.Tensach = reader["tensach"].ToString();
                    bo.Tacgia = reader["tacgia"].ToString();
                    bo.Hinhanh = reader["hinhanh"].ToString();
                    bo.Theloai = reader["theloai"].ToString();
                    bo.Giagoc  = Convert.ToInt32(reader["giagoc"]);
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
                cmd.Parameters.AddWithValue("sl_giohang",0);
                cmd.Parameters.AddWithValue("sodt", "null");
                cmd.Parameters.AddWithValue("tinhtrang", "Đang sử dụng");

                return (cmd.ExecuteNonQuery());

            }
        }

        public List<vouchers> GetVoucher()
        {
            List<vouchers> list = new List<vouchers>();
            using(MySqlConnection conn = GetConnection())
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
                    tk.Sodt = reader["sodt"].ToString();
                    tk.Diem = Convert.ToInt32(reader["diem"]);
                    tk.Sl_giohang = Convert.ToInt32(reader["sl_giohang"]);
                /*    tk.Ngaytao = Convert.ToDateTime(reader["ngaytao"]);*/
                    /*tk.Ngaysinh = Convert.ToDateTime(reader["ngaysinh"]);*/
                }
            }
            return tk;
        }

        public user_voucher User_Voucher(string tentk)
        {
            user_voucher uv = new user_voucher();
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "Select * from khuyenmais where makm in (" +
                    "select makm from user_voucher u, client_accounts c where u.matk = c.matk and c.tentk=@tentk)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("tentk", tentk);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    uv.Matk = reader["matk"].ToString();
                    uv.Makm = reader["makm"].ToString();

                }
            }
            return uv;
        }

        public List<Book> Cart(string tentk)
        {
            List<Book> list = new List<Book>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from booklist where masach in " +
                    "(select masach from cart u, client_accounts c where u.matk = c.matk and c.tentk=@tentk)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
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
                        client_Accounts.Giohang = reader["giohang"].ToString();
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
    }
}
