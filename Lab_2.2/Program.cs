using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define parameters to calculate the factorial of
            Console.WriteLine("Please input number");
            int f1 = int.Parse(Console.ReadLine());
            //Call fact() method to calculate
            Console.WriteLine("Result: " + fact(f1, 1));
            Console.ReadLine();
        }

        //Create fact() method  with parameter to calculate factorial
        //Use ternary operator
        public static int fact(int f2, int i)
        {
            return i *= i < f2 ? fact(f2, ++i) : 1;
        }

    }
}
