using System;
using Newtonsoft.Json;

public class SimpleGoal : Goal
{
    private bool completed;
    public SimpleGoal(string description) : base(description, 1000)
    {
        completed = false;
    }

    public override int RecordEvent()
    {
        if (!completed)
        {
            completed = true;
            return GetPoints();
        }
        return 0;
    }

    public override bool Complete() => completed;

    public override string ToString() => $"[SimpleGoal] {GetDescription()} - {(completed ? "Completed" : "Incomplete")}";
}
