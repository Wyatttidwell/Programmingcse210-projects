class Listing : Activity
{
    private static readonly string[] Prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What are three things you're grateful for today, and why?",
        "How have you grown as a person in the last year?",
        "What are your core values, and how do they influence your daily decisions?",
        "When do you feel most at peace, and what can you do to create more of those moments?",
        "What are your strengths, and how can you use them to help others?",
        "Reflect on a recent accomplishment. What did you learn from the experience?",
        "How do you define success, and what steps are you taking to achieve it?",
        "What habits or routines make you feel your best, and how can you incorporate more of them into your life?",
        "Who inspires you, and what qualities do you admire in them?",
        "What are your long-term goals, and what small actions can you take today to move closer to them?"
    };

    protected override string GetDescription()
    {
        return "This activity will help you to focus your mind on more positive aspects of your life list these aspects to better visualize your situation.";
    }

    protected override void PerformActivity()
    {
        var random = new Random();
        string prompt = Prompts[random.Next(Prompts.Length)];
        Console.WriteLine(prompt);
        Pause(3);

        int time = 0;
        int number = 0;
        while (time < GetDuration())
        {
            Console.Write("List item: ");
            Console.ReadLine();
            number++;
            time += 3; // Assume each listing takes 3 seconds
        }

        Console.WriteLine($"You listed {number} items.");
    }
}
