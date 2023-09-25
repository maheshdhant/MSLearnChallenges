using System.ComponentModel;

void RandomNumberGenerator(){
    Random random = new Random();
    int num = random.Next(1,100);
    Console.Write(num);
    Console.WriteLine();
}
Console.WriteLine("generating random number");
RandomNumberGenerator();