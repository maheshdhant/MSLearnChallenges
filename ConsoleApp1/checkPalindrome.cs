string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

Console.WriteLine("Is it a palindrome?");
foreach (string word in words) 
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word){
    string reverseWord = "";
    for (int i = word.Length - 1; i >= 0; i--){
        reverseWord += word[i];
    }
    if (word == reverseWord) return true;
    else return false;
}