using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade Percentage?");
        string userpercentage = Console.ReadLine();
        int x = int.Parse(userpercentage);

        string gradeletter = "";

        if(x >= 90)
        gradeletter = "A";
        else if (x >= 80)
        gradeletter = "B";
        else if (x >= 70)
        gradeletter = "C";
        else if (x >= 60)
        gradeletter = "D";
        else 
        gradeletter = "F";
    Console.WriteLine($"Your Grade is {gradeletter}");
    if (x >= 70)
    Console.WriteLine("congrats you passed");
    else
    Console.WriteLine("Looks like you failed, ByteConverter luck next time");
    }
}