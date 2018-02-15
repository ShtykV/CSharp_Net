using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1) declare variables of all simple types:
            bool, char, byte, sbyte, short, ushort, int, uint, long, ulong, decimal, float, double
            their names should be:
            boo, ch, b, sb, sh, ush, i, ui, l, ul, de, fl, d0
            initialize them with 1, 100, 250.7, 150, 10000, -25, -223, 300, 100000.6, 8, -33.1
            Check results(types and values). Is possible to do initialization?
            Fix compilation errors(change values for impossible initialization)*/

            bool boo = true;
            char ch = 'v';
            byte b = 255;
            sbyte sb = -128;
            short sh = 10000;
            ushort ush = 0;
            int i = -233;
            uint ui = 300;
            long l = 100000;
            ulong ul = 8;
            decimal de = -33m;
            float fl = 2000000000000f;
            double d0 = 0.000012d;


            //2) declare constants of int and double. Try to change their values.

            const int ci = 1024;
            const double cd = 64.0;

            //ci = 345;
            //cd = 1.006;

            //----------------------------------------------------------------------------

            //3) declare 2 variables with var. Initialize them 20 and 20.5. Check types. 
            // Try to reinitialize by 20.5 and 20 (change values). What results are there?

            var v1 = 20;
            var v2 = 20.5;

            Console.WriteLine ("Type of v1: " + v1.GetType() +'\n'+" Type of v2: " + v2.GetType());

            //v1 = 20.5;
            //v2 = 20;

            //----------------------------------------------------------------------------

            // 4) declare variables of System.Int32 and System.Double.
            // Initialize them by values of i and d0. Is it possible?

            System.Int32 si;
            System.Double sd;

            si = i;
            sd = d0;

            //----------------------------------------------------------------------------
            if (true)
            {
                // 5) declare variables of int, char, double 
                // with names i, ch, do
                // is it possible?

                //int i;
                //char ch;
                //double do;

                //----------------------------------------------------------------------------

                // 6) change values of variables from 1)

                boo = false;
                ch = 's';
                b = 0;
                sb = 127;
                sh = 1080;
                ush = 512;
                i = 33;
                ui = 301;
                l = -10010;
                ul = 5;
                de = 33m;
                fl = -2000000000000f;
                d0 = -0.000014d;
            }

            //----------------------------------------------------------------------------
            int a = 10;
            int ba = ++a + a++;
            Console.WriteLine(ba);
            // 7)check values of variables from 1). Are they changed? Think, why

            //----------------------------------------------------------------------------

            // 8) use implicit/ explicit conversion to convert variables from 1). 
            // Is it possible? 

            // Fix compilation errors (in case of impossible conversion commemt that line).
            // int -> char

            // bool -> short
        
            // double -> long

            // float -> char 

            // int to char

            // decimal -> double

            // byte -> uint

            // ulong -> sbyte

            char f=(char)i;
            //short ns=(short)boo;
            long nl = (long)d0;
            char nc = (char)fl;
            char ncg = Convert.ToChar(i);
            double d1 = (double)de;
            uint nui = b;
            sbyte nsb = (sbyte)ul;

            //----------------------------------------------------------------------------

            // 9) and reverse conversion with fixing compilation errors.

            i = f;
            short ns = new short();
            //boo = ns;
            d0 = nl;
            fl = nc;
            i = ncg;
            de = (decimal)d1;
            b = (byte)nui;
            ul = (ulong)nsb;

            //----------------------------------------------------------------------------

            // 10) declare int nullable value.Initialize it with 'null'.
            // Try to initialize variable i with 'null'. Is it possible?

            int? ni = null;

            Console.ReadLine();


        }
    }
}
