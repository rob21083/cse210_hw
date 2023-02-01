using System;

public class fraction
{
    private int _top;
    private int _bottom;

// Constructors for class 
    public fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public fraction(int wholeNUmber)
    {
        _top = wholeNUmber;
        _bottom = 1;
   }

    public fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters and setters
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    { 
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public double GetDecimalValue()
    {
        return (double)_top/ (double) _bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

}