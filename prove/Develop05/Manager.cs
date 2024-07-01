using System;

public class GoalManager
{
    private Goal[] goals;
    private int goalCount;
    private int totalPoints;

    public GoalManager()
    {
        goals = new Goal[100];
        goalCount = 0;
        totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        if (goalCount < goals.Length)
        {
            goals[goalCount++] = goal;
        }
    }

    public void RecordProgress(int index)
    {
        if (index >= 0 && index < goalCount)
        {
            Goal goal = goals[index];
            totalPoints += goal.RecordEvent();
            Console.WriteLine($"Progress recorded for goal: {goal.GetDescription()}");
            Console.WriteLine($"Current total points: {totalPoints}");
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < goalCount; i++)
        {
            Console.WriteLine($"{i}: {goals[i]}");
        }
        Console.WriteLine($"Total Points: {totalPoints}");
    }

    public Goal[] GetGoals() => goals;
    public int GetGoalCount() => goalCount;
    public int GetTotalPoints() => totalPoints;

    public void SetGoals(Goal[] loadedGoals, int loadedGoalCount, int loadedTotalPoints)
    {
        goals = loadedGoals;
        goalCount = loadedGoalCount;
        totalPoints = loadedTotalPoints;
    }
}
