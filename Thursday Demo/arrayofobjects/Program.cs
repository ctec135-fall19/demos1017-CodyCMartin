using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayofobjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            double v = 456.789;
            string s = "somestring";
            MyClass mc = new MyClass();

            Object[] myArray = new object[4];
            myArray[0] = 1;
            myArray[1] = "d";
            myArray[2] = 5;
            myArray[3] = mc;

            //example of polymorphic
            foreach(object o in myArray)
            {
                Console.WriteLine(o.GetType());
                Console.WriteLine(o.ToString());
                Console.WriteLine();

            }
            

        }
    }
}
