public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string book, string chapter, string verse, string text)
    {
        _reference = new Reference(book, chapter,verse);
        _words = new List<Word>();

        string[] splitText = text.Split(' ');
        
        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.WriteLine($"{_reference}:\n");
        
        foreach (Word word in _words)
        {
            if (word.isHidden())
            {
                Console.Write(new string("_", word.GetText().Length) + " ");
            }
            else
            {
                Console.Write(word.GetText() + " ");
            }
        }
    }

    // public bool HideWords()
    // {
    //     List<_words> visibleWords = GetVisibleWords();
        
    //     if (visibleWords.Count < 2)
    //         return false
        
    //     Random random = new Random();
    //     int randomIndex1 = random.Next(visibleWords.Count);
    //     int randomIndex2;

    //     // need some sort of loop here....
    // }
}