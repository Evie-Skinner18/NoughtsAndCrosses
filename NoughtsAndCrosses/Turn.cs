namespace NoughtsAndCrosses
{
    public class Turn
    {
        private string _currentBoard { get; set; }
        private bool _playerOne { get; set; }
        private bool _playerTwo { get; set; }

        // playerOne is X and playerTwo is O
        public Turn(string currentBoard, bool playerOne, bool playerTwo)
        {
            _currentBoard = currentBoard;
            _playerOne = playerOne;
            _playerTwo = playerTwo;
        }

        public int TakeTurn()
        {
            // int returned will correspond to the int of one of the options of the enum

        }

        public string CheckForAWinner(char playerPiece)
        {
            var verdict = "";

            return verdict = _currentBoard.Contains($"{playerPiece}{playerPiece}{playerPiece}") ? 
                $"Team {playerPiece} has won!" : "Nobody has won yet";
        }

        public bool IsADraw() => 
    }
}
