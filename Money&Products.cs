using System;

public class Money
{
    private int _whole;
    private int _cents;
    public string Currency { get; private set; }

    public int Whole
    {
        get => _whole;
        private set
        {
            if (value < 0)
                throw new ArgumentException("The integer part cannot be negative.");
            else _whole = value;
        }
    }

    public int Cents
    {
        get => _cents;
        private set
        {
            if (value < 0 || value > 99)
                throw new ArgumentException("The coins must be between 0–99.");
            else _cents = value;
        }
    }

    public Money(int whole, int cents, string currency)
    {
        Currency = currency;
        SetAmount(whole, cents);
    }

    public void SetAmount(int whole, int cents)
    {
        if (whole < 0 || cents < 0)
            throw new ArgumentException("The amount cannot be negative.");

        Whole = whole + cents / 100;
        Cents = cents % 100;
    }

    public void Display()
    {
        Console.WriteLine($"{Whole}.{Cents:D2} {Currency}");
    }

    public double ToDouble() => Whole + Cents / 100.0;

    public override string ToString() => $"{Whole}.{Cents:D2} {Currency}";

    
    public override bool Equals(object obj)
    {
        if (obj is Money other)
            return Whole == other.Whole && Cents == other.Cents && Currency == other.Currency;
        return false;
    }

    public override int GetHashCode() => HashCode.Combine(Whole, Cents, Currency);

    public static bool operator >(Money a, Money b) => a.ToDouble() > b.ToDouble();
    public static bool operator <(Money a, Money b) => a.ToDouble() < b.ToDouble();
}

public class Product
{
    public string Name { get; set; }
    public Money Price { get; private set; }

    public Product(string name, Money price)
    {
        Name = name;
        Price = price;
    }

    public void IncreasePrice(int whole, int cents)
    {
        double total = Price.ToDouble() + (whole + cents / 100.0);
        int newWhole = (int)total;
        int newCents = (int)Math.Round((total - newWhole) * 100);
        Price = new Money(newWhole, newCents, Price.Currency);
    }

    public void DecreasePrice(int whole, int cents)
    {
        double total = Price.ToDouble() - (whole + cents / 100.0);
        if (total < 0) total = 0;
        int newWhole = (int)total;
        int newCents = (int)Math.Round((total - newWhole) * 100);
        Price = new Money(newWhole, newCents, Price.Currency);
    }

    public void Show()
    {
        Console.WriteLine($"Product: {Name}, Price: {Price}");
    }
}