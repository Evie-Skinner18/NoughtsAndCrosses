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
        private BoardChecker _gameOverBoardChecker;

        [SetUp]
        public void Setup()
        {
            _noWinnerBoardChecker = new BoardChecker("XXXXXXXXX");
            _noughtsWinnerBoardChecker = new BoardChecker("X_OXOXOOO");
            _crossesWinnerBoardChecker = new BoardChecker("XO_XXXO_O");
            _drawBoardChecker = new BoardChecker("X_OXXXOOO");
            _gameOverBoardChecker = new BoardChecker("XOXOXOXXX");
        }


        [Test]
        public void CanCheckForAWinner_ShouldReturn_3()
        {
            // 3 = nobody has won yet
            var verdict = _noWinnerBoardChecker.CheckForAWinner();

            Assert.That(verdict, Is.Not.Null);
            Assert.AreEqual(verdict, 3);
        }

        [Test]
        public void CanCheckForAWinner_ShouldReturn_0()
        {
            // 0 = noughts have won
            var verdict = _noughtsWinnerBoardChecker.CheckForAWinner();

            Assert.That(verdict, Is.Not.Null);
            Assert.AreEqual(verdict, 0);
        }

        [Test]
        public void CanCheckForAWinner_ShouldReturn_1()
        {
            // 1 = crosses have won
            var verdict = _crossesWinnerBoardChecker.CheckForAWinner();

            Assert.That(verdict, Is.Not.Null);
            Assert.AreEqual(verdict, 1);
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
            var verdict = _gameOverBoardChecker.BoardIsFull();

            Assert.That(verdict, Is.Not.Null);
            Assert.AreEqual(verdict, true);
        }
    }
}