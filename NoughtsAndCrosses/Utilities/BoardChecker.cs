using System.Collections.Generic;
using System.Linq;

namespace NoughtsAndCrosses.Utilities
{
    public class BoardChecker
    {
        private List<char> _gameBoard { get; set; }
        private List<List<int>> _winningCombinations { get; set; }

        public BoardChecker(string gameBoard)
        {
            _gameBoard = gameBoard.ToList<char>();
            _winningCombinations = new List<List<int>>()
            {
                // across i++
                new List<int>()
                { 0, 1, 2 },
                new List<int>()
                { 3, 4, 5 },
                new List<int>()
                { 6, 7, 8 },

                // diagonal i+4
                new List<int>()
                { 0, 4, 8 },
                new List<int>()
                { 2, 4, 6 },

                // down i+3
                new List<int>()
                { 0, 3, 6 },
                new List<int>()
                { 1, 4, 7 },
                new List<int>()
                { 2, 5, 8 },
            };            
        }

        // if no draw, check for winner
        public string CheckForAWinner()
        {
            var message = "";

            if (HasWon('O'))
            {
                message = "Noughts";
            }
            else if (HasWon('X'))
            {
                message = "Crosses";
            }
            else
            {
                message = "Nobody";
            }

            return message;
        }

        // if it's not a draw we can get an index corresponding to the winner which we can use in Program.cs for relevant BoardState
        public int GetIndexOfWinner(string message)
        {         
            switch(message)
            {
                case "Noughts": return 0;
                case "Crosses": return 1;
                default: return 3;                
            }       
        }

       public bool HasWon(char playerPiece)
        {
            var someoneHasWon = false;
            var boxIndicesContainingThisPiece = new List<int>();

            for (int i = 0; i < _gameBoard.Count(); i++)
            {
                if (_gameBoard[i].Equals(playerPiece))
                {
                    boxIndicesContainingThisPiece.Add(i);
                }
            }

            foreach (var combination in _winningCombinations)
            {
                // if the same three box indices taken correspond to a winning combination, we have a winner!
                someoneHasWon = combination.Except(boxIndicesContainingThisPiece).Count().Equals(0);

                if (someoneHasWon)
                {
                    break;
                }
            }

            return someoneHasWon;
        }
        
        public bool BoardIsFull() => !(_gameBoard.Contains('_'));

        // it's a draw if the board is full with no winner
        public bool IsADraw() => BoardIsFull() && (HasWon('O').Equals(false) && HasWon('X').Equals(false));
    }
}
