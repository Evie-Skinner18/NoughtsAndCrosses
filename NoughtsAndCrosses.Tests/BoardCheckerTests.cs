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
        public void CanCheckIfNoughtsHaveWon_ShouldReturn_False()
        {
            var verdict = _noWinnerBoardChecker.HasWon('O');

            Assert.That(verdict, Is.Not.Null);
            Assert.AreEqual(verdict, false);
        }

        [Test]
        public void CanCheckIfNoughtsHaveWon_ShouldReturn_True()
        {
            var verdict = _noughtsWinnerBoardChecker.HasWon('O');

            Assert.That(verdict, Is.Not.Null);
            Assert.AreEqual(verdict, true);
        }

        [Test]
        public void CanCheckIfCrossesHaveWon_ShouldReturn_False()
        {
            var verdict = _noughtsWinnerBoardChecker.HasWon('X');

            Assert.That(verdict, Is.Not.Null);
            Assert.AreEqual(verdict, false);
        }

        [Test]
        public void CanCheckIfCrossesHaveWon_ShouldReturn_True()
        {
            var verdict = _crossesWinnerBoardChecker.HasWon('X');

            Assert.That(verdict, Is.Not.Null);
            Assert.AreEqual(verdict, true);
        }

        [Test]
        public void CanCheckIfCrossesHaveWonOnADrawBoard_ShouldReturn_False()
        {
            var verdict = _drawBoardChecker.HasWon('X');

            Assert.That(verdict, Is.Not.Null);
            Assert.AreEqual(verdict, false);
        }

        [Test]
        public void CanCheckForAWinner_ShouldReturn_Nobody()
        {
            var verdict = _noWinnerBoardChecker.CheckForAWinner();

            Assert.That(verdict, Is.Not.Null);
            Assert.AreEqual(verdict, "Nobody");
        }

        [Test]
        public void CanCheckForAWinner_ShouldReturn_Noughts()
        {
            var verdict = _noughtsWinnerBoardChecker.CheckForAWinner();

            Assert.That(verdict, Is.Not.Null);
            Assert.AreEqual(verdict, "Noughts");
        }

        [Test]
        public void CanCheckForAWinner_ShouldReturn_Crosses()
        {
            var verdict = _crossesWinnerBoardChecker.CheckForAWinner();

            Assert.That(verdict, Is.Not.Null);
            Assert.AreEqual(verdict, "Crosses");
        }        

        [Test]
        public void CanGetIndexOfWinner_ShouldReturn_0()
        {
            var winnerIndex = _noughtsWinnerBoardChecker.GetIndexOfWinner("Noughts");

            Assert.That(winnerIndex, Is.Not.Null);
            Assert.AreEqual(winnerIndex, 0);
        }

        [Test]
        public void CanGetIndexOfWinner_ShouldReturn_1()
        {
            var winnerIndex = _noughtsWinnerBoardChecker.GetIndexOfWinner("Crosses");

            Assert.That(winnerIndex, Is.Not.Null);
            Assert.AreEqual(winnerIndex, 1);
        }

        [Test]
        public void CanGetIndexOfWinner_ShouldReturn_3()
        {
            var winnerIndex = _noughtsWinnerBoardChecker.GetIndexOfWinner("Nobody");

            Assert.That(winnerIndex, Is.Not.Null);
            Assert.AreEqual(winnerIndex, 3);
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