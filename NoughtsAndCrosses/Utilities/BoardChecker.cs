using System.Collections.Generic;

namespace NoughtsAndCrosses.Utilities
{
    public class BoardChecker
    {
        private string _gameBoard { get; set; }
        private List<string> _noughtsWinningCombinations { get; set; }
        private List<string> _crossesWinningCombinations { get; set; }

        public BoardChecker(string gameBoard)
        {
            _gameBoard = gameBoard;
            _noughtsWinningCombinations = new List<string>()
            {
                "_OOO_",
                "XOOO_",
                "_OOOX",
                "XOOO"
            };
            _crossesWinningCombinations = new List<string>()
            {
                "_XXX_",
                "OXXX_",
                "_XXXO",
                "OXXX"
            };
        }

        // don't know what to do with char playerPiece
        public int CheckForAWinner()
        {
            // initialise this to nobody's won yet because we don't know who's won yet
            var verdict = 3;

            foreach (var combination in _noughtsWinningCombinations)
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

        public bool IsADraw() => _gameBoard.Contains("XXX") && _gameBoard.Contains("OOO");

        public bool BoardIsFull() => !(_gameBoard.Contains("_"));

    }
}
