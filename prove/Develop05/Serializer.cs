using System;
using System.IO;
using Newtonsoft.Json;

public static class GoalSerializer
{
    public static void SaveGoals(string fileName, Goal[] goals, int goalCount, int totalPoints)
    {
        var data = new
        {
            Goals = goals,
            GoalCount = goalCount,
            TotalPoints = totalPoints
        };

        var settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Auto,
            Formatting = Formatting.Indented
        };

        string jsonString = JsonConvert.SerializeObject(data, settings);
        File.WriteAllText(fileName, jsonString);
        Console.WriteLine($"Goals saved to {fileName}");
    }

    public static (Goal[], int, int) LoadGoals(string fileName)
    {
        string jsonString = File.ReadAllText(fileName);

        var settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Auto
        };

        var data = JsonConvert.DeserializeObject<dynamic>(jsonString, settings);
        Goal[] goals = JsonConvert.DeserializeObject<Goal[]>(data.Goals.ToString(), settings);
        int goalCount = (int)data.GoalCount;
        int totalPoints = (int)data.TotalPoints;

        Console.WriteLine($"Your goals from {fileName}:");
        return (goals, goalCount, totalPoints);
    }
}
