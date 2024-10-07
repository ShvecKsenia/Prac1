using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the four number:");
            int d = Convert.ToInt32(Console.ReadLine());
            double SuM = Convert.ToDouble((a + b + c + d) / 4);
            Console.WriteLine($"The average of {a} , {b} , {c} , {d} is: " + SuM);
            Console.ReadKey(); 
        }
    }
}
