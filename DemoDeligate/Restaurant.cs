using System;

public class Restaurant
{
    // Step 1: Define the delegate
    public delegate void CookDelegate(string dish);

    // Step 2: Define methods with matching signatures
    public static void ItalianChef(string dish)
    {
        Console.WriteLine($"Italian Chef is cooking {dish} 🍝");
    }

    public static void ChineseChef(string dish)
    {
        Console.WriteLine($"Chinese Chef is cooking {dish} 🍜");
    }

    public static void Main()
    {
        // Step 3: Use the delegate to call different methods
        CookDelegate cook;

        cook = ItalianChef;
        cook("Pasta");  // Calls ItalianChef

        cook = ChineseChef;
        cook("Noodles"); // Calls ChineseChef
    }
}