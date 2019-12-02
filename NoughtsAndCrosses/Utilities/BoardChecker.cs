namespace NoughtsAndCrosses.Utilities
{
    public static class BoardChecker
    {
        
        public static string CheckForAWinner(char playerPiece, string currentBoard)
        {
            var verdict = "";

            return verdict = currentBoard.Contains($"{playerPiece}{playerPiece}{playerPiece}") ?
                $"Team {playerPiece} has won!" : "Nobody has won yet";
        }

        public static bool IsADraw(string currentBoard) => currentBoard.Contains("XXX") && currentBoard.Contains("OOO");

    }
}
