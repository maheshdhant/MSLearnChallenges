double total = 0;
double minimumSpend = 30.00;

double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

Console.WriteLine($"Total: ${total}");

double GetDiscountedPrice(int itemIndex)
{
    double total = items[itemIndex] - items[itemIndex] * discounts[itemIndex];
    return total;
}

bool TotalMeetsMinimum()
{
    // Check if the total meets the minimum
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{   
    // Format the double so only 2 decimal places are displayed
    return input.ToString().Substring(0,5);
}

// Console.WriteLine("Discounted price: " + FormatDecimal(GetDiscountedPrice(2)));

for (int i = 0; i<items.Length; i++){
    total += GetDiscountedPrice(i);
}
Console.WriteLine(total.ToString().Substring(0, 5));
Console.WriteLine("Total meets minimum?: " + TotalMeetsMinimum());