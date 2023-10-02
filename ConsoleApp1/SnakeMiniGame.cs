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
        
        SetPlayerPosition(playerX, playerY);
        NewFoodLocation();
    }
    int[] foodPosition = GetFoodLocation();
    // if (Console.ReadKey().Key == ConsoleKey.UpArrow || Console.ReadKey().Key == ConsoleKey.DownArrow || Console.ReadKey(true).Key == ConsoleKey.LeftArrow || Console.ReadKey(true).Key == ConsoleKey.RightArrow){
        Move();
        Console.Clear();
        SetPlayerPosition(playerX, playerY);
        CheckPlayerPosition(foodPosition);
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
    Console.SetCursorPosition(random.Next(5, width-10), random.Next(5, height-10));  // Food
    Console.Write(food);
}

// Returns cursor/food position
int[] GetFoodLocation()
{
    int[] cursorPosition = new int[] {Console.GetCursorPosition().Left, Console.GetCursorPosition().Top};
    return cursorPosition;
}

// Check player position
void CheckPlayerPosition(int[] foodPosition)
{
    if (playerX + player.Length == foodPosition[0] && playerY == foodPosition[1]){
        player = "@@"+ player;
        playerX -= 2;
        SetPlayerPosition(playerX, playerY);
        NewFoodLocation();
    }
}
// Player position
void SetPlayerPosition(int x, int y){
    Console.SetCursorPosition(x, y);   // Player
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