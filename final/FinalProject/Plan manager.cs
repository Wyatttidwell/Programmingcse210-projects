using System;

public class PlanManager
{
    private ExercisePlan currentExercisePlan;
    private DietPlan currentDietPlan;

    public void CreateExercisePlan()
    {
        Console.WriteLine("Enter Exercise Plan Details:");
        // Replace with actual plan creation logic
        Console.WriteLine("Enter experience level (Beginner, Intermediate, Advanced):");
        string level = Console.ReadLine();
        switch (level)
        {
            case "Beginner":
                currentExercisePlan = new BeginnerExercisePlan();
                break;
            case "Intermediate":
                currentExercisePlan = new IntermediateExercisePlan();
                break;
            case "Advanced":
                currentExercisePlan = new AdvancedExercisePlan();
                break;
            default:
                Console.WriteLine("Invalid level.");
                return;
        }
        Console.WriteLine("Exercise Plan created successfully.");
    }

    public void CreateDietPlan()
    {
        Console.WriteLine("Enter Diet Plan Details:");
        Console.WriteLine("Enter diet type (Balanced, LowCarb):");
        string type = Console.ReadLine();
        switch (type)
        {
            case "Balanced":
                currentDietPlan = new BalancedDietPlan();
                break;
            case "LowCarb":
                currentDietPlan = new LowCarbDietPlan();
                break;
            default:
                Console.WriteLine("Invalid diet type.");
                return;
        }
        Console.WriteLine("Diet Plan created successfully.");
    }
}
