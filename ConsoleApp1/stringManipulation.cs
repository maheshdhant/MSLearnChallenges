using System.ComponentModel.DataAnnotations;

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