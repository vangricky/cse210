public class Fraction {
    private int Top;
    private int Bottom;

    public Fraction()
    {
        Top = 1;
        Bottom = 1;
    }

    public Fraction(int WholeNumber)
    {
        Top = WholeNumber;
        Bottom = 1;
    }

    public Fraction(int top, int bottom) 
    {
        Top = top;
        Bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{Top} / {Bottom}";
        return text;
    }

}