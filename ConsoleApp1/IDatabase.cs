using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IDatabase
    {
        void Insert();

        void Display();

        void GenerateDataColumns();

    }
}
