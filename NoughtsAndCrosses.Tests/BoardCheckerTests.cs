using NUnit.Framework;
using NoughtsAndCrosses.Utilities;

namespace Tests
{
    public class BoardCheckerTests
    {
        private BoardChecker _noWinnerBoardChecker;
        private BoardChecker _noughtsWinnerBoardChecker;
        private BoardChecker _crossesWinnerBoardChecker;
        private BoardChecker _drawBoardChecker;

        [SetUp]
        public void Setup()
        {
            _noWinnerBoardChecker = new BoardChecker("XOXOXO___");
            _noughtsWinnerBoardChecker = new BoardChecker("X_OXOXOOO");
            _crossesWinnerBoardChecker = new BoardChecker("XO_XXXO_O");
            _drawBoardChecker = new BoardChecker("XOOOXXXXO");
        }

        [Test]
        public void CanCheckIfNoughtsHaveWon_ShouldReturnFalse()
        {
            var verdict = _noWinnerBoardChecker.HasWon('O');

            Assert.That(verdict, Is.Not.Null);
            Assert.AreEqual(verdict, false);
        }

        [Test]
        public void CanCheckIfNoughtsHaveWon_ShouldReturnTrue()
        {
            var verdict = _noughtsWinnerBoardChecker.HasWon('O');

            Assert.That(verdict, Is.Not.Null);
            Assert.AreEqual(verdict, true);
        }

        [Test]
        public void CanCheckIfCrossesHaveWon_ShouldReturnFalse()
        {
            var verdict = _noughtsWinnerBoardChecker.HasWon('X');

            Assert.That(verdict, Is.Not.Null);
            Assert.AreEqual(verdict, false);
        }

        [Test]
        public void CanCheckIfCrossesHaveWon_ShouldReturnTrue()
        {
            var verdict = _crossesWinnerBoardChecker.HasWon('X');

            Assert.That(verdict, Is.Not.Null);
            Assert.AreEqual(verdict, true);
        }

        [Test]
        public void CanCheckIfCrossesHaveWonOnADrawBoard_ShouldReturnFalse()
        {
            var verdict = _drawBoardChecker.HasWon('X');

            Assert.That(verdict, Is.Not.Null);
            Assert.AreEqual(verdict, false);
        }

        [Test]
        public void CanCheckForAWinner_ShouldReturn_Nobody()
        {
            // 3 = nobody has won yet
            var verdict = _noWinnerBoardChecker.CheckForAWinner();

            Assert.That(verdict, Is.Not.Null);
            Assert.AreEqual(verdict, "Nobody");
        }

        [Test]
        public void CanCheckForAWinner_ShouldReturn_Noughts()
        {
            // 0 = noughts have won
            var verdict = _noughtsWinnerBoardChecker.CheckForAWinner();

            Assert.That(verdict, Is.Not.Null);
            Assert.AreEqual(verdict, "Noughts");
        }

        [Test]
        public void CanCheckForAWinner_ShouldReturn_Crosses()
        {
            // 1 = crosses have won
            var verdict = _crossesWinnerBoardChecker.CheckForAWinner();

            Assert.That(verdict, Is.Not.Null);
            Assert.AreEqual(verdict, "Crosses");
        }        

        [Test]
        public void CanGetIndexOfWinner_ShouldReturn_0()
        {

        }

        [Test]
        public void CanGetIndexOfWinner_ShouldReturn_1()
        {

        }

        [Test]
        public void CanGetIndexOfWinner_ShouldReturn_3()
        {

        }

        [Test]
        public void CanCheckForADraw_ShouldReturnTrue()
        {
            // true = draw
            var verdict = _drawBoardChecker.IsADraw();

            Assert.That(verdict, Is.Not.Null);
            Assert.AreEqual(verdict, true);
        }


        [Test]
        public void CanCheckIfBoardIsFull_ShouldReturnTrue()
        {
            // true = full
            var verdict = _drawBoardChecker.BoardIsFull();

            Assert.That(verdict, Is.Not.Null);
            Assert.AreEqual(verdict, true);
        }
    }
}