using System;
Console.CursorVisible = false;
// IsFoodConsumed();
// UpdatePlayerStatus();
// PauseMovementSpeed();
// NewFoodLocation();
// CharacterTerminateGame();

Random random = new Random();

// Terminal size
var width = Console.WindowWidth;
var height = Console.WindowHeight;

// Player
var player = "@@@@@@";
int playerX = 2;
int playerY = 2;

// Food
var food = "*";

// Set terminal
bool terminalOn = true;

//Start game
while(terminalOn){
    Console.Clear();
    Position();
    TerminalTerminateGame(width, height);
}

//Player and food position
void Position(){
    Console.SetCursorPosition(playerX, playerY);   // Player
    Console.Write(player);

    Console.SetCursorPosition(random.Next(0, width-5), random.Next(0, height-5));  // Food
    Console.Write(food);
    Thread.Sleep(1000);
}

void TerminalTerminateGame(int width, int height) 
{
    Console.Clear();
    if (Console.WindowHeight != height && Console.WindowWidth != width){
        Console.Clear();
        Console.WriteLine("Console was resized. Program exiting."+width+ " "+ height);
        terminalOn = false;
    }
}