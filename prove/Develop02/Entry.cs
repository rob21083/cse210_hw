using System;

public class Entry
{
    public string _prompt;
    public string _userInput;
    public DateTime _timeStamp = DateTime.Now;

    public void import(string concatenatedText)
    {
        string[] splitStrings = concatenatedText.Split("|||");
        var timeStamp = DateTime.Parse(splitStrings[0]);
        var prompt = splitStrings[1];
        var userInput = splitStrings [2];

        _timeStamp = timeStamp;
        _prompt = prompt;
        _userInput = userInput;

        
    }
    public string export()
    {
        return _timeStamp.ToString() + "|||" + _prompt + "|||" + _userInput;
    }
    public void display()
    {
        Console.WriteLine("Date: " + _timeStamp.ToString());
        Console.WriteLine("Prompt: " + _prompt);
        Console.WriteLine("Entry: " + _userInput);
    }
    public Entry(string prompt, string userInput)
    {
        _prompt = prompt;
        _userInput = userInput;
    }

    public Entry()
    {

    }
}