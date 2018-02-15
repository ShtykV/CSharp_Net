using System;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Box p1 = new Box();
                Console.WriteLine("Type  position of the box, x = ");
                p1.x_pos = uint.Parse(Console.ReadLine());
                Console.WriteLine("Type  position of the box: y = ");
                p1.y_pos = uint.Parse(Console.ReadLine());
                Console.WriteLine("Type  width of the box: width = ");
                p1.width_pos = uint.Parse(Console.ReadLine());
                Console.WriteLine("Type  height of the box: height = ");
                p1.height_pos = uint.Parse(Console.ReadLine());
                Console.WriteLine("Type one of chars : *, +, .  ");
                p1.symb_dr = char.Parse(Console.ReadLine());
                Console.WriteLine("Type  the message :  ");
                p1.mess = Console.ReadLine();

                Console.WriteLine("Drawing ...");
                p1.Draw();
                Console.WriteLine();
                Console.WriteLine(p1.mess);
                Console.WriteLine("Press any key...");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }

        }
    }
}
