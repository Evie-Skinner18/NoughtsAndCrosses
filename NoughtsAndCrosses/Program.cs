using System;

namespace NoughtsAndCrosses
{
    class Program
    {
        private enum BoardState
        {
            NOUGHTS_WIN, CROSSES_WIN, DRAW, NOBODY_HAS_WON_YET
        }

        private static BoardState GetStateOfBoard(string userBoard)
        {
            //var boardState = new BoardState();



            //switch(board)
            //{
            //    case board
            //}

            // if it contains XXX then crosses have won
            // if it contains OOO then Os have won
            // anything else means nobody has won yet
            if (userBoard.Contains("XXX"))
            {
                return BoardState.CROSSES_WIN;
            }
            return BoardState.NOBODY_HAS_WON_YET;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(BoardState.DRAW);

           // var boardState = new BoardState();
            //boardState;

        }

    }
}
