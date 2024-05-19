using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int x = -1;
        List<string> entrylist = new List<string>(); 
        Console.WriteLine("Welcome to the journal This is a simple appliction written by Wyatt Tidwell");
        Console.WriteLine("Bellow are a series of options");
        while (x != 0)
        {
            Console.WriteLine("Enter a number to select the following");
            Console.WriteLine("1. Add new entry.");
            Console.WriteLine("2. Display.");
            Console.WriteLine("3. Save.");
            Console.WriteLine("4. Load.");
             Console.WriteLine("5. Explain menu options.");
            Console.WriteLine("6. Exit.");

            string userInput = Console.ReadLine();
            x = int.Parse(userInput);
            
            switch (x)
            {
                case 1:
                    Console.WriteLine("Option 1 selected: Add new entry.");
                    journal.NewEntry();
                    break;
                case 2:
                    Console.WriteLine("Option 2 selected: Display.");
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.WriteLine("Option 3 selected: Save.");
                    Console.WriteLine("Enter filename to save:");
                    string save = Console.ReadLine();
                    journal.Save(save);
                    break;
                case 4:
                    Console.WriteLine("Option 4 selected: Load.");
                    journal.Load();
                    break;
                case 6:
                    Console.WriteLine("Exiting...");
                    break;
                case 5:
                //I added another option that the user can select to more fully understand what the program does
                        Console.WriteLine("Option 1 will present you with a converationall prompt that you may repond to, when you are finished typing press enter.");
                        Console.WriteLine("Option 2 will diplay the entrys you have currently loaded/Entered.");
                        Console.WriteLine("Option 3 will save the entries you have currently loaded to a file.");
                        Console.WriteLine("Option 4 will load entries from a file you have entered.");
                        Console.WriteLine("Option 5 will display this explaination again.");
                        Console.WriteLine("Option 6 will Exit the program.");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }
}
