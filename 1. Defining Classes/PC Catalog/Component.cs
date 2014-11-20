using System;

class Component
{
    public Component(string name, double price, string details)
    {
        this.Name = name;
        this.Price = price;
        this.Details = details;
    }
    public Component(string name, double price)
        : this(name, price, null)
    {
    }
    private string name;
    private double price;
    private string details;

    public string Name
    {
        get { return name; }
        set
        {
            if (String.IsNullOrEmpty(value)) { throw new ArgumentException("The value cannot be empty", "Name"); }
            name = value;
        }
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value < 0) { throw new ArgumentException("The value can't be a negative number.", "Price"); }
            price = value;
        }
    }

    public string Details
    {
        get { return details; }
        set
        {
            if (value != null && value == "") { throw new ArgumentException("The value cannot be empty", "Details"); }
            details = value;
        }
    }


}