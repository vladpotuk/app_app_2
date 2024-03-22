using System;
using System.Linq;

class Program
{
    
    static void Main(string[] args)
    {
        
        int[] numbers = { -5, 3, -2, 7, 0, -1, 8, -4, -5, -2, 3 };

        
        Func<int[], IEnumerable<int>> uniqueNegativeNumbers = arr => arr.Where(x => x < 0).Distinct();

        
        var uniqueNegatives = uniqueNegativeNumbers(numbers);
        Console.WriteLine("Унікальні, негативні числа у масиві:");
        foreach (var num in uniqueNegatives)
        {
            Console.WriteLine(num);
        }
    }
}
