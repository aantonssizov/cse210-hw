class Scripture
{
    public Reference Reference { get; private set; }
    public string Content
    {
        get
        {
            return string.Join(" ", _contentWords.Select(w => w.Value));
        }
    }

    public bool IsAllHidden
    {
        get
        {
            return !_contentWords.Any(w => !w.IsSymbol && !w.IsHidden);
        }
    }

    private readonly List<Word> _contentWords = [];

    public Scripture()
    {
    }

    public Scripture(Reference reference, string content)
    {
        Reference = reference;
        ParseContent(content);
    }

    public void SetScripture(Reference reference, string content)
    {
        Reference = reference;
        ParseContent(content);
    }

    public void Display()
    {
        Console.WriteLine($"{Reference} {Content}");
    }

    public void HideAFew()
    {
        Random random = new();

        int unhiddenWordCount = _contentWords.Count(w => !w.IsSymbol && !w.IsHidden);

        unhiddenWordCount = unhiddenWordCount >= 3 ? 3 : unhiddenWordCount;

        for (int i = 0; i < unhiddenWordCount; i++)
        {
            int index;

            do
                index = random.Next(0, _contentWords.Count);
            while (_contentWords[index].IsHidden);

            _contentWords[index].Hide();
        }
    }

    public void ShowAll()
    {
        foreach (Word word in _contentWords)
            word.Show();
    }

    private void ParseContent(string content)
    {
        _contentWords.Clear();
        string[] words = content.Split(' ');

        foreach (string word in words)
            _contentWords.Add(new(word));
    }
}