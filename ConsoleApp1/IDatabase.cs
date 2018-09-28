using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IDatabase<T>
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entry"></param>
        void Insert(T entry);

        List<DataEntry> Display(T entry);


    }
}
