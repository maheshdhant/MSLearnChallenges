bool exit = false;
var rand = new Random();
int num1 = 5;
int num2 = 5;

do
{
    num1 = rand.Next(1, 11);
    num2 = num1 + rand.Next(1, 51);  //test condition in WATCH => num2/num1 > 5

} while (exit == false);  // set exit[bool]'s value to true to exit the debugging