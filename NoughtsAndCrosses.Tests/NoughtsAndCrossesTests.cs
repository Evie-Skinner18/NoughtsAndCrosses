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
            _playerOneTurn = new Turn("X________", true, false);
            _playerTwoTurn = new Turn("XO____OOO", false, true);
            _anotherPlayerOneTurn = new Turn("XO_XXX___", true, false);
            //_anotherPlayerTwoTurn = new Turn("")
        }

        

        [Test]
        public void CanCheckForAWinner_ShouldReturnNobodyHasWonYet()
        {
            
        }

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