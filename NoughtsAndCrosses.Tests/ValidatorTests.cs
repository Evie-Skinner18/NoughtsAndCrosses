using NoughtsAndCrosses.Utilities;
using NUnit.Framework;

namespace Tests
{
    public class ValidatorTests
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
            var inputHasIncorrectCharacters = _longInputValidator.InputHasInvalidCharacters();
            var message = _longInputValidator.ValidateUserInput();

            Assert.That(inputIsCorrectLength, Is.Not.Null);
            Assert.AreEqual(inputIsCorrectLength, false);
            Assert.That(inputHasIncorrectCharacters, Is.Not.Null);
            Assert.AreEqual(inputHasIncorrectCharacters, false);
            Assert.That(message, Is.Not.Null);
            Assert.AreEqual(message, "Your game board is invalid sorry!");
        }

        [Test]
        public void CanValidateCorrectUserInput_ShouldReturnThatGameBoardWillDoNicely()
        {
            var inputIsCorrectLength = _correctLengthInputValidator.IsCorrectLength();
            var inputHasIncorrectCharacters = _correctLengthInputValidator.InputHasInvalidCharacters();
            var message = _correctLengthInputValidator.ValidateUserInput();

            Assert.That(inputIsCorrectLength, Is.Not.Null);
            Assert.AreEqual(inputIsCorrectLength, true);
            Assert.That(inputHasIncorrectCharacters, Is.Not.Null);
            Assert.AreEqual(inputHasIncorrectCharacters, false);
            Assert.That(message, Is.Not.Null);
            Assert.AreEqual(message, "That game board will do nicely.");
        }

        [Test]
        public void CanValidateInvalidCharactersUserInput_ShouldReturnYourGameBoardIsInvalidSorry()
        {
            var inputIsCorrectLength = _invalidCharactersValidator.IsCorrectLength();
            var inputHasIncorrectCharacters = _invalidCharactersValidator.InputHasInvalidCharacters();
            var message = _invalidCharactersValidator.ValidateUserInput();

            Assert.That(inputIsCorrectLength, Is.Not.Null);
            Assert.AreEqual(inputIsCorrectLength, false);
            Assert.That(inputHasIncorrectCharacters, Is.Not.Null);
            Assert.AreEqual(inputHasIncorrectCharacters, true);
            Assert.That(message, Is.Not.Null);
            Assert.AreEqual(message, "Your game board is invalid sorry!");
        }
    }
}