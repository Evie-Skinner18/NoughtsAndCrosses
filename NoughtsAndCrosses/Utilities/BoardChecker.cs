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
                message = "Noughts have won!";
            }
            else if (HasWon('X'))
            {
                message = "Crosses have won!";
            }
            else
            {
                message = "Nobody has won yet";
            }

            return message;
        }

        public int CheckBoardState()
        {
            // initialise this to nobody's won yet because we don't know who's won yet
            var verdict = 3;

            // 0 for noughts 

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

        public bool IsADraw() => _gameBoard.Contains("XXX") && _gameBoard.Contains("OOO");

        public bool BoardIsFull() => !(_gameBoard.Contains("_"));

    }
}
