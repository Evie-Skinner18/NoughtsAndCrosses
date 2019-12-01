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
            var userInputList = new List<char>();
            userInputList = _userInput.ToList();
            var inputHasInvalidCharacter = false;

            foreach (var c in userInputList)
            {
                inputHasInvalidCharacter = IsInvalidCharacter(c) ? true : false;
            }

            return message = inputHasInvalidCharacter ? 
                "Sorry but your game board is invalid!" : "Ok thanks for that lovely game board!";
        }

        public bool IsInvalidCharacter(char c) => !(c.Equals('_') || c.Equals('X') || c.Equals('O'));
    }
}
