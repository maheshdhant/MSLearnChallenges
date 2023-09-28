Random random = new Random();
string[] searchingIcons = {" |", " /", "--", " \\", " *"};
StartGame();
void StartGame(){
    
    int target = random.Next(1, 6);
    Console.WriteLine($"Target: {target}");

    int playersRoll = RollTheDice();

    WinOrLose(target, playersRoll);

    Console.WriteLine("Do you want to play again? (Enter Y for Yes | N for No)");
    string answer = Console.ReadLine();
    ContinuePlaying(answer);
}
void ContinuePlaying(string answer){
    if (answer.ToLower() == "y") StartGame();
    else if(answer.ToLower() =="n") return;
}

void WinOrLose(int target, int playersRoll){
    if(playersRoll>target) Console.WriteLine("Boom! You won!!!");
    else Console.WriteLine("Pyauu! You lost :(");
}

int RollTheDice(){
    Console.Write("Hit Enter to roll the dice:");
    Console.ReadLine();
    int playersRoll = random.Next(1,6);
    for (int j = 2; j > -1 ; j--)
    {
        foreach (string icon in searchingIcons)
        {
            //rolling countdown
            Console.Write($"\rRolling {icon} {j.ToString()}");
            Thread.Sleep(100);
        }
        
        Console.Write($"\r{new String(' ', Console.BufferWidth)}");
    }
    Console.WriteLine($"You rolled: {playersRoll}");
    return playersRoll;
}