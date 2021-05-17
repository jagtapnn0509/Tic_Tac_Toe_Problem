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
            static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game");
            EmptyBorad();
        }
    }
}
