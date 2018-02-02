using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factirial calculation
            ");

            a = long.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        #region farmer
        static void Farmer_puzzle()
        {
            //Key sequence: 3 8 1 7 2 8 3 or 
            //              3 8 2 7 1 8 3
            // Declare 7 int variables for the input numbers and other variables
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"From one bank to another should carry a wolf, goat and cabbage. 
At the same time can neither carry nor leave together on the banks of a wolf and a goat, 
a goat and cabbage. You can only carry a wolf with cabbage or as each passenger separately. 
You can do whatever how many flights. How to transport the wolf, goat and cabbage that all went well?");
            Console.WriteLine("There: farmer and wolf - 1");
            Console.WriteLine("There: farmer and cabbage - 2");
            Console.WriteLine("There: farmer and goat - 3");
            Console.WriteLine("There: farmer  - 4");
            Console.WriteLine("Back: farmer and wolf - 5");
            Console.WriteLine("Back: farmer and cabbage - 6");
            Console.WriteLine("Back: farmer and goat - 7");
            Console.WriteLine("Back: farmer  - 8");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Please,  type numbers by step ");
            // Implement input and checking of the 7 numbers in the nested if-else blocks with the  Console.ForegroundColor changing
            if (Convert.ToInt32(Console.ReadLine()) == 3)
            {
                if (Convert.ToInt32(Console.ReadLine()) == 8)
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    if (a == 1)
                    {
                        if (Convert.ToInt32(Console.ReadLine()) == 7)
                        {
                            if (Convert.ToInt32(Console.ReadLine()) == 2)
                            {
                                if (Convert.ToInt32(Console.ReadLine()) == 8)
                                {
                                    if (Convert.ToInt32(Console.ReadLine()) == 3)
                                    {
                                        Console.WriteLine("Succes!!!");
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Fail!!!");
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Fail!!!");
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Fail!!!");
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Fail!!!");
                        }
                    }
                    else if (a == 2)
                    {
                        if (Convert.ToInt32(Console.ReadLine()) == 7)
                        {
                            if (Convert.ToInt32(Console.ReadLine()) == 1)
                            {
                                if (Convert.ToInt32(Console.ReadLine()) == 8)
                                {
                                    if (Convert.ToInt32(Console.ReadLine()) == 3)
                                    {
                                        Console.WriteLine("Succes!!!");
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Fail!!!");
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Fail!!!");
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Fail!!!");
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fail!!!");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fail!!!");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fail!!!");
            }

        }
        #endregion

        #region calculator
        static void Calculator()
        {
            // Set Console.ForegroundColor  value
            Console.WriteLine(@"Select the arithmetic operation:
                                1. Multiplication 
                                2. Divide 
                                3. Addition 
                                4. Subtraction
                                5. Exponentiation ");
            // Implement option input (1,2,3,4,5)
            //     and input of  two or one numbers
            //  Perform calculations and output the result 
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Input first number");
            double d1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input second number");
            double d2 = double.Parse(Console.ReadLine());
            switch (m)
            {
                case 1:
                    Console.WriteLine("Result: "+(d1*d2));
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("Result: " + (d1 / d2));
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("Result: " + (d1 + d2));
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("Result: " + (d1 - d2));
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("Result: " + Math.Exp(d1 * d2));
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }

        }
        #endregion

        #region Factorial
        static void Factorial_calculation()
        {
            // Implement input of the number
            // Implement input the for circle to calculate factorial of the number
            // Output the result
            Console.WriteLine("Input number");
            int a = int.Parse(Console.ReadLine());
            int b = 1;
            for (int i = 1; i<=a; i++)
            {
                b *= i;
            }
            Console.WriteLine("Result: "+ b);
        }
        #endregion
    }
}
