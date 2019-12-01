using System.Linq;
using System.Collections.Generic;

namespace NoughtsAndCrosses
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
            var message = "";

            if (IsCorrectLength())
            {
                message = "Your board has nine inputs, great!";
            }
            else if (!(InputHasInvalidCharacters(_userInput)))
            {
                message = "Ok thanks for that lovely game board!";
            }
            else
            {
                message = "Your game board is invalid sorry!";
            }

            return message;
        }

        public bool InputHasInvalidCharacters(string userInput)
        {
            var userInputList = new List<char>();
            userInputList = _userInput.ToList();
            var inputHasInvalidCharacter = false;

            foreach (var c in userInputList)
            {
                inputHasInvalidCharacter = IsInvalidCharacter(c) ? true : false;
                if (inputHasInvalidCharacter)
                {
                    break;
                }
                continue;
            }

            return inputHasInvalidCharacter;
        }

        public bool IsInvalidCharacter(char c) => !(c.Equals('_') || c.Equals('X') || c.Equals('O'));

        public bool IsCorrectLength() => _userInput.Trim().Length == 9;
    }
}
