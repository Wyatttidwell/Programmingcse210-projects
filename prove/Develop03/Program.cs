class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture practice");
        Console.WriteLine("Press Enter to begin or type 'quit' to exit.");

        string[] verses = {
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish but have everlasting life. For God sent not his son into the world to condemn the world; but that the world though him might be saved."
        };
        string reference = "John 3:16-17";

        Scripture scripture = new Scripture(reference, verses);
        Reference refObject = new Reference(reference);

        Console.WriteLine(refObject.GetReference());

        if (Console.ReadLine().ToLower() == "quit")
        {
            return;
        }

        scripture.Start();
    }
}