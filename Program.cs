class Program
{
    static void Main()
    {
        Console.WriteLine("Money&Products");

        Money price = new Money(125, 99, "usd");
        Product apple = new Product("Grapes", price);
        apple.Show();
        apple.IncreasePrice(1, 50);
        apple.Show();
        apple.DecreasePrice(0, 80);
        apple.Show();


        Console.WriteLine("\nMusic");
        List<MusicalInstrument> orchestra = new List<MusicalInstrument>
        {
            new Violin(),
            new Trombone(),
            new Ukulele(),
            new Cello()
        };

        foreach (var instrument in orchestra)
        {
            instrument.Show();
            instrument.Desc();
            instrument.HistoryInfo();
            Console.WriteLine();
        }


        Console.WriteLine("Decimal Number");
        DecimalNumber num = new DecimalNumber(2907);
        Console.WriteLine(num);
        Console.WriteLine($"Binary: {num.ToBinary()}");
        Console.WriteLine($"Octal: {num.ToOctal()}");
        Console.WriteLine($"Hex: {num.ToHex()}");

    }
}