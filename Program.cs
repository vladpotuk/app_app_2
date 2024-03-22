using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { -5, 3, -2, 7, 0, -1, 8, -4, -5, -2, 3 };

       
        Func<int[], IEnumerable<int>> uniqueNegativeNumbers = arr =>
        {
            List<int> uniqueNegatives = new List<int>();

            foreach (int num in arr)
            {
                if (num < 0 && !uniqueNegatives.Contains(num))
                {
                    uniqueNegatives.Add(num);
                }
            }

            return uniqueNegatives;
        };

        
        var uniqueNegatives = uniqueNegativeNumbers(numbers);

        
        Console.WriteLine("Унікальні, негативні числа у масиві:");
        foreach (var num in uniqueNegatives)
        {
            Console.WriteLine(num);
        }
    }
}
