/////////////////// USE OF IndexOf(), Length, Substring() ////////////////////////////////

string message = "See what's (inside the parentheses).";
var firstIndex = message.IndexOf('(');
var secondIndex = message.IndexOf(')');
Console.WriteLine($"The index of '(' is {firstIndex} \nThe index of ')' is {secondIndex}");
firstIndex += 1;
int length = secondIndex - firstIndex;
string miniMessage = message.Substring(firstIndex, length);
Console.WriteLine(miniMessage);

string message2 = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message2.IndexOf(openSpan);
int closingPosition = message2.IndexOf(closeSpan);
Console.WriteLine(openingPosition + " " + closingPosition);
openingPosition += openSpan.Length;
int length2 = closingPosition - openingPosition;
Console.WriteLine(message2.Substring(openingPosition, length2));
Console.WriteLine();

/////////////////////// USE OF LastIndexOf(), IndexOfAny() //////////////////////////////////

string thirdMessage = "(What if) I am (only interested) in the last (set of parentheses)?";

while(true){
    int openingPosition3 = thirdMessage.IndexOf('(');
    if (openingPosition3 == -1) break;
    openingPosition3 += 1;
    
    int closingPosition3 = thirdMessage.IndexOf(')');
    int length3 = closingPosition3 - openingPosition3;

    Console.WriteLine(thirdMessage.Substring(openingPosition3, length3));
    thirdMessage = thirdMessage.Substring(closingPosition3 + 1);
}
Console.WriteLine();

string fourthMessage = "Help (find) the {opening symbols})";
Console.WriteLine("Last index of ')': " + fourthMessage.LastIndexOf(')'));
Console.WriteLine($"Searching THIS Message: {fourthMessage}");
char[] openSymbols = { '[', '{', '(' };

int openPosition = fourthMessage.IndexOfAny(openSymbols);
Console.WriteLine(fourthMessage.Substring(openPosition));
openPosition += 1;

openPosition = fourthMessage.IndexOfAny(openSymbols, openPosition) ;
Console.WriteLine(fourthMessage.Substring(openPosition));