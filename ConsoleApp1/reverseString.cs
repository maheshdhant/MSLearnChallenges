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