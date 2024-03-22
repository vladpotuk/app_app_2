using System;

namespace LambdaExpressionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Func<int[], int> findMax = array =>
            {
                int max = array[0]; 

                foreach (int num in array)
                {
                    if (num > max)
                        max = num; 
                }

                return max;
            };

            
            int[] testArray = { 3, 7, 2, 9, 5 };
            Console.WriteLine($"Максимум в масиві: {findMax(testArray)}");
        }
    }
}
