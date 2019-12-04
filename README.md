# Noughts and Crosses
A C#.Net Core console-based noughts and crosses game

## Tools and Technologies Used
- C#.Net Core 2.2
- NUnit


## Game Rules
- Crosses always goes first
- Players must make a move during their turn in one of the empty slots
- The game ends as soon as a player either gets three in a row, or or there are no empty slots left.

## In a future iteration of this project, I would...
- Learn how to test the GetStateOfBoard() method without repeating it. I'm pretty sure I could do this by having the method in a 
separate, publicly-accessible class.
- Come up with a more clever and concise way of checking for a winner. I have noticed a pattern in the indices of the winning 
combinations so it would probably involve using this pattern.
- Work out why .Net Core 3 didn't work. Ideally I want to use the most up-to-date version!
