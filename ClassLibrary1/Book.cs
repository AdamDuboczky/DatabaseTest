using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Book : DataEntry
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price {
            get
            {
                return _price;
            }
            set
            {
                _price = Math.Round(value, 2);
            }
        }
        private double _price;
        public int Quantity { get; set; }

        public Book(string title, string author, double price, int quantity)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
            this.Quantity = quantity;
        }


        public override List<string> GenerateColumnNames()
        {
            List<string> dataColumns = new List<string>();

            dataColumns.Add("Title");
            dataColumns.Add("Author");
            dataColumns.Add("Price");
            dataColumns.Add("Quantity");


            return dataColumns;
        }
    }
}
