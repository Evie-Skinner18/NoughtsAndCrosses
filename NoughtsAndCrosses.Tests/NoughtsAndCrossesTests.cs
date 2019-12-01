 using NUnit.Framework;
using NoughtsAndCrosses;
using NoughtsAndCrosses.Utilities;

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

            Assert.That(inputIsCorrectLength, Is.Not.Null);
            Assert.AreEqual(inputIsCorrectLength, false);
            Assert.That(inputHasIncorrectCharacters, Is.Not.Null);
            Assert.AreEqual(inputHasIncorrectCharacters, false);
            Assert.That(message, Is.Not.Null);
            Assert.AreEqual(message, "Your game board is invalid sorry!");
        }

        [Test]
        public void CanValidateCorrectUserInput_ShouldReturnOkThanksForThatLovelyGameBoard()
        {
            var inputIsCorrectLength = _correctLengthInputValidator.IsCorrectLength();
            var inputHasIncorrectCharacters = _correctLengthInputValidator.InputHasInvalidCharacters(userInput: "XX__OOO__");
            var message = _correctLengthInputValidator.ValidateUserInput();

            Assert.That(inputIsCorrectLength, Is.Not.Null);
            Assert.AreEqual(inputIsCorrectLength, true);
            Assert.That(inputHasIncorrectCharacters, Is.Not.Null);
            Assert.AreEqual(inputHasIncorrectCharacters, false);
            Assert.That(message, Is.Not.Null);
            Assert.AreEqual(message, "Ok thanks for that lovely game board!");
        }

        [Test]
        public void CanValidateInvalidCharactersUserInput_ShouldReturnYourGameBoardIsInvalidSorry()
        {
            var inputIsCorrectLength = _invalidCharactersValidator.IsCorrectLength();
            var inputHasIncorrectCharacters = _invalidCharactersValidator.InputHasInvalidCharacters(userInput: "OO__$_%_hello");
            var message = _invalidCharactersValidator.ValidateUserInput();

            Assert.That(inputIsCorrectLength, Is.Not.Null);
            Assert.AreEqual(inputIsCorrectLength, false);
            Assert.That(inputHasIncorrectCharacters, Is.Not.Null);
            Assert.AreEqual(inputHasIncorrectCharacters, true);
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