using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Profile> profiles = new List<Profile>();
        ProfileManager profileManager = new ProfileManager(profiles);
        BMICalculator bmiCalculator = new BMICalculator(profiles);
        FeedbackProvider feedbackProvider = new FeedbackProvider();
        Saver Saver = new Saver();

        bool running = true;

        while (running)
        {
            Console.WriteLine("The menu");
            Console.WriteLine("1. Create a profile");
            Console.WriteLine("2. Calculate BMI");
            Console.WriteLine("3. Create a diet plan");
            Console.WriteLine("4. Create an exercise plan");
            Console.WriteLine("5. Give positive or negative reinforcement");
            Console.WriteLine("6. Inform on diet/exercise plan");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    profileManager.CreateProfile();
                    Saver.SaveProfiles(profiles);
                    break;
                case "2":
                    bmiCalculator.CalculateBMI();
                    break;
                case "5":
                    feedbackProvider.ProvideFeedback();
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
