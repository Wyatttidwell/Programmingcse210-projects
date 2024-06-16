using System;

abstract class Activity
{
    private int _duration;

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void StartActivity()
    {
        StartMessage();
        SetDurationInput();
        Prepare();
        PerformActivity();
        EndMessage();
    }

    private void StartMessage()
    {
        Console.WriteLine($"Starting {GetType().Name}...");
        Console.WriteLine(GetDescription());
    }

    private void SetDurationInput()
    {
        Console.Write("Enter duration in seconds: ");
        SetDuration(int.Parse(Console.ReadLine()));
    }

    private void Prepare()
    {
        Console.WriteLine("Prepare to begin...");
        Pause(3);
    }

    protected abstract void PerformActivity();

    private void EndMessage()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {GetType().Name} for {GetDuration()} seconds.");
        Pause(3);
    }

    protected void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(GetSpinner(i) + " ");
            System.Threading.Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - GetSpinner(i).Length - 1, Console.CursorTop);
            Console.Write(" ");
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
        Console.WriteLine();
    }

    private string GetSpinner(int index)
    {
        string[] customSpinner = { "|", "/", "-", "\\" };
        return customSpinner[index % customSpinner.Length];
    }

    protected abstract string GetDescription();
}