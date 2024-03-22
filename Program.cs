using System;

namespace LambdaExpressionExample
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Func<DateTime, bool> isProgrammerDay = date => date.DayOfYear == 256;

            
            DateTime testDate1 = new DateTime(2024, 9, 12); 
            Console.WriteLine($"Дата {testDate1.ToShortDateString()} - день програміста: {isProgrammerDay(testDate1)}");

            DateTime testDate2 = new DateTime(2024, 9, 13); 
            Console.WriteLine($"Дата {testDate2.ToShortDateString()} - день програміста: {isProgrammerDay(testDate2)}");
        }
    }
}
