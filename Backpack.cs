using System;
using System.Collections.Generic;

public class Backpack
{
    public string Color { get; set; }
    public string Brand { get; set; }
    public string Material { get; set; }
    public double Weight { get; set; }
    public double Volume { get; set; }
    public List<Item> Contents { get; set; } = new List<Item>();

    public delegate void ItemAddedEventHandler(object sender, ItemAddedEventArgs e);
    public event ItemAddedEventHandler ItemAdded;

    public void AddItem(Item item)
    {
        if (CalculateOccupiedVolume() + item.Volume > Volume)
        {
            throw new InvalidOperationException("Cannot add item. Backpack volume exceeded.");
        }

        Contents.Add(item);
        OnItemAdded(new ItemAddedEventArgs(item));
    }

    protected virtual void OnItemAdded(ItemAddedEventArgs e)
    {
        ItemAdded?.Invoke(this, e);
    }

    private double CalculateOccupiedVolume()
    {
        double occupiedVolume = 0;
        foreach (var item in Contents)
        {
            occupiedVolume += item.Volume;
        }
        return occupiedVolume;
    }
}

public class Item
{
    public string Name { get; set; }
    public double Volume { get; set; }

    public Item(string name, double volume)
    {
        Name = name;
        Volume = volume;
    }
}

public class ItemAddedEventArgs : EventArgs
{
    public Item AddedItem { get; }

    public ItemAddedEventArgs(Item item)
    {
        AddedItem = item;
    }
}
