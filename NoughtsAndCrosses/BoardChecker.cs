namespace NoughtsAndCrosses
{
    public class BoardChecker
    {
        public enum _boardState
        {
            NOUGHTS_WIN, CROSSES_WIN, DRAW, NOBODY_HAS_WON_YET
        };

        public string Outcome;

        public BoardChecker()
        {
            
        }

        public _boardState GetStateOfBoard(string userBoard)
        {
            //var boardState = new BoardState();
            


            //switch(board)
            //{
            //    case board
            //}

            // if it contains XXX then crosses have won
            // if it contains OOO then Os have won
            // anything else means nobody has won yet
            if (userBoard.Contains("XXX"))
            {
                Outcome = _boardState.CROSSES_WIN
                return Outcome;
            }
            return _boardState.NOBODY_HAS_WON_YET;
        }
    }
}
