using System;

namespace DelegateEventExample
{
    class Program
    {
        
        delegate int SquareDelegate(int number);

        static void Main(string[] args)
        {
            
            SquareDelegate square = num => num * num;

            
            Console.Write("Введіть число: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine($"Квадрат числа {userNumber} дорівнює: {square(userNumber)}");
        }
    }
}
