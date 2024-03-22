using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        int[] numbers = { -5, 3, -2, 7, 0, -1, 8, -4 };

       
        Func<int[], int> countPositiveNumbers = arr => arr.Count(x => x > 0);

       
        int count = countPositiveNumbers(numbers);
        Console.WriteLine($"Кількість позитивних чисел у масиві: {count}");
    }
}
