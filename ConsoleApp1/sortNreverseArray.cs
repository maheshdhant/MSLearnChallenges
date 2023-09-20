string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Array.Reverse(pallets);
Console.WriteLine("Reversed array is:\"\n\"");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}