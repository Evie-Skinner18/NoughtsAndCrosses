using NUnit.Framework;
using NoughtsAndCrosses;
using NoughtsAndCrosses.Utilities;

namespace Tests
{
    public class NoughtsAndCrossesTests
    {       
        private Turn _playerOneTurn;
        private Turn _playerTwoTurn;
        private Turn _anotherPlayerOneTurn;
        private Turn _anotherPlayerTwoTurn;

        [SetUp]
        public void Setup()
        {
            // give each turn the current board and the previous board
            _playerOneTurn = new Turn("X________", "_________", true);
            _playerTwoTurn = new Turn("XO____OOO", "XO____OO_", false);

            // player one has cheekily overwritten player two's turn
            _anotherPlayerOneTurn = new Turn("XO_XXX___", "XO_OXX___", true);
            //_anotherPlayerTwoTurn = new Turn("")
        }        


        [Test]
        public void CanDetectAPlayerTryingToOverwriteTheOtherPlayersTurn_ShouldReturn_()
        {
            var charsMissingFromPreviousBoard = _anotherPlayerOneTurn.TakeTurn();

            var message = _anotherPlayerOneTurn.PrintMessage();

            Assert.That(charsMissingFromPreviousBoard, Is.Not.Null);
        }
        //[Test]
        //public void CanCheckForAWinner_ShouldReturnNobodyHasWonYet()
        //{
            
        //}

        //[Test]
        //public void CanGetStateOfBoardWhenUserEntersXXX___O_ShouldReturn_CROSSES_WIN()
        //{
        //    // arrange
        //    var gameBoardState = _boardChecker.
        //    // act

        //    // assert
        //}
    }
}