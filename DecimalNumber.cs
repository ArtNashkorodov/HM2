using System;

public struct DecimalNumber
{
    public int Number { get; private set; }

    public DecimalNumber(int number)
    {
        Number = number;
    }

    public string ToBinary() => Convert.ToString(Number, 2);
    public string ToOctal() => Convert.ToString(Number, 8);
    public string ToHex() => Convert.ToString(Number, 16).ToUpper();

    public override string ToString() => $"Decimal number: {Number}";
}
