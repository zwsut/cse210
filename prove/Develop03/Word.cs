public class Word
{
    private string _text;
    private bool _isHidden;
    private string _hiddenText;

    public Word(string text)
    {
        _isHidden = false;
        _text = text;
        int length = _text.Length;
        _hiddenText = new string('_', length);
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            return _hiddenText;
        }
        else
        {
            return _text;
        }
    }
}
