using System;
using System.Formats.Asn1;

class Program

{static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        int Numberguess = randomGenerator.Next(1, 100);

        int guess = 1;

        while (guess != Numberguess)
        {
            Console.Write("Try to guess the number. "); 

            guess = int.Parse(Console.ReadLine());
            
            if (Numberguess > guess)
            {
                Console.WriteLine("The magic number is higher than your number.");
            }


            else if (Numberguess < guess) 
            {
                Console.WriteLine("The magic number is lower than your number.");
            }

            else 
            {
                Console.WriteLine("you guessed it!");
            }
        }
    
    
    }
}