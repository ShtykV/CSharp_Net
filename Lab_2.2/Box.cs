using System;

namespace Lab_8
{
    class Box
    {
        public uint x_pos { get; set; }
        public uint y_pos { get; set; }
        public uint width_pos { get; set; }
        public uint height_pos { get; set; }
        public string mess { get; set; }
        public char symb_dr { get; set; }

        public void Draw()
        {
            if (mess == null) mess = "";
            if (((symb_dr.Equals('*')) | (symb_dr.Equals('+')) | (symb_dr.Equals('.'))) == false) symb_dr = '*';
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            string mess_loc = mess;
            if ((width_pos > 0) | (height_pos > 0))
            {
                int new_index = mess_loc.Length;
                new_index = (int)Math.Min(width_pos - 2, new_index);
                if ((width_pos >= 3) | (height_pos >= 3))
                {
                    mess_loc = mess_loc.Substring(0, Math.Max(0, new_index));
                }
                else mess_loc = "";

                this.draw((int)x_pos, (int)y_pos, (int)width_pos, (int)height_pos, symb_dr, ref mess_loc);
                this.mess = mess_loc;

            }
            else
            {
                this.mess = "One point";
                Console.SetCursorPosition((int)x_pos, (int)y_pos);
                Console.Write(symb_dr);
            };
            Console.ResetColor();
        }

        private void draw(int X, int Y, int Width, int Height, char Symb, ref string Message)
        {
            if ((Width >= 3) | (Height >= 3))
            {
                Console.SetCursorPosition(X + (Width - Message.Length) / 2, Y + Height / 2);
                Console.Write(Message);
            }
            Console.SetCursorPosition(X, Y); // First position

            for (int ii = 0; ii <= Height - 1; ii++)
            {
                for (int jj = 0; jj <= Width - 1; jj++)
                {

                    if (ii % (Height - 1) == 0 || jj % (Width - 1) == 0)
                    {
                        Console.SetCursorPosition(X + jj, Y + ii);
                        Console.Write(Symb);
                    }
                }
                Message = "Ok! square = " + Height * Width;
            }



        }
    }
}
