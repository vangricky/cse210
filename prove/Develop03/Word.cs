public class Word
{
    private string Text;
    private bool Hidden;


    public Word(string text, bool hidden)
    {
        Text = text;
        Hidden = hidden;
    }

    public void Hide()
    {
        Hidden = true;
    }

    public void Show()
    {
        Hidden = false;
    }

    public bool isHidden()
    {
        return Hidden;
    }

    public string getRenderedText()
    {
        return Hidden ? "___" : Text;
    }

}