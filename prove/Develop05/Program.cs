using System;

class Program
{
    static GoalManager goalManager = new GoalManager();

    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Welcome to the Goal Application");
            Console.WriteLine("Press 1: Add Simple Goal");
            Console.WriteLine("Press 2: Add Eternal Goal");
            Console.WriteLine("Press 3: Checklist Goal");
            Console.WriteLine("Press 4: Record Progress");
            Console.WriteLine("Press 5: Display Goals");
            Console.WriteLine("Press 6: Save Goals");
            Console.WriteLine("Press 7: Load Goals");
            Console.WriteLine("Press 8: Explain menu options");
            Console.WriteLine("Press 9: Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddSimpleGoal();
                    break;
                case "2":
                    AddEternalGoal();
                    break;
                case "3":
                    AddChecklistGoal();
                    break;
                case "4":
                    RecordProgress();
                    break;
                case "5":
                    goalManager.DisplayGoals();
                    break;
                case "6":
                    SaveGoals();
                    break;
                case "7":
                    LoadGoals();
                    break;
                case "8":
                    
                    Console.WriteLine("Adding a simple goal is a one time goal and once it is complete you will recive points.");
                    Console.WriteLine("Adding an eternal goal and can be completed more than once. ");
                    Console.WriteLine("Adding a checklist goal will give you a goal that you can complete a set number of times for a bonus reward.");
                    Console.WriteLine("Recording progress will allowing to enter the Index of a goal you have completed and will give you points accordingly");
                    Console.WriteLine("Display goal will show you all currently loaded goals and thier current progress.");
                    Console.WriteLine("Save goals will save your goals an their state of completion to a file");
                    Console.WriteLine("Load goals will load goals and thier progress from a file.");
                    Console.WriteLine("Exit will terminate the program (be careful as unsaved progress will be deleted)");
                    break;
                case "9":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void AddSimpleGoal()
    {
        Console.Write("Please enter a description for a simple goal: ");
        string description = Console.ReadLine();
        goalManager.AddGoal(new SimpleGoal(description));
    }

    static void AddEternalGoal()
    {
        Console.Write("Please enter a description for an eternal goal: ");
        string description = Console.ReadLine();
        goalManager.AddGoal(new EternalGoal(description));
    }

    static void AddChecklistGoal()
    {
        Console.Write("Please enter a description for a checklist goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter the number of time you would like to repeat this goal: ");
        int target = int.Parse(Console.ReadLine());
        goalManager.AddGoal(new ChecklistGoal(description, target));
    }

    static void RecordProgress()
    {
        goalManager.DisplayGoals();
        Console.Write("Enter the index of the goal that you would like to mark your progress in: ");
        if (int.TryParse(Console.ReadLine(), out int index))
        {
            goalManager.RecordProgress(index);
        }
        else
        {
            Console.WriteLine("Please enter the number of chosen index. (Hint: The first index with start as a zero.)");
        }
    }

    static void SaveGoals()
    {
        Console.Write("Enter file name to save your goals: ");
        string filePath = Console.ReadLine();
        GoalSerializer.SaveGoals(filePath, goalManager.GetGoals(), goalManager.GetGoalCount(), goalManager.GetTotalPoints());
    }

    static void LoadGoals()
    {
        Console.Write("Enter a file name: ");
        string filePath = Console.ReadLine();
        var (goals, goalCount, totalPoints) = GoalSerializer.LoadGoals(filePath);
        goalManager.SetGoals(goals, goalCount, totalPoints);
    }
}
