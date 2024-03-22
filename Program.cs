using System;

namespace DelegateEventExample
{
    class Program
    {
  
        delegate bool CheckEvenDelegate(int number);

        static void Main(string[] args)
        {
          
            CheckEvenDelegate checkEven = num => num % 2 == 0;

           
            while (true)
            {
                
                Console.Write("Введіть число (або 'q', щоб вийти): ");
                string input = Console.ReadLine();

            
                if (input.ToLower() == "q")
                    break;

              
                if (int.TryParse(input, out int testNumber))
                {
                   
                    Console.WriteLine($"Число {testNumber} парне: {checkEven(testNumber)}");
                }
                else
                {
                    Console.WriteLine("Введено некоректне число. Будь ласка, спробуйте знову.");
                }
            }
        }
    }
}
