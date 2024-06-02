
class Practice
{
    private Word[] words;

    public Practice(Word[] words)
    {
        this.words = words;
    }

    public void Display()
    {
        Console.Clear();
        foreach (Word word in words)
        {
            if (word.HiddenText())
                Console.Write(new string('-', word.Text().Length) + " ");
            else
                Console.Write(word.Text() + " ");
        }
        Console.WriteLine();
    }

    public void HideRandom()
    {
        Random rand = new Random();
        int index = rand.Next(0, words.Length);
        words[index].Hide();
    }

    public bool Finished()
    {
        foreach (Word word in words)
        {
            if (!word.HiddenText())
            {
                return false;
            }
        }
        return true;
    }
}
