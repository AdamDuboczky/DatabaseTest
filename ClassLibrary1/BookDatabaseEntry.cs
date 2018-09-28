using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class BookDatabaseEntry : IDatabase
    {
        public void Insert(Book entry)
        {

        }

        public void Display(Book entry)
        {

        }

        public ICollection<Book> Get()
        {
            return IList<Book>;
        }


    }

    internal interface IDatabase
    {
    }
}
