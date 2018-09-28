using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Database
    {
        string MySqlBaseConnectionStringBuilder;

        public Database(string username, string password, string databaseName)
        {
             MySqlBaseConnectionStringBuilder = "server=192.168.0.15;" +
                                                    "uid=" + username + ";" +
                                                    "pwd=" + password + ";" +
                                                    "database=" + databaseName + ";"    ;       
        }

        public bool Insert(Book book)
        {
            try
            {
                var connection = new MySqlConnection();
                connection.ConnectionString = MySqlBaseConnectionStringBuilder;
                connection.Open();

                string Query = "INSERT INTO books(title,author,price,qty) VALUES ('" + book.Title + "','" + book.Author + "'," + book.Price + "," + book.Quantity + ");";
                MySqlCommand a = new MySqlCommand(Query, connection);
                a.ExecuteReader();
                connection.Close();

            }
            catch (MySqlException ex)
            {
                Debug.Write(ex.Message);
            }



            return true;

        }

        public List<Book> Display()
        {
            try
            {
                var connection = new MySqlConnection();
                connection.ConnectionString = MySqlBaseConnectionStringBuilder;
                connection.Open();

                string Query = "select * from books;";
                MySqlCommand a = new MySqlCommand(Query, connection);

                var reader = a.ExecuteReader();

                var bookList = new List<Book>();
                while(reader.Read())
                {
                    //Console.WriteLine(reader.GetInt32(0) + ", " + reader.GetString(1) + ", " +  reader.GetString(2) + ", " + reader.GetString(3) + ", " + reader.GetString(4));
                    bookList.Add(new Book(reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetInt32(4)));
                }
                reader.Close();
                connection.Close();

                return bookList;

            }
            catch (MySqlException ex)
            {
                Debug.Write(ex.Message);
            }

            return null;

        }

    }
}
