using System;
using Newtonsoft.Json;
public class EternalGoal : Goal
{
    [JsonConstructor]
    public EternalGoal(string description) : base(description, 100)
    {
    }

    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override bool Complete() => false;

    public override string ToString() => $"[EternalGoal] {GetDescription()} - Eternal";
}
