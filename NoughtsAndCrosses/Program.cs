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
            var validator = new Validator(userBoard);
            var validationBoardStateIndex = validator.ValidateUserInput();

            // if board is valid, then we can check for draw, wins etc
            if (validationBoardStateIndex.Equals(5))
            {
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
            else
            {
                return (BoardState)validationBoardStateIndex;
            }            
        }


        static void Main(string[] args)
        {

            //for (int i = 0; i < args.Length; i++)
            //{   
            //   Console.WriteLine(GetStateOfBoard(args[i]));                
            //}

            GetStateOfBoard("XXXOO____");
        }

    }
}
