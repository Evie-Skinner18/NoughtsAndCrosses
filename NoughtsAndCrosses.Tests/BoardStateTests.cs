using NUnit.Framework;
using NoughtsAndCrosses;

namespace Tests
{
    public class BoardStateTests
    {
        private enum BoardState
        {
            NOUGHTS_WIN, CROSSES_WIN, DRAW, NOBODY_HAS_WON_YET, BOARD_IS_INVALID
        }

        [SetUp]
        public void Setup()
        {
            
        }


        [Test]
        public void CanGetBoardState_ShouldReturn_NOUGHTS_WIN()
        {

        }
    }
}