using System;
class Word
{
    private string text;
    private bool hiddenText;

    public Word(string text)
    {
        this.text = text;
        hiddenText = false;
    }

    public string Hide()
    {
        hiddenText = true;
        return new string('-', text.Length);
    }

    public bool HiddenText()
    {
        return hiddenText;
    }

    public string Text()
    {
        return text;
    }
}