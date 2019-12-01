 using NUnit.Framework;
using NoughtsAndCrosses;

namespace Tests
{
    public class Tests
    {       
        private Validator _longInputValidator;
        private Validator _correctLengthInputValidator;
        private Validator _invalidCharactersValidator;



        [SetUp]
        public void Setup()
        {
            _longInputValidator = new Validator("XXXXXXXXXX");
            _correctLengthInputValidator = new Validator("XX__OOO__");
            _invalidCharactersValidator = new Validator("OO__$_%_hello");
                
        }

        [Test]
        public void CanValidateLengthyUserInput_ShouldReturnYourGameBoardIsInvalidSorry()
        {
            var inputIsCorrectLength = _longInputValidator.IsCorrectLength();
            var inputHasIncorrectCharacters = _longInputValidator.InputHasInvalidCharacters(userInput:"XXXXXXXXXX");
            var message = _longInputValidator.ValidateUserInput();

            Assert.That(message, Is.Not.Null);
            Assert.AreEqual(message, "Your game board is invalid sorry!");
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