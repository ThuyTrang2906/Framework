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
                string str = "select * from booklist";
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
                            Giagoc = reader["giagoc"].ToString(),
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
                    bo.Giagoc  = reader["giagoc"].ToString();
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
                            Giagoc = reader["giagoc"].ToString(),
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
                var str = "insert into client_accounts values(@danhsach_km, @diachigh, @diachigoc, @diem, @email, @giohang, @gioitinh, @hoten, @matk, @matkhau, @ngaysinh, @ngaytao, @sl_giohang, @sodt, @tinhtrang)";
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
                cmd.Parameters.AddWithValue("ngaytao", "null");
                cmd.Parameters.AddWithValue("sl_giohang",0);
                cmd.Parameters.AddWithValue("sodt", "null");
                cmd.Parameters.AddWithValue("tinhtrang", "Đang sử dụng");
                


                return (cmd.ExecuteNonQuery());

            }
        }
    }
}
