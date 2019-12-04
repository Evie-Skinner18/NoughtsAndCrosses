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

        // 5 valid board and 4 for INvalid
        [Test]
        public void CanValidateLengthyUserInput_ShouldReturn_4()
        {
            var inputIsCorrectLength = _longInputValidator.IsCorrectLength();
            var inputHasIncorrectCharacters = _longInputValidator.InputHasInvalidCharacters();
            var validationIndex = _longInputValidator.ValidateUserInput();

            Assert.That(inputIsCorrectLength, Is.Not.Null);
            Assert.AreEqual(inputIsCorrectLength, false);
            Assert.That(inputHasIncorrectCharacters, Is.Not.Null);
            Assert.AreEqual(inputHasIncorrectCharacters, false);
            Assert.That(validationIndex, Is.Not.Null);
            Assert.AreEqual(validationIndex, 4);
        }

        [Test]
        public void CanValidateCorrectUserInput_ShouldReturn_5()
        {
            var inputIsCorrectLength = _correctLengthInputValidator.IsCorrectLength();
            var inputHasIncorrectCharacters = _correctLengthInputValidator.InputHasInvalidCharacters();
            var validationIndex = _correctLengthInputValidator.ValidateUserInput();

            Assert.That(inputIsCorrectLength, Is.Not.Null);
            Assert.AreEqual(inputIsCorrectLength, true);
            Assert.That(inputHasIncorrectCharacters, Is.Not.Null);
            Assert.AreEqual(inputHasIncorrectCharacters, false);
            Assert.That(validationIndex, Is.Not.Null);
            Assert.AreEqual(validationIndex, 5);
        }

        [Test]
        public void CanValidateInvalidCharactersUserInput_ShouldReturn_4()
        {
            var inputIsCorrectLength = _invalidCharactersValidator.IsCorrectLength();
            var inputHasIncorrectCharacters = _invalidCharactersValidator.InputHasInvalidCharacters();
            var validationIndex = _invalidCharactersValidator.ValidateUserInput();

            Assert.That(inputIsCorrectLength, Is.Not.Null);
            Assert.AreEqual(inputIsCorrectLength, false);
            Assert.That(inputHasIncorrectCharacters, Is.Not.Null);
            Assert.AreEqual(inputHasIncorrectCharacters, true);
            Assert.That(validationIndex, Is.Not.Null);
            Assert.AreEqual(validationIndex, 4);
        }
    }
}