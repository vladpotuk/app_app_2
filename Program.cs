using System;

class Program
{
    static void Main(string[] args)
    {
        Backpack backpack = new Backpack
        {
            Color = "Black",
            Brand = "Nike",
            Material = "Polyester",
            Weight = 0.5,
            Volume = 20
        };

        backpack.ItemAdded += (sender, e) =>
        {
            Console.WriteLine($"Item '{e.AddedItem.Name}' added to the backpack.");
        };

        try
        {
            backpack.AddItem(new Item("Water Bottle", 1.0));
            backpack.AddItem(new Item("Book", 2.0));
            backpack.AddItem(new Item("Laptop", 3.0));
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
