using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Nameifier");

        Console.Write("What is your First Name? ");
        
        string name1 = Console.ReadLine();
        Console.WriteLine("Thank you");
        Console.Write("What is your Last Name? ");
        string name2 = Console.ReadLine();
        Console.WriteLine("Thank you");
        Console.WriteLine($"Your name is {name2}, {name1} {name2}");
    }
}