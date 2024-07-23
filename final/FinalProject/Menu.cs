using System;

public class Menu
{
    private ProfileManager profileManager;
    private PlanManager planManager;

    public Menu()
    {
        profileManager = new ProfileManager();
        planManager = new PlanManager();
    }

    public void Start()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Create Profile");
            Console.WriteLine("2. Calculate BMI");
            Console.WriteLine("3. Create Exercise Plan");
            Console.WriteLine("4. Create Diet Plan");
            Console.WriteLine("5. Provide Feedback");
            Console.WriteLine("6. Save Profile");
            Console.WriteLine("7. Load Profile");
            Console.WriteLine("8. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    profileManager.CreateProfile();
                    break;
                case "2":
                    profileManager.CalculateBMI();
                    break;
                case "3":
                    planManager.CreateExercisePlan();
                    break;
                case "4":
                    planManager.CreateDietPlan();
                    break;
                case "5":
                    profileManager.ProvideFeedback();
                    break;
                case "6":
                    profileManager.SaveProfile();
                    break;
                case "7":
                    profileManager.LoadProfile();
                    break;
                case "8":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
