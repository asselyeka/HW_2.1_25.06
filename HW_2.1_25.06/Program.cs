using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.	Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.

namespace HW_2._1_25._06
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 1;
            var y = 4;
            var z = 5;
            Console.Write(x);
            Console.Write("  ");
            Console.Write(y);
            Console.Write("  ");
            Console.Write(z);
            Console.ReadKey();
        }
    }
}
