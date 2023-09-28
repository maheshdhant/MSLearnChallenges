string sentence = "Hello! My name is Shyam Kumar Nath.";
string[] sentenceArray = sentence.Split(' ');
Console.WriteLine(sentenceArray.Length);
string reversedSentence = "";
for ( int i=0; i<sentenceArray.Length; i++){
    reversedSentence += ReverseWord(sentenceArray[i]) + " ";
}
string ReverseWord(string word){
    string reversedWord = "";
    for (int i = word.Length - 1; i >= 0; i--){
        reversedWord +=word[i];
    }
    return reversedWord;
}
Console.WriteLine(reversedSentence);