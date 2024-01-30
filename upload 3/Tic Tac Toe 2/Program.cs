using System.Drawing;
using System.Globalization;

namespace Tic_Tac_Toe_2
{
    internal class Program
    {
        static char[] field = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static string[] stringField = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static void Main(string[] args)
        {
            string menuInput;
            string playerSymbol;
            string computerSymbol;

            
            Console.WriteLine("Tic Tac Toe 2 \n");
            Console.WriteLine("Choose[S]ymbol");
            Console.WriteLine("[C]lose");

            
            while (true)
            {
                menuInput = SingleKey();
                if (menuInput == "s" || menuInput == "c")
                {
                    break;
                }
            }
            switch(menuInput)
            {
                case "s":
                    ColorMenu(menuInput);
                    break;
                case "c":
                    ColorMenu(menuInput);
                    Environment.Exit(0);
                    break;

            }

            
            Console.WriteLine("[X]");
            Console.WriteLine("[O]");

            while (true)
            {
                playerSymbol = SingleKey();
                if (playerSymbol == "x" || playerSymbol == "o")
                {
                    break;
                }
            }
            ColorMenu(playerSymbol);
            computerSymbol = InvertSymbol(playerSymbol);


            DisplayBoard();
            while (true)
            {
                PlayerTurn(playerSymbol);
                ComputerTurn(computerSymbol);

                char tempSymbol = playerSymbol.ToCharArray()[0];
                if (field[0] == tempSymbol && field[1] == tempSymbol && field[2] == tempSymbol)
                {
                    Console.WriteLine("win for " + playerSymbol);
                    break;
                }

            }

        }
        static string SingleKey()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            char key = keyInfo.KeyChar;
            string keyInString = key.ToString();
            return keyInString;
        }

        static void ColorMenu(string menuInput)
        {
            int currentLineCursor = Console.CursorTop;
            string symbolText = "Choose[S]ymbol";
            string closeText = "[C]lose";
            string xText = "[X]";
            string oText = "[O]";
            int menuPos;
            switch (menuInput)
            {
                case "s":
                    menuPos = 2;
                    Flashing(symbolText, menuPos);
                    break;
                case "c":
                    menuPos = 3;
                    Flashing(closeText, menuPos);
                    break;
                case "x":
                    menuPos = 5;
                    Flashing(xText, menuPos);
                    break;
                case "o":
                    menuPos = 6;
                    Flashing(oText, menuPos);
                    break;
            }
            Console.SetCursorPosition(0, currentLineCursor + 1);
        }

        static void Flashing(string menuText, int menuPos)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.SetCursorPosition(0, menuPos);
                ToInvertedColor();
                Console.Write(menuText);
                Thread.Sleep(70);
                Console.SetCursorPosition(0, menuPos);
                ToDefaultColor();
                Console.Write(menuText);
                Thread.Sleep(50);
            }
            Console.SetCursorPosition(0, menuPos);
            ToInvertedColor();
            Console.Write(menuText);
            ToDefaultColor();
        }
        static void ToDefaultColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void ToInvertedColor()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        static string InvertSymbol(string userSymbol)
        {
            string InvertedSymbol;
            if (userSymbol == "x")
            {
                InvertedSymbol = "o";
            }
            else
            {
                InvertedSymbol = "x";
            }
            return InvertedSymbol;
        }
        static void DisplayBoard()
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
        static void ComputerTurn(string computerSymbol)
        {
            Random rnd = new Random();
            bool IsValidFieldInput = false;

            do
            {
                int randomNumber = rnd.Next(1, 10);
                string randomInText = randomNumber.ToString();
                char randomInChar = randomInText[0];
                for (int i = 0; i < field.Length; i++)
                {
                    if (field[i] == randomInChar)
                    {
                        field[i] = Convert.ToChar(computerSymbol);
                        IsValidFieldInput = true;
                        break;
                    }
                }
            }
            while (IsValidFieldInput == false);
            DisplayBoard();
        }
        static void PlayerTurn(string Symbol)
        {
            char fieldNumber;
            bool IsValidFieldInput = false;
            do
            {
                Console.Write("Number: ");
                fieldNumber = Convert.ToChar(SingleKey());
                if (fieldNumber == 'x' || fieldNumber == 'o')
                {
                    Console.WriteLine("Please enter a valid field number");
                }
                else
                {
                    for (int i = 0; i < field.Length; i++)
                    {
                        if (field[i] == fieldNumber)
                        {
                            field[i] = Convert.ToChar(Symbol);
                            IsValidFieldInput = true;
                            break;
                        }
                    }
                }
                DisplayBoard();
                if (IsValidFieldInput == false)
                {
                    Console.WriteLine("Please enter a valid field number");
                }
            }
            while (IsValidFieldInput == false);
            IsValidFieldInput = false;
            DisplayBoard();
        }

    }
}