using System;
using System.Linq;

namespace LambdaExpressionExample
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Func<int[], int[]> findOddNumbers = array => array.Where(num => num % 2 != 0).ToArray();

            int[] testArray = { 3, 7, 2, 9, 5, 6, 8 };
            int[] oddNumbers = findOddNumbers(testArray);

            Console.WriteLine("Непарні числа в масиві:");
            foreach (int num in oddNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
