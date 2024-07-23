using System;
using System.Collections.Generic;

public abstract class DietPlan
{
    public string Name { get; set; }
    public Dictionary<string, int> NutrientMacros { get; set; }
    public int DailyCalories { get; set; }
}

public class BalancedDietPlan : DietPlan
{
    public BalancedDietPlan()
    {
        NutrientMacros = new Dictionary<string, int>
        {
            { "Carbs", 300 },
            { "Protein", 150 },
            { "Fats", 70 }
        };
        DailyCalories = 2500;
    }
}

public class LowCarbDietPlan : DietPlan
{
    public LowCarbDietPlan()
    {
        NutrientMacros = new Dictionary<string, int>
        {
            { "Carbs", 150 },
            { "Protein", 200 },
            { "Fats", 80 }
        };
        DailyCalories = 2200;
    }
}
