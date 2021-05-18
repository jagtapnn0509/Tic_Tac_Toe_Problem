using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void TicTacToeBorad()
        {

            int boardSize = 10;
            char[] board = new char[boardSize];
            for (int i = 1; i < boardSize; i++)
            {
                board[i] = ' ';
            }

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", board[1], board[2], board[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", board[4], board[5], board[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);

            Console.WriteLine("     |     |      ");

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
            ChooseLetter();
            TicTacToeBorad();
        }
    }
}

