using System;

namespace RainbowColors
{
    
    class Program
    {
        static void Main(string[] args)
        {
          
            Func<string, string> getColorName = color =>
            {
                
                switch (color.ToLower())
                {
                    case "red":
                        return "Red";
                    case "orange":
                        return "Orange";
                    case "yellow":
                        return "Yellow";
                    case "green":
                        return "Green";
                    case "blue":
                        return "Blue";
                    case "indigo":
                        return "Indigo";
                    case "violet":
                        return "Violet";
                    default:
                        return "Unknown color";
                }
            };

            
            string color = "orange";
            string colorName = getColorName(color);
            Console.WriteLine($"Назва кольору для кольору {color}: {colorName}");

            color = "green";
            colorName = getColorName(color);
            Console.WriteLine($"Назва кольору для кольору {color}: {colorName}");

            color = "indigo"; 
            colorName = getColorName(color);
            Console.WriteLine($"Назва кольору для кольору {color}: {colorName}");
        }
    }
}
