public class Reference
{
    private string book;
    private string chapter;
    private string startVerse;
    private string endVerse;

    

    public string display() 
    {
        return $"{book} {chapter}:{startVerse}-{endVerse}";
    }
}