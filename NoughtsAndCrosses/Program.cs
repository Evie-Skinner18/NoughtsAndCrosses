using System;
using System.Linq;
using NoughtsAndCrosses.Utilities;

namespace NoughtsAndCrosses
{
    partial class Program
    {
        
        private enum BoardState
        {
            NOUGHTS_WIN, CROSSES_WIN, DRAW, NOBODY_HAS_WON_YET, BOARD_IS_INVALID
        }


        private static BoardState GetStateOfBoard(string userBoard)
        {
            var boardChecker = new BoardChecker(userBoard);
            // first check if it's a valid board
            // want the validator to return an int 4 if oard is invalid this  return (BoardState)boardStateIndex;
            // if board is valid return 5 or something
            var validator = new Validator(userBoard);
            var message = validator.ValidateUserInput();

            // if board is valid, then we can check for draw, wins etc
            

            if (boardChecker.IsADraw())
            {
                return BoardState.DRAW;
            }          
            else
            {
                var winnerMessage = boardChecker.CheckForAWinner();
                var boardStateIndex = boardChecker.GetIndexOfWinner(winnerMessage);
                return (BoardState)boardStateIndex;
            }
        }


        static void Main(string[] args)
        {
            //var arguments = args.ToList<string>();
            //arguments.RemoveAt(0);
            //args = arguments.ToArray();

            

            for (int i = 0; i < args.Length; i++)
            {   
               Console.WriteLine(GetStateOfBoard(args[i]));                
            }
        }

    }
}
