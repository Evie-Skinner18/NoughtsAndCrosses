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
            if (userBoard.Contains("XXX") && userBoard.Contains("OOO"))
            {
                return BoardState.DRAW;
            }
            else if (userBoard.Contains("OOO"))
            {
                return BoardState.NOUGHTS_WIN;
            }
            else if (userBoard.Contains("XXX"))
            {
                return BoardState.CROSSES_WIN;
            }     
            return BoardState.NOBODY_HAS_WON_YET;
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Noughts and Crosses! Please enter the current state of your game board " +
                "using a mixture of nine inputs of the following characters: X, O and _ (underscore for " +
                "empty squares). Team Crosses must go first. For example, 'XX_OOO___'");

            var arguments = args.ToList<string>();
            arguments.RemoveAt(0);
            args = arguments.ToArray();


            for (int i = 0; i < args.Length; i++)
            {
                var validator = new Validator(args[i]);
                var message = validator.ValidateUserInput();
                Console.WriteLine(message);

                if (message.Contains("sorry!"))
                {
                    continue;
                }               
                else
                {
                    Console.WriteLine(GetStateOfBoard(args[i]));
                }

            }
        }

    }
}
