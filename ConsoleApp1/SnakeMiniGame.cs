using System;
using System.Drawing;
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

// Test if game just started
bool isStart = true;
// Start game
while(terminalOn){
    if (isStart){
        Console.Clear();
        
        SetPlayerPosition();
        NewFoodLocation();
    }
    int[] foodPosition = GetFoodLocation();
    // if (Console.ReadKey().Key == ConsoleKey.UpArrow || Console.ReadKey().Key == ConsoleKey.DownArrow || Console.ReadKey(true).Key == ConsoleKey.LeftArrow || Console.ReadKey(true).Key == ConsoleKey.RightArrow){
        Move();
        Console.Clear();
        SetPlayerPosition();
        OldFoodLocation(foodPosition[0], foodPosition[1]);
        isStart = false;
    // }

    if (Console.WindowHeight != height || Console.WindowWidth != width){
        TerminalTerminateGame();
    }
}

// Food position
void OldFoodLocation(int x, int y)
{
    Console.SetCursorPosition(x-1, y);  // Food
    Console.Write(food);
}

void NewFoodLocation()
{
    Console.SetCursorPosition(random.Next(0, width-5), random.Next(0, height-5));  // Food
    Console.Write(food);
}

// Returns cursor/food position
int[] GetFoodLocation()
{
    int[] cursorPosition = new int[] {Console.GetCursorPosition().Left, Console.GetCursorPosition().Top};
    return cursorPosition;
}

// Check player position
void CheckPlayerPosition()
{
    int[] foodPosition = GetFoodLocation();
    if (playerX == foodPosition[0] && playerY == foodPosition[1]){

    }
}
// Player position
void SetPlayerPosition(){
    Console.SetCursorPosition(playerX, playerY);   // Player
    Console.Write(player);
}

void TerminalTerminateGame() 
{
    Console.Clear();
    Console.WriteLine("Console was resized. Program exiting.");
    terminalOn = false;
}

void Move(int speed = 1) 
{
    switch (Console.ReadKey(true).Key) {
        case ConsoleKey.UpArrow:
            playerY--; 
            break;
		case ConsoleKey.DownArrow: 
            playerY++; 
            break;
		case ConsoleKey.LeftArrow:  
            playerX -= speed; 
            break;
		case ConsoleKey.RightArrow: 
            playerX += speed; 
            break;
		case ConsoleKey.Escape:     
            terminalOn = false; 
            break;
        default:
            terminalOn = false;
            break;
    }
}