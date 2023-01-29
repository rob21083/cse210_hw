using System;

public class PromptGenerator
{
    public List<string> _list = new List<string>();

    public void load()
    {
                string line = "";
        StreamReader sr = new StreamReader("randomentry.txt");

        while (line != null)
        {        
            //Read the next line
            line = sr.ReadLine();
            if (line != null)
            {
                _list.Add(line);
            }
            
        }
        //close the file
        sr.Close();

    }
    public string getPrompt()
    {
    
        var random = new Random();
    
        int index = random.Next(_list.Count);
        return (_list[index]);
        
    }
}