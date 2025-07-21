using System.Text;

class Word
{
    public string Value { get; private set; }
    private string _originalValue;
    public bool IsSymbol { get; private set; }
    public bool IsHidden { get; private set; }

    public Word()
    {
        IsHidden = false;
    }

    public Word(string value)
    {
        Value = value;
        _originalValue = value;
        IsSymbol = IsASymbol(value);
        IsHidden = false;
    }

    public void SetWord(string value)
    {
        Value = value;
        _originalValue = value;
        IsSymbol = IsASymbol(value);
        IsHidden = false;
    }

    public void Hide()
    {
        if (!IsSymbol && !IsHidden)
        {
            Value = string.Concat(Enumerable.Repeat("_", Value.Length));

            if (IsASymbol(_originalValue[0].ToString()))
            {
                StringBuilder stringBuilder = new(Value);
                stringBuilder[0] = _originalValue[0];
                Value = stringBuilder.ToString();
            }

            if (IsASymbol(_originalValue[^1].ToString()))
            {
                StringBuilder stringBuilder = new(Value);
                stringBuilder[^1] = _originalValue[^1];
                Value = stringBuilder.ToString();
            }

            if (_originalValue.EndsWith("..."))
            {
                StringBuilder stringBuilder = new(Value);
                stringBuilder[^1] = '.';
                stringBuilder[^2] = '.';
                stringBuilder[^3] = '.';
                Value = stringBuilder.ToString();
            }

            IsHidden = true;
        }
    }

    public void Show()
    {
        if (!IsSymbol && IsHidden)
        {
            Value = _originalValue;
            IsHidden = false;
        }
    }

    public static bool IsASymbol(string sybmol)
    {
        string[] symbols = [".", ",", "?", "!", ":", ";", "\"", "(", ")", "-"];
        return (sybmol.Length == 1 && symbols.Contains(sybmol)) || sybmol == "...";
    }
}