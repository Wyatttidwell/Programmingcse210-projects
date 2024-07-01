using System;

public abstract class Goal
{
    private string description;
    private int points;

    public Goal(string description, int points)
    {
        this.description = description;
        this.points = points;
    }

    public string GetDescription() => description;
    public int GetPoints() => points;

    public abstract int RecordEvent();
    public abstract bool Complete();
}
