using System.Linq;

namespace NoughtsAndCrosses.Utilities
{
    public class Validator
    {
        private string _userInput;

        public Validator(string userInput)
        {
            _userInput = userInput;
        }

        public int ValidateUserInput()
        {
            // 5 valid board and 4 for INvalid
            return (IsCorrectLength() && _userInput.StartsWith("X") && !(InputHasInvalidCharacters())) ? 5 : 4;
        }

        public bool InputHasInvalidCharacters()
        {
            var userInputList = _userInput.ToList();
            var inputHasInvalidCharacter = false;

            foreach (var c in userInputList)
            {
                inputHasInvalidCharacter = !(IsValidCharacter(c)) ? true : false;
                if (inputHasInvalidCharacter)
                {
                    break;
                }
                continue;
            }

            return inputHasInvalidCharacter;
        }

        public bool IsValidCharacter(char c) => c.Equals('_') || c.Equals('X') || c.Equals('O');

        public bool IsCorrectLength() => _userInput.Trim().Length == 9;
    }
}
