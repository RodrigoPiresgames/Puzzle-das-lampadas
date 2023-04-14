# Light Puzzle

This project was made for "Linguagens de Programacao I" by:
Joao Freire 22104799
Rodrigo Pires 22103008

On April 10th both students worked on the base code for the project and made the first two commits together using Rodrigo's git account.
On April 11 both students worked together to discuss the project and later implemented what was discussed in call, this once more was using Rodrigo's account.
On April 13th and after the code was changed to make things more visually appealing, this time using Joao's account.
It is important to note that the project was made entirely on videocalls when both elements of the group were present.

How it was made:

The three lights showned are essentially booleans, wich means they are either "true" or "false".
If the one lamp is "false" it will appear as "Off" and if it's "true" it will appear as "On".
Three commands where created, and through the use of switches we changed each lamp's value.
Pressing "A" changes only the value of one lamp, while pressing "S" or "D" changes the value of two lamps.
The game is won when the value of all lamps is set to "true".
After the player presses one of the buttons it is shown to him the state of all lamps and the number of his attempt.
To show the player the number of his attempt a new variable was created that increases one every time the player uses a button.
If the player can't do it in 6 attempts he will lose the game.
The rules and instructions appear everytime the game is reset.
The rules are a function that is called early on in the code but reside in the last lines, under the main function.
