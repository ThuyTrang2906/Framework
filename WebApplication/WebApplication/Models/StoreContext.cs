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
    }
}
