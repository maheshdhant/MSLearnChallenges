using Microsoft.VisualBasic;

string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);  // 0 represents starting index, 2 represents no. of elements to be cleared.
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Array.Resize(ref pallets, 6);
pallets[4] = "C11";
pallets[5] = "C12";
Console.WriteLine($"Resized array size: {pallets.Count()}");
foreach (var pallet in pallets){
    Console.WriteLine($"resized array elements: {pallet}");
}

Console.WriteLine("\n"+"Array elements after deletion:");
Array.Resize(ref pallets, 3); //resize is used to delete the array's elements
foreach (var pallet in pallets){
    Console.WriteLine($"-- {pallet}");
}
