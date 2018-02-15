using System;
using System.Threading;
using System.Collections.Generic;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            try
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(@"Please,  type the number:
                    1.  f(a,b) = |a-b| (unary)
                    2.  f(a) = a (binary)
                    3.  music
                    4.  morse sos
          
                    ");
                    try
                    {
                        a = (int)uint.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 1:
                                My_strings();
                                Console.WriteLine("");
                                break;
                            case 2:
                                My_Binary();
                                Console.WriteLine("");
                                break;
                            case 3:
                                My_music();
                                Console.WriteLine("");
                                break;
                            case 4:
                                Morse_code();
                                Console.WriteLine("");
                                break;
                            default:
                                Console.WriteLine("Exit");
                                break;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error" + e.Message);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #region ToFromBinary

        static void My_Binary()
        {
            //Implement positive integer variable input
            Console.WriteLine("Please input positive integer variable");
            int x= int.Parse(Console.ReadLine());

            //Present it like binary string
            //   For example, 4 as 100

            //функция конвертирования числа с десятичного представления в бинарное
            string bin = Convert.ToString(x, 2);
            Console.WriteLine(bin);

            //Use modulus operator to obtain the remainder  (n % 2) 
            //and divide variable by 2 in the loop
            Console.WriteLine(Convert.ToDouble(x) % 2); 

            //Use the ToCharArray() method to transform string to chararray
            //and Array.Reverse() method
            char[] ch=bin.ToCharArray();
            Array.Reverse(ch);
            Console.WriteLine(ch);
        }

        #endregion

        #region ToFromUnary
        static void My_strings()
        {
            //Declare int and string variables for decimal and binary presentations
            int first, second;
            string str, firstBinary, secondBinary;

            //Implement two positive integer variables input
            Console.WriteLine("Input two numbers:");
            first=int.Parse(Console.ReadLine());
            second = int.Parse(Console.ReadLine());

            //To present each of them in the form of unary string use for loop
            firstBinary = Convert.ToString(first, 2);
            secondBinary = Convert.ToString(second,2);

            //Use concatenation of these two strings 
            //Note it is necessary to use some symbol ( for example “#”) to separate
            str = firstBinary + '#' + secondBinary;
            Console.WriteLine(str);

            //Check the numbers on the equality 0
            if (first != 0) 
            {
                if (second != 0)
                {
                    Console.WriteLine($"{first} and {second} not equle 0");
                }
                else
                {
                    Console.WriteLine($"{first} not equale 0 but {second} is equale 0");
                }  
            }
            else if (second != 0)
            {
                Console.WriteLine($"{first} equle 0 but {second} not equle 0");
            }
            else
            {
                Console.WriteLine($"{first} and {second} equle 0");
            }

            //Realize the  algorithm for replacing '1#1' to '#' by using the for loop 
            char[] strToChar = str.ToCharArray();
            for(int i = 1; i < strToChar.Length-1; i++)
            {
                if (strToChar[i] == '#' && strToChar[i-1]=='1' && strToChar[i+1]=='1')
                {
                    strToChar[i - 1] = strToChar[i];
                    for (int j = i; j < strToChar.Length-2; j++)
                    {
                        strToChar[j] = strToChar[j + 2];
                    }

                }
            }
            Console.WriteLine(strToChar);

            //Delete the '#' from algorithm result
            for (int i = 0; i < strToChar.Length - 1; i++)
            {
                if (strToChar[i] == '#')
                {
                    for (int j = i; j < strToChar.Length - 1; j++)
                    {
                        strToChar[j] = strToChar[j + 1];
                    }
                }
            }
            //Output the result 
            Console.WriteLine(strToChar);
        }
        #endregion

        #region My_music
        static void My_music()
        {
            //HappyBirthday
            Thread.Sleep(2000);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(330, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(2642, 500);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 250);
            Thread.Sleep(125);
            Console.Beep(352, 125);
            Thread.Sleep(125);
            Console.Beep(330, 500);
            Thread.Sleep(125);
            Console.Beep(297, 1000);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
        }
        #endregion

        #region Morse
        static void Morse_code()
        {
            //Create string variable for 'sos'      
            string sos;
            //Use string array for Morse code
            string[,] Dictionary_arr = new string[,] { { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" },
            { ".-   ", "-... ", "-.-. ", "-..  ", ".    ", "..-. ", "--.  ", ".... ", "..   ", ".--- ", "-.-  ", ".-.. ", "--   ", "-.   ", "---  ", ".--. ", "--.- ", ".-.  ", "...  ", "-    ", "..-  ", "...- ", ".--  ", "-..- ", "-.-- ", "--.. ", "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----." }};
            //Use ToCharArray() method for string to copy charecters to Unicode character array
            //Use foreach loop for character array in which
            Console.WriteLine("Please input your message:");
            sos = Console.ReadLine();
            //перевод в нижний регистр
            sos = sos.ToLower();

            //конвертация строки в массив символов
            char[] sos_temp= sos.ToCharArray();

            //массив для '.' '-'-го представления сообщения
            string sos_temp2 ="";

            //Implement Console.Beep(1000, 250) for '.'
            // and Console.Beep(1000, 750) for '-'
            //Use Thread.Sleep(50) to separate sounds

            //цикл перевода сообщения в набор '.', '-' и пробелов
            //перебираем наше сообщение
            foreach (char element in sos_temp)
            {
                //перебираем наш словарь Dictionary_arr
                for (int i=0;i<36;i++)
                {
                    //сравниваем текущий символ сообщения с текущей буквой словаря
                    if (Convert.ToChar(Dictionary_arr.GetValue(0, i))==element)
                    {
                        //если совпали записиваем '.' '-'-ое представление даного символа в строку сообщения
                        sos_temp2 += Dictionary_arr.GetValue(1, i);
                        break;
                    }
                }
                
            }
            Console.WriteLine(sos_temp2);

            //конвертация строки в массив символов
            char[] sos_temp3=sos_temp2.ToCharArray();

            //перебираем массив .' '-'-го представления сообщения
            foreach (char element in sos_temp3)
            {
                //воспроизводим соответсвующий звук для соответсвующего символа
                if (element == '.')
                {
                    Console.Beep(1000, 250);
                }
                else if (element == '-')
                {
                    Console.Beep(1000, 750);
                }
                Thread.Sleep(50);
            }
         
        }

        #endregion
    }
}
