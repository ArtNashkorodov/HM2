using System;


public abstract class MusicalInstrument
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public string History { get; private set; }

    protected MusicalInstrument(string name, string description, string history)
    {
        Name = name;
        Description = description;
        History = history;
    }

    public virtual void Show() => Console.WriteLine($"Musical Instrument: {Name}");
    public virtual void Desc() => Console.WriteLine($"Description: {Description}");
    public virtual void HistoryInfo() => Console.WriteLine($"History: {History}");
}

public class Violin : MusicalInstrument
{
    public Violin() : base("Violin", "A bowed string instrument.", "Appeared in the 16th century in Italy.") { }

    public override void Show() => Console.WriteLine("Violin");
}

public class Trombone : MusicalInstrument
{
    public Trombone() : base("Trombone", "Brass wind instrument.", "Common since the 15th century in Europe.") { }

    public override void Show() => Console.WriteLine("Trombone");
}

public class Ukulele : MusicalInstrument
{
    public Ukulele() : base("Ukulele", "A small ukulele.", "Originated in Portugal, popularized in Hawaii.") { }

    public override void Show() => Console.WriteLine("Ukulele");
}

public class Cello : MusicalInstrument
{
    public Cello() : base("Cello", "A lower register string instrument.", "Appeared in the 16th century.") { }

    public override void Show() => Console.WriteLine("Cello");
}