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

        public int CheckForAWinner(char playerPiece)
        {
            // initialise this to nobody's won yet because we don't know who's won yet
            var verdict = 3;
            var hasWon = false;
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
                hasWon = combination.Except(boxIndicesContainingThisPiece).Equals(0);
            }

            foreach (var combination in _winningCombinations)
            {
                if (_gameBoard.Contains(combination))
                {
                    verdict = 0;
                    break;
                }
            }

            foreach (var combination in _crossesWinningCombinations)
            {
                if(_gameBoard.Contains(combination))
                {
                    verdict = 1;
                    break;
                }
            }

            return verdict;            
        }

        public int DecideWhoHasWon()
        {

        }

        public bool IsADraw() => _gameBoard.Contains("XXX") && _gameBoard.Contains("OOO");

        public bool BoardIsFull() => !(_gameBoard.Contains("_"));

    }
}
