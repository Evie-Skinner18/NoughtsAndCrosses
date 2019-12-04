using NUnit.Framework;
using NoughtsAndCrosses.Utilities;

namespace Tests
{
    public class BoardStateTests
    {
        private enum BoardState
        {
            NOUGHTS_WIN, CROSSES_WIN, DRAW, NOBODY_HAS_WON_YET, BOARD_IS_INVALID
        }

        private static BoardState GetStateOfBoard(string userBoard)
        {
            var boardChecker = new BoardChecker(userBoard);
            var validator = new Validator(userBoard);
            var validationBoardStateIndex = validator.ValidateUserInput();

            // if board is valid, then we can check for draw, wins etc
            if (validationBoardStateIndex.Equals(5))
            {
                if (boardChecker.IsADraw())
                {
                    return BoardState.DRAW;
                }
                else
                {
                    var winnerMessage = boardChecker.CheckForAWinner();
                    var boardStateIndex = boardChecker.GetIndexOfWinner(winnerMessage);
                    return (BoardState)boardStateIndex;
                }
            }
            else
            {
                return (BoardState)validationBoardStateIndex;
            }
        }      


        [Test]
        public void CanGetBoardState_ShouldReturn_NOUGHTS_WIN()
        {
            var noughtsMessage = GetStateOfBoard("XX_OOOX__");

            Assert.That(noughtsMessage, Is.Not.Null);
            Assert.AreEqual(noughtsMessage, BoardState.NOUGHTS_WIN);
        }

        [Test]
        public void CanGetBoardState_ShouldReturn_CROSSES_WIN()
        {
            var noughtsMessage = GetStateOfBoard("XXXOO____");

            Assert.That(noughtsMessage, Is.Not.Null);
            Assert.AreEqual(noughtsMessage, BoardState.CROSSES_WIN);
        }

        [Test]
        public void CanGetBoardState_ShouldReturn_NOUGHTS_WIN()
        {
            var noughtsMessage = GetStateOfBoard("XX_OOOX__");

            Assert.That(noughtsMessage, Is.Not.Null);
            Assert.AreEqual(noughtsMessage, BoardState.NOUGHTS_WIN);
        }
    }
}