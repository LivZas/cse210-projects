using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private ScriptureReference _reference;
    private List<Word> _words;
    private int _hiddenWordsCount;

    public Scripture(string reference, string text)
    {
        _reference = new ScriptureReference(reference);
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
        _hiddenWordsCount = 0;
    }

    public void StartGame()
    {
        bool gameOver = false;

        while (!gameOver)
        {
            Console.Clear();
            DisplayScripture();
            Console.WriteLine($"\nHidden words: {_hiddenWordsCount}");
            Console.WriteLine("Press Enter to hide words or type 'quit' to end.");

            string input = Console.ReadLine();
            if (input?.ToLower() == "quit")
            {
                gameOver = true;
            }
            else
            {
                HideRandomWord();
                _hiddenWordsCount++;
                gameOver = _words.All(w => w.IsHidden);
            }
        }

        Console.Clear();
        DisplayScripture();
        Console.WriteLine($"\nGame Over! Total hidden words: {_hiddenWordsCount}");
    }

    private void DisplayScripture()
    {
        Console.WriteLine(_reference.Reference);
        foreach (var word in _words)
        {
            Console.Write(word.Display() + " ");
        }
    }

    private void HideRandomWord()
    {
        Random rand = new Random();
        int index = rand.Next(_words.Count);
        _words[index].Hide();
    }
}
