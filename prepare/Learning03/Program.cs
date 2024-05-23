
using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions  first = new Fractions();

        Console.WriteLine(first.getFraction());
        Console.WriteLine(first.getDecimal());

        Fractions second = new Fractions(6);

        Console.WriteLine(second.getFraction());
        Console.WriteLine(second.getDecimal());

        Fractions third = new Fractions(2, 6);

        Console.WriteLine(third.getFraction());
        Console.WriteLine(third.getDecimal());

        Fractions forth = new Fractions(3, 5);

        Console.WriteLine(forth.getFraction());
        Console.WriteLine(forth.getDecimal());
    }
}
