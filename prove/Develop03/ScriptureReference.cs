class ScriptureReference
{
    public string Reference { get; private set; }

    public ScriptureReference(string reference)
    {
        Reference = reference;
    }

    public ScriptureReference(string book, int chapter, int verseStart, int verseEnd = -1)
    {
        if (verseEnd == -1)
        {
            Reference = $"{book} {chapter}:{verseStart}";
        }
        else
        {
            Reference = $"{book} {chapter}:{verseStart}-{verseEnd}";
        }
    }
}
