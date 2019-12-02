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
            // these first two are non-cheating turns
            _playerOneTurn = new Turn("X_______O", "X________", true);
            _playerTwoTurn = new Turn("XO____OOO", "XO____OO_", false);

            // player one has cheekily overwritten player two's turn
            _anotherPlayerOneTurn = new Turn("XO_XXX___", "XO_OXX___", true);
            // player two has cheekily placed two Os in one go
            _anotherPlayerTwoTurn = new Turn("X_OO_____", "X________", false);
        }     

        [Test]
        public void CanDetectAPlayerTryingToOverwriteTheOtherPlayersTurn_ShouldReturn_MessageAboutTheUnderscores()
        {
            var overwritingCheatingMessage = _anotherPlayerOneTurn.TakeTurn();

            Assert.That(overwritingCheatingMessage, Is.Not.Null);
            Assert.AreEqual(overwritingCheatingMessage, "No cheating! You can only place your O or X on an empty square (underscore)");
        }

        [Test]
        public void CanDetectAPlayerTryingToPlaceTwoPiecesInOneTurn_ShouldReturn_MessageAboutOnePieceAtATime()
        {
            var onePieceAtATimeCheatingMessage = _anotherPlayerTwoTurn.TakeTurn();

            Assert.That(onePieceAtATimeCheatingMessage, Is.Not.Null);
            Assert.AreEqual(onePieceAtATimeCheatingMessage, "Don't be cheeky now! You can only place one X or O on the board at a time.");
        }

        [Test]
        public void CanDetectAPlayerPlayingFairly_ShouldReturn_GameOn()
        {
            var playerOneGameOnMessage = _playerOneTurn.TakeTurn();
            var playerTwoGameOnMessage = _playerTwoTurn.TakeTurn();

            Assert.That(playerOneGameOnMessage, Is.Not.Null);
            Assert.That(playerTwoGameOnMessage, Is.Not.Null);

            Assert.AreEqual(playerOneGameOnMessage, "Game on...");
            Assert.AreEqual(playerTwoGameOnMessage, "Game on...");
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