using System.Linq;
using System.Collections.Generic;

namespace NoughtsAndCrosses.Utilities
{
    public class Validator
    {
        private string _userInput;

        public Validator(string userInput)
        {
            _userInput = userInput;
        }

        public string ValidateUserInput()
        {
            string message;

            if ((IsCorrectLength() && _userInput.StartsWith("X") && !(InputHasInvalidCharacters())))
            {
                message = "That game board will do nicely.";
            }
            else
            {
                message = "Your game board is invalid sorry!";
            }

            return message;
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
