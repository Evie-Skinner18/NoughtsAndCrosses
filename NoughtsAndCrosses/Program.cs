using System;
using System.Linq;
using NoughtsAndCrosses.Utilities;

namespace NoughtsAndCrosses
{
    partial class Program
    {
        private enum BoardState
        {
            NOUGHTS_WIN, CROSSES_WIN, DRAW, NOBODY_HAS_WON_YET
        }


        private static BoardState GetStateOfBoard(string userBoard)
        {
           // if it contains XXX then crosses have won
            // if it contains OOO then Os have won
            // anything else means nobody has won yet
            if (BoardChecker.IsADraw(userBoard))
            {
                return BoardState.DRAW;
            }          
            else
            {
                var boardStateIndex = BoardChecker.CheckForAWinner(userBoard);
                return (BoardState)boardStateIndex;
            }
        }


        static void Main(string[] args)
        {
            // leaving Main method unchanged won't work
            Console.WriteLine("Welcome to Noughts and Crosses! Please enter the current state of your game board " +
                "using a mixture of nine inputs of the following characters: X, O and _ (underscore for " +
                "empty squares). Team Crosses must go first. For example, 'XX_OOO___'");

            var arguments = args.ToList<string>();
            arguments.RemoveAt(0);
            args = arguments.ToArray();

            // start off with playerOne true because Crosses always go first
            var playerOne = true;
            var playerTwo = !playerOne;

            for (int i = 0; i < args.Length; i++)
            {
                var validator = new Validator(args[i]);
                var message = validator.ValidateUserInput();
                Console.WriteLine(message);

                if (message.Contains("sorry!"))
                {
                    continue;
                }   
                // if it's the very first turn then there is no previous board
                else if(i == 0)
                {
                    var thisPlayersTurn = new Turn(args[i], playerOne);
                    Console.WriteLine(thisPlayersTurn.PrintMessage()); 
                    Console.WriteLine(GetStateOfBoard(args[i]));
                }
                // for all successive turns
                else
                {
                    var thisPlayersTurn = new Turn(args[i], args[i -1], playerOne);
                    Console.WriteLine(thisPlayersTurn.PrintMessage());
                    Console.WriteLine(thisPlayersTurn.TakeTurn());
                    Console.WriteLine(GetStateOfBoard(args[i]));
                }

                // swap the players each turn
                playerOne = !playerOne;
            }
        }

    }
}
