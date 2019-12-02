namespace NoughtsAndCrosses
{
    public class Turn
    {
        private string _currentBoard { get; set; }
        private string _previousBoard { get; set; }
        private bool _playerOne { get; set; }
        private bool _playerTwo { get; set; }

        // playerOne is X and playerTwo is O
        public Turn(string currentBoard, bool playerOne)
        {
            _currentBoard = currentBoard;
            _playerOne = playerOne;
            _playerTwo = !playerOne;
        }

        public Turn(string currentBoard, string previousBoard, bool playerOne)
        {
            _currentBoard = currentBoard;
            _previousBoard = previousBoard;
            _playerOne = playerOne;
            _playerTwo = !playerOne;
        }

        public int TakeTurn()
        {
            // int returned will correspond to the int of one of the options of the enum

            // compare current board with previous board. HAs anyone tried to put their piece on a sqare that's already taken?


        }

        public string PrintMessage()
        {
            return _playerOne ? "It's Crosses' turn!" : "It's Noughts' turn!";
        }

    }
}
