public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetText()
    {
        return _text;
    }

    public bool isHidden()
    {
        return _isHidden;
    }
}