class Breathing : Activity
{
    protected override string GetDescription()
    {
        return "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void PerformActivity()
    {
        int time = 0;
        while (time < GetDuration())
        {
            Console.WriteLine("Breathe in...");
            Pause(3);
            Console.WriteLine("Breathe out...");
            Pause(5);
            time += 4;
        }
    }
}
