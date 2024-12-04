class Word
{
    public string OriginalWord { get; private set; }
    public string DisplayWord { get; private set; }
    public bool IsHidden { get; private set; }

    public Word(string word)
    {
        OriginalWord = word;
        DisplayWord = word;
        IsHidden = false;
    }

    public void Hide()
    {
        if (!IsHidden)
        {
            DisplayWord = new string('_', OriginalWord.Length);
            IsHidden = true;
        }
    }

    public string Display()
    {
        return DisplayWord;
    }
}
