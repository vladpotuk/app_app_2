using System;

namespace DelegateEventExample
{
    class Program
    {
        
        delegate bool CheckEvenDelegate(int number);

        static void Main(string[] args)
        {
            
            CheckEvenDelegate checkEven = num => num % 2 == 0;

            
            int testNumber = 10;
            Console.WriteLine($"Число {testNumber} парне: {checkEven(testNumber)}");

            testNumber = 7;
            Console.WriteLine($"Число {testNumber} парне: {checkEven(testNumber)}");
        }
    }
}
