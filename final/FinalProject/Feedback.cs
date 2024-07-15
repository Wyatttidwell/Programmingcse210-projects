public class FeedbackProvider
{
    public void ProvideFeedback()
    {
        Console.Write("Do you want positive or negative feedback? (positive/negative): ");
        string choice = Console.ReadLine().ToLower();

        if (choice == "positive")
        {
            Console.WriteLine("You're doing a great job! Keep up the good work!");
        }
        else if (choice == "negative")
        {
            Console.WriteLine("You need to push harder. You're failing right now.");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
}
