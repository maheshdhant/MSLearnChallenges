string[] values = { "12.3", "45", "ABC", "11", "DEF" };
float valueHolder;
float total = 0.0f;
string message = "";
foreach (var item in values){
    if (float.TryParse(item, out valueHolder)){
        total += valueHolder;
    }
    else{
        message += item; 
    }
}
Console.WriteLine(total + "\n" + message);