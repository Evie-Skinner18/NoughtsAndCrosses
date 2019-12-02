namespace NoughtsAndCrosses.Utilities
{
    public static class BoardChecker
    {
        // don't know what to do with char playerPiece
        public static int CheckForAWinner(string currentBoard)
        {
            if (currentBoard.Contains("OOO"))
            {
                return 0;
            }
            else if (currentBoard.Contains("XXX"))
            {
                return 1;
            }
            return 3;            
        }

        public static bool IsADraw(string currentBoard) => currentBoard.Contains("XXX") && currentBoard.Contains("OOO");

    }
}
