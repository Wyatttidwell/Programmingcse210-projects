using System;
using System.Collections.Generic;

public abstract class ExercisePlan
{
    public string Name { get; set; }
    public List<Exercise> Exercises { get; set; }
}

public class BeginnerExercisePlan : ExercisePlan
{
    public BeginnerExercisePlan()
    {
        Exercises = new List<Exercise>
        {
            new Exercise("Push-ups", "3 sets of 10 reps"),
            new Exercise("Bodyweight Squats", "3 sets of 15 reps")
        };
    }
}

public class IntermediateExercisePlan : ExercisePlan
{
    public IntermediateExercisePlan()
    {
        Exercises = new List<Exercise>
        {
            new Exercise("Bench Press", "4 sets of 8 reps"),
            new Exercise("Deadlift", "4 sets of 6 reps")
        };
    }
}

public class AdvancedExercisePlan : ExercisePlan
{
    public AdvancedExercisePlan()
    {
        Exercises = new List<Exercise>
        {
            new Exercise("Squat", "5 sets of 5 reps"),
            new Exercise("Overhead Press", "5 sets of 5 reps")
        };
    }
}
