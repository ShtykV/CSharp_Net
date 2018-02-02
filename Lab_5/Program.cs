using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        // 1) declare enum ComputerType
        public enum ComputerType
        {
            Desktop, Laptop, Netbook, AllInOnesDesktop
        };

        // 2) declare struct Computer
        struct Computer
        {
            public int CPU;
            public int GPU;
            public int HDD;
            public double RAM;
            public ComputerType type;

            //конструктор
            public Computer(int CPU, int GPU, int HDD, double RAM, ComputerType type)
            {
                this.CPU = CPU;
                this.GPU = GPU;
                this.HDD = HDD;
                this.RAM = RAM;
                this.type = type;
            }
        }
        
        static void Main(string[] args)
        {
            // 3) declare jagged array of computers size 4 (4 departments)

            Computer[][] jaggedArray = new Computer[4][];

            // 4) set the size of every array in jagged array (number of computers)

            jaggedArray[0] = new Computer[2];
            jaggedArray[1] = new Computer[3];
            jaggedArray[2] = new Computer[2];
            jaggedArray[3] = new Computer[3];

            // 5) initialize array
            // Note: use loops and if-else statements

            //инициализация переменных рандома для составляющих структуры
            Random CPUrand = new Random();
            Random GPUrand = new Random();
            Random HDDrand = new Random();
            Random RAMrand = new Random();

            //заполнение массива рандомизироваными значениями
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = new Computer(CPUrand.Next(1, 4)*2, 
                                                     GPUrand.Next(1, 6), 
                                                     HDDrand.Next(1, 5) * 1000, 
                                                     Math.Pow(Convert.ToDouble(2), 
                                                     Convert.ToDouble(RAMrand.Next(1, 5))), 
                                                     (ComputerType)i);
                }
            }

            // 6) count total number of every type of computers
            //перебираю весь массив веду подсчет
            int count;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                count = 0;//счетчик
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    count++;
                }
                Console.WriteLine("Number of computer type: " + (ComputerType)i + " is " + count);
            }
            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)
            count = 0;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    count++;
                }
            }
            Console.WriteLine("Total number of all computers: "+ count);

            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements

            int largest= jaggedArray[0][0].HDD;//присваиваю статус "largest storage" 0-му компьютеру
            int[] coordinates = {0,0};//сюда записиваю координаты компьютер со статусом "largest storage"

            //перебираю по очереди все кмпьютеры
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 1; j < jaggedArray[i].Length; j++)
                {
                    //сравниваю текущий с компьютером со статусом "largest storage"
                    if (jaggedArray[i][j].HDD>largest)
                    {
                        //если текущий имеет больше HDD он принимает статус "largest storage"
                        largest = jaggedArray[i][j].HDD;
                        //записиваю новые координаты компьютер со статусом "largest storage"
                        coordinates[0] = i;
                        coordinates[1] = j;
                    }
                }
            }
            Console.WriteLine("Computer with the largest storage have position: '"+ coordinates[0] +"'; '"+coordinates[1]+ "' and storage capacity " + largest);

            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions

            //примерно тоже что и в 8
            int[] lowest = new int[2];
            lowest[0] = jaggedArray[0][0].CPU;
            lowest[1] = (int)jaggedArray[0][0].RAM;
            int[] newCoordinates = { 0, 0 };
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 1; j < jaggedArray[i].Length; j++)
                {
                    if (jaggedArray[i][j].CPU < lowest[0] & (int)jaggedArray[i][j].RAM<lowest[1])
                    {
                        lowest[0] = jaggedArray[i][j].CPU;
                        lowest[1] = (int)jaggedArray[i][j].RAM;
                        newCoordinates[0] = i;
                        newCoordinates[1] = j;
                    }
                }
            }
            Console.WriteLine("Computer with the lowest productivity have position: '" + newCoordinates[0] + "'; '" + newCoordinates[1] + "' and productivity " +"("+ jaggedArray[newCoordinates[0]][newCoordinates[1]].CPU+ " core processor to " + jaggedArray[newCoordinates[0]][newCoordinates[1]].RAM + " Gb)");

            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements

            //так как все компьютеры типа Desktop стоят в первом департаменте перебираю лишь 0-ю строку
            //и заменяю значения RAM на 8
            for (int j = 0; j < jaggedArray[0].Length; j++)
            {
                jaggedArray[0][j].RAM = 8;
            }
            
            Console.ReadLine();
        }

    }
}
