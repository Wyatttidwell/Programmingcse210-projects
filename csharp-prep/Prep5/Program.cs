using System;

class Program
{
    static void Main(string[] args) {
        DisplayWelcomeMessage();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);
    }
    static void DisplayWelcomeMessage(){
        Console.WriteLine("Beinvenido to my program!!!");
        }

    static string PromptUserName(){
        Console.Write("Your name is? = ");
        string name = Console.ReadLine();

        return name;
    }
    static int PromptUserNumber() {
        Console.Write("please enter a number ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number){
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square) {
        Console.WriteLine($"Fun fact {name}, your number but squared is {square}");
    }
}