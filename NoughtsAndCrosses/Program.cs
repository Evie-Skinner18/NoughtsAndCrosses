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
            // want the validator to return an int like this  return (BoardState)boardStateIndex;
            var validator = new Validator(args[i]);
            var message = validator.ValidateUserInput();


            if (boardChecker.IsADraw())
            {
                return BoardState.DRAW;
            }          
            else
            {

                var boardStateIndex = boardChecker.CheckForAWinner();
                return (BoardState)boardStateIndex;
            }
        }


        static void Main(string[] args)
        {
            var arguments = args.ToList<string>();
            arguments.RemoveAt(0);
            args = arguments.ToArray();

            

            for (int i = 0; i < args.Length; i++)
            {   
               Console.WriteLine(GetStateOfBoard(args[i]));                
            }
        }

    }
}
