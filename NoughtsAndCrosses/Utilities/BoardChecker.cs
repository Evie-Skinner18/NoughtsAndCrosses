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

        public int CheckBoardState(string message)
        {
            // initialise this to nobody's won yet because we don't know who's won yet
            var verdict = 3;

            switch(message)
            {
                // 0 for noughts 
                case "Noughts": return 0;
                case "Crosses": return 1;
                default: break;                
            }
            cas

            // 1 for crosses

            //  2 draw

            // 3 nobody
            
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
                someoneHasWon = combination.Except(boxIndicesContainingThisPiece).Equals(0);
            }

            return someoneHasWon;
        }
        
        public bool BoardIsFull() => !(_gameBoard.Contains('_'));
        // it's a draw if the board is full with no winner
        public bool IsADraw() => BoardIsFull() && (HasWon('O').Equals(false) && HasWon('X').Equals(false));


    }
}
