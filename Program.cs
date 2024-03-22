using System;


namespace LambdaExpressionExample
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Func<int, int> cube = num => num * num * num;

           
            int testNumber = 3;
            Console.WriteLine($"Куб числа {testNumber} дорівнює: {cube(testNumber)}");

            testNumber = 5;
            Console.WriteLine($"Куб числа {testNumber} дорівнює: {cube(testNumber)}");
        }
    }
}
