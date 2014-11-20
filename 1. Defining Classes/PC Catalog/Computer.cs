using System;
using System.Collections.Generic;

class Computer
{
    public Computer(string name, List<Component> components)
    {
        this.Name = name;
        this.Components = components;
        foreach (Component component in Components)
        {
            Price += component.Price;
        }
    }
    private string name;
    private List<Component> components = new List<Component>();

    public string Name
    {
        get { return name; }
        set
        {
            if (String.IsNullOrEmpty(value)) { throw new ArgumentException("The value cannot be empty", "Name"); }
            name = value;
        }
    }

    public List<Component> Components
    {
        get { return components; }
        set
        {
            if (value == null) { throw new ArgumentNullException("Value cannot be null", "Components"); }
            components = value;
        }
    }

    public double Price = 0;

    public void PrintInfo()
    {
        string info = "PC Info:\nName: " + Name + "\nPrice:" + Price;
        info += "\n----------\nComponentsDetails:\n";
        foreach (Component component in Components)
        {
            info += "\n" + component.Name + " -> " + String.Format("{0:C}", component.Price);
        }
        Console.WriteLine(info);
    }
}