using System;

// IsFoodConsumed();
// UpdatePlayerStatus();
// PauseMovementSpeed();
// NewFoodLocation();
// CharacterTerminateGame();

var width = Console.WindowWidth;
var height = Console.WindowHeight;

TerminalTerminateGame(width, height);

void TerminalTerminateGame(int width, int height) 
{

    Console.Clear();
    Console.SetCursorPosition(5, 5);
    if (Console.WindowHeight != height && Console.WindowWidth != width){
        Console.Clear();
        Console.WriteLine("Console was resized. Program exiting."+width+ " "+ height);
    }
}