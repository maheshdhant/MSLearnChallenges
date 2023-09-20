string value = "helloworld123";
char[] valueArray = value.ToCharArray();
foreach (var letter in valueArray){
    Console.WriteLine(letter);
}
//reverse the elements inside valueArray
Array.Reverse(valueArray);
foreach (var letter in valueArray){
    Console.WriteLine(letter);
}

string valueResult = new string(valueArray);
Console.WriteLine($"Original word: {value} \nNew word: {valueResult}");

string valueResult2 = string.Join(",", valueArray);
Console.WriteLine($"Original word: {value} \nNew word 2: {valueResult2}");

string[] items = valueResult2.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}

string pangram = "The quick brown fox jumps over the lazy dog";
char[] pangramArray = pangram.ToCharArray();                            // Turned all alphabets to array
Array.Reverse(pangramArray);                                            // Reversed that array 
string reversedPangram = string.Join("", pangramArray);                 // Joined reversed alphabet to make words and made a sentence(string)
Console.Clear();                             
Console.WriteLine(reversedPangram); 
string[] reversedPangramArray = reversedPangram.Split(" ");             // Turned sentence into array of reversed words
Array.Reverse(reversedPangramArray);                                    // Reversed that array to put words in order
string orderedReversedPangram = string.Join(" ", reversedPangramArray); // Joined the words to make an ordered sentence
Console.WriteLine("The reversed words are: " + orderedReversedPangram); // And hence the result, tantadaaaaan!