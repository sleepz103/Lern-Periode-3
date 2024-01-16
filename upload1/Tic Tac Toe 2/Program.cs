using System.Drawing;

namespace Tic_Tac_Toe_2
{
    internal class Program
    {
        static char[] field = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static void Main(string[] args)
        {
            
            //Variables
            string menu;
            string Symbol;
            char coord;

            //title
            Console.WriteLine("Tic Tac Toe 2 \n");
            Console.WriteLine("Choose[S]ymbol");
            Console.WriteLine("[C]lose");

            //menu
            while (true)
            {
                menu = SingleKey();
                if (menu == "s" || menu == "c")
                {
                    break;
                }
            }
            switch(menu)
            {
                case "s":
                    ColorMenu(menu);
                    break;
                case "c":
                    ColorMenu(menu);
                    Environment.Exit(0);
                    break;

            }

            //Symbol menu
            Console.WriteLine("[X]");
            Console.WriteLine("[O]");
            while (true)
            {
                Symbol = SingleKey();
                if (Symbol == "x" || Symbol == "o")
                {
                    break;
                }
            }
            ColorMenu(Symbol);

            //Game
            Board();
            Console.Write("Number: ");
            coord = Convert.ToChar(SingleKey());
            for (int i = 0; i < field.Length; i++)
            {
                if (field[i] == coord)
                {
                    field[i] = Convert.ToChar(Symbol);
                }
            }
            Board();
            

            //check for win





        }
        static string SingleKey()
        {
            ConsoleKeyInfo a = Console.ReadKey(true);
            char b = a.KeyChar;
            string c = b.ToString();
            return c;
        }

        static void ColorMenu(string menu)
        {
            int currentLineCursor = Console.CursorTop;
            string symbol = "Choose[S]ymbol";
            string close = "[C]lose";
            string x = "[X]";
            string o = "[O]";
            int menuPos2;
            switch (menu)
            {
                case "s":

                    menuPos2 = 2;
                    Flashing(symbol, menuPos2);
                    break;
                case "c":

                    menuPos2 = 3;
                    Flashing(close, menuPos2);
                    break;
                case "x":
                    menuPos2 = 5;

                    Flashing(x, menuPos2);
                    break;
                case "o":

                    menuPos2 = 6;
                    Flashing(o, menuPos2);
                    break;
            }
            Console.SetCursorPosition(0, currentLineCursor + 1);
        }

        static void Flashing(string text, int menuPos2)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.SetCursorPosition(0, menuPos2);
                InvertedColor();
                Console.Write(text);
                Thread.Sleep(70);
                Console.SetCursorPosition(0, menuPos2);
                DefaultColor();
                Console.Write(text);
                Thread.Sleep(50);
            }
            Console.SetCursorPosition(0, menuPos2);
            InvertedColor();
            Console.Write(text);
            DefaultColor();
        }
        static void DefaultColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void InvertedColor()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        static void Board()
        {
            Console.Clear();
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", field[0], field[1], field[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", field[3], field[4], field[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", field[6], field[7], field[8]);
            Console.WriteLine("     |     |      ");
        }

    }
}