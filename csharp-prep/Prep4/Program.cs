using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        int unumber=-1; 
        while (unumber !=0)
        {
            Console.Write("Would you like to add number to list (0 for no)");
            string answer = Console.ReadLine();
            unumber = int.Parse(answer);
            if (unumber !=0)
            {
                numbers.Add(unumber);
            }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The total sum is = {sum}");


            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");
            
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
                
    
        }
        Console.WriteLine($"The max is = {max}");
        }
    }
}