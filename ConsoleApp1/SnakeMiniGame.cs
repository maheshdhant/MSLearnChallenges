using System;
using System.Drawing;
Console.CursorVisible = false;
Random random = new Random();

// Terminal size
var width = Console.WindowWidth;
var height = Console.WindowHeight;

// Player
var player = "@@@@@@";
int playerX = 0;
int playerY = 0;

// Food
var food = "*";
int foodX = 0;
int foodY = 0;

// Set terminal
bool terminalOn = true;

// Start game
StartGame();
while(terminalOn){
    if (Console.WindowHeight != height || Console.WindowWidth != width){
        TerminalTerminateGame();
    }
    
    Move();
    SetPlayerPosition(playerX, playerY);

    bool hasEatenFood = CheckPlayerPosition(); // Checks if food is eaten
    if (hasEatenFood)       
    {
        player = "@@"+ player;
        playerX -= 2;
        SetPlayerPosition(playerX, playerY);
        NewFoodLocation();
    }
}

void NewFoodLocation()
{
    foodX = random.Next(10, width-10);
    foodY = random.Next(5, height-10);
    Console.SetCursorPosition(foodX, foodY);  // Food
    Console.Write(food);
}

// Check player position
bool CheckPlayerPosition()
{
    bool checkPlayerPosition = false;
    for (int i=0; i<player.Length; i++){

       if (playerX + i == foodX + 1 && playerY == foodY){
            checkPlayerPosition = true;
       }
    }
    if (checkPlayerPosition) return true;
    else return false;
}

// Player position
void SetPlayerPosition(int x, int y){
    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

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
    // Player last position
    int lastX = playerX;
    int lastY = playerY;

    // Move
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
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++) 
    {
        Console.Write(" ");
    }
}

void StartGame(){
    Console.Clear();
    NewFoodLocation();
    SetPlayerPosition(playerX, playerY);
}