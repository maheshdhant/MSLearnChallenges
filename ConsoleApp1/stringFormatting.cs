int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");

Console.WriteLine($"   Shares: {productShares:N3} Product");//shows 3digits after decimal

Console.WriteLine($"     Sub Total: {subtotal:C}");       //Adds currency symbol

Console.WriteLine($"           Tax: {taxPercentage:P2}"); //Changes to percentage with 2digits after decimal

Console.WriteLine($"     Total Billed: {total:C}");

//Output:

// Invoice Number: 1201
//    Shares: 25.457 Product
//      Sub Total: $2,750.00
//            Tax: 15.83%
//      Total Billed: $3,185.19

////////////////////////////String padding/////////////////////////////

string input = "Pad this";
Console.WriteLine(input.PadLeft(12)); //Pads left side of input with spaces
Console.WriteLine(input.PadRight(12)); //Pads right side of input with spaces

Console.WriteLine(input.PadLeft(12, '-')); //Pads left side of input with '-'
Console.WriteLine(input.PadRight(12, '-')); //Pads right side of input with '-'

///////////////////////////   string.Format() method  /////////////////

string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);