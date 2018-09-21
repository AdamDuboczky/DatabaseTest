using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DatabaseTest
    {
        static void Main(string[] args)
        {
            var a = new Database("root","changeme","ebookshop");

            a.Display();

            Console.ReadLine();




        }
    }
}
