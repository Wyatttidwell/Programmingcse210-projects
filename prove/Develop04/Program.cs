class Program
{
    static void Main(string[] args)
    {
        int input = -1;
        Console.WriteLine("Welcome to my mindfulness app!");

        while (input != 5)
        {
            Console.WriteLine("Enter a number to select one the following:");
            Console.WriteLine("1. A Breathing Activity");
            Console.WriteLine("2. A Reflection Activity");
            Console.WriteLine("3. A Listing Activity");
            Console.WriteLine("4. Explain menu options");
            Console.WriteLine("5. Exit");

            string userInput = Console.ReadLine();
            input = int.Parse(userInput);

            Activity activity = input switch
            {
                1 => new Breathing(),
                2 => new Reflection(),
                3 => new Listing(),
                4 => null,
                5 => null,
                _ => throw new ArgumentException("Invalid input.")
            };

            if (activity == null)
            {
                if (input == 4)
                {
                    Console.WriteLine("Option is a breathing exercise to help you relax it counts down the application will count out your inhales and exhales for the aloted time.");
                    Console.WriteLine("Option 2 is an exersice that gives out asks you about exeriences you had and how you have grown from them.");
                    Console.WriteLine("Option 3 displays questions to help you find positive aspects of your life list as many as possible in the time aloted..");
                    Console.WriteLine("Option 4 will display this explanation again.");
                    Console.WriteLine("Option 5 will exit the program.");
                }
                else if (input == 5)
                {
                    Console.WriteLine("Exiting...");
                }
            }
            else
            {
                activity.StartActivity();
            }
        }
    }
}
