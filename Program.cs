using System;

namespace LambdaExpressionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> findMin = array =>
            {
                int min = array[0]; 

                foreach (int num in array)
                {
                    if (num < min)
                        min = num; 
                }

                return min;
            };

            int[] testArray = { 3, 7, 2, 9, 5 };
            Console.WriteLine($"Мінімум в масиві: {findMin(testArray)}");
        }
    }
}
