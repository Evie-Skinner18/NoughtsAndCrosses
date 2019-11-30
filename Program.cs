using System;

namespace NoughtsAndCrosses
{
    class Program
    {
        private enum boardState
        {
            NOUGHTS_WIN, CROSSES_WIN, DRAW, NOBODY_HAS_WON_YET
        }

        private static BoardState GetStateOfBoard(string board)
        {
            //switch(board)
            //{
            //    case board
            //}

            // if it contains XXX then crosses have won
            // if it contains OOO then Os have won
            // anything else means nobody has won yet
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
