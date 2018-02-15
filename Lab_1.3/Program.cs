using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MyMax = 200;

            Random random = new Random();
            // random.Next(MaxValue) returns a 32-bit signed integer that is greater than or equal to 0 and less than MaxValue
            int Guess_number = random.Next(MyMax) + 1;
            // implement input of number and comparison result message in the while circle with  comparison condition
            Console.WriteLine("Input number");
            int a = int.Parse(Console.ReadLine());
            while (a > Guess_number)
            {
                Guess_number = random.Next(MyMax) + 1;
                Console.WriteLine(Guess_number);
                Console.WriteLine("Again)");
            }
            Console.ReadLine();
        }
    }
}
