using System;
using Newtonsoft.Json;

public class ChecklistGoal : Goal
{
    private int targetNumber;
    private int currentNumber;
    private int bonusPoints;

    [JsonConstructor]
    public ChecklistGoal(string description, int targetNumber) : base(description, 50)
    {
        this.targetNumber = targetNumber;
        this.currentNumber = 0;
        this.bonusPoints = 500;
    }

    public override int RecordEvent()
    {
        if (currentNumber < targetNumber)
        {
            currentNumber++;
            int points = GetPoints();
            if (currentNumber == targetNumber)
            {
                points += bonusPoints;
            }
            return points;
        }
        return 0;
    }

    public override bool Complete() => currentNumber >= targetNumber;

    public override string ToString() => $"[ChecklistGoal] {GetDescription()} - Completed {currentNumber}/{targetNumber} times";
}
