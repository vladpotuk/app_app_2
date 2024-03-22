using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        int[] numbers = { 14, 21, 30, 35, 42, 49, 56, 63, 70 };

        
        Func<int[], int> countMultiplesOfSeven = arr => arr.Count(x => x % 7 == 0);

        
        int count = countMultiplesOfSeven(numbers);
        Console.WriteLine($"Кількість чисел у масиві, кратних семи: {count}");
    }
}
