using System.ComponentModel;

void RandomNumberGenerator(){
    Random random = new Random();
    int num = random.Next(1,100);
    Console.Write(num);
    Console.WriteLine();
}
Console.WriteLine("generating random number");
RandomNumberGenerator();

/////////Using method to structure code.//////////
string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input) 
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength(); 
    ValidateZeroes(); 
    ValidateRange();

    if (validLength && validZeroes && validRange) 
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    } 
    else 
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}

void ValidateLength() 
{
    validLength = address.Length == 4;
};

void ValidateZeroes() 
{
    foreach (string number in address) 
    {
        if (number.Length > 1 && number.StartsWith("0")) 
        {
            validZeroes = false;
            return;
        }
    }

    validZeroes = true;
}

void ValidateRange() 
{
    foreach (string number in address) 
    {
        if (int.Parse(number) > 255) 
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}

//////////////////////fortune teller function/////////////////

Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

fortuneTeller(luck);
luck = random.Next(100);
fortuneTeller(luck);

void fortuneTeller(int luck){

    Console.WriteLine("\n"+ luck);
    Console.WriteLine("A fortune teller whispers the following words:");
    string[] fortune = luck > 75 ? good : (luck < 25 ? bad : neutral);
    for (int i = 0; i < 4; i++) 
        {
            Console.Write($"{text[i]} {fortune[i]} ");
        }
}

