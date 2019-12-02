using NoughtsAndCrosses.Utilities;
using System.Linq;

namespace NoughtsAndCrosses
{
    public class Turn
    {
        private string _currentBoard { get; set; }
        private string _previousBoard { get; set; }
        private bool _playerOne { get; set; }
        private BoardChecker _boardChecker { get; set; }

        // playerOne is X and playerTwo is O
        public Turn(string currentBoard, bool playerOne)
        {
            _currentBoard = currentBoard;
            _playerOne = playerOne;
        }

        public Turn(string currentBoard, string previousBoard, bool playerOne)
        {
            _currentBoard = currentBoard;
            _previousBoard = previousBoard;
            _playerOne = playerOne;
            _boardChecker = new BoardChecker(_currentBoard);
        }

        public string TakeTurn()
        {
            // count no of underscores: if player has correctly placed their counter on an underscore, this number will have decreased by one
            var currentBoardCharList = _currentBoard.ToList<char>();
            var previousBoardCharList = _previousBoard.ToList<char>();

            var numberOfUnderscoresOnCurrentBoard = currentBoardCharList.Where(c => c.Equals('_')).Count();                
            var numberOfUnderscoresOnPreviousBoard = previousBoardCharList.Where(c => c.Equals('_')).Count();

            var message = "";
                        
            if (_boardChecker.BoardIsFull())
            {
                message = "Game over!";
            }
            // if no of underscores is same between the two boards, you know a player has tried to override an X or O
            else if (numberOfUnderscoresOnCurrentBoard.Equals(numberOfUnderscoresOnPreviousBoard))
            {
                message = "No cheating! You can only place your O or X on an empty square (underscore)";
            }
            // if no of underscores has decremented by more than 1, you know someone's trying to cheat in another way
            else if ((numberOfUnderscoresOnPreviousBoard - numberOfUnderscoresOnCurrentBoard) > 1)
            {
                message = "Don't be cheeky now! You can only place one X or O on the board at a time.";
            }            
            else
            {
                message = "Game on...";
            }           
            return message;
        }

        public string PrintMessage()
        {
            return _playerOne ? "It's Crosses' turn!" : "It's Noughts' turn!";
        }

    }
}
