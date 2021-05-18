using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void EmptyBorad()
        {
            int boardSize = 10;
            char[] board = new char[boardSize];
            for (int i = 1; i < boardSize; i++)
            {
                board[i] = ' ';
            }
        }

        static void ChooseLetter()
        {
            
            while (true)
            {
                Console.WriteLine("Choose the latter X or O");
                String userLetter = Console.ReadLine();
                if (userLetter.Equals("X") || userLetter.Equals("x"))
                {
                    String computerLatter = "O";
                    break;
                }
                else if (userLetter.Equals("O") || userLetter.Equals("o"))
                {
                    String computerLatter = "X";
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Letter");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game");
            EmptyBorad();
            ChooseLetter();
        }
    }
}

