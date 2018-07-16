using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomListClass;

namespace CustomListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomListClass<int> customListClass1 = new CustomListClass<int>();
            foreach (int value in customListClass1)
            {
                Console.WriteLine(value);
            }
            customListClass1.Add(1);
            customListClass1.Add(3);
            customListClass1.Add(5);
           
        }
    }
}
