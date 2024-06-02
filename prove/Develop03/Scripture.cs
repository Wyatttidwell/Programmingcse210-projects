class Scripture
{
    private string reference;
    private Practice practice;

    public Scripture(string reference, string[] verses)
    {
        this.reference = reference;
        Word[] words = ConvertVersesToWords(verses);
        this.practice = new Practice(words);
    }

    private Word[] ConvertVersesToWords(string[] verses)
    {
        List<Word> words = new List<Word>();

        foreach (string verse in verses)
        {
            string[] splitWords = verse.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in splitWords)
            {
                words.Add(new Word(word));
            }
        }

        return words.ToArray();
    }

    public string GetReference()
    {
        return reference;
    }

    public void Start()
    {
        while (true)
        {
            Console.Clear();
            practice.Display();
            Console.WriteLine("\nPress Enter when you want to continue or type 0 to quit");
            string input = Console.ReadLine();
            if (input == "0" || practice.Finished())
            {
                break;
            }
            practice.HideRandom();
        }
    }
}
