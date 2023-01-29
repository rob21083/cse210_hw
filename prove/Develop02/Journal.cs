using System.IO;

public class Journal
{
// Attributes for Journal. 
    public string _saveFile;
    public PromptGenerator _promptGenerator = new PromptGenerator();
    public List<Entry> _entries = new List<Entry>();
// Classes methods 
    public void createEntry()
    {
        var prompt = _promptGenerator.getPrompt();
        Console.WriteLine(prompt);
        var input = Console.ReadLine();
        var newEntry = new Entry(prompt, input);
        _entries.Add(newEntry);
    }
    
    public void save()
    {
        var fileName = "journal.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach ( var newEntry in _entries)
        {
        // You can use the $ and include variables just like with Console.WriteLine
        outputFile.WriteLine(newEntry.export());
        }
               
            }
    }
    public void load()
    {
        _entries = new List<Entry>();
        string line = "";
        StreamReader sr = new StreamReader("journal.txt");

        while (line != null)
        {        
            //Read the next line
            line = sr.ReadLine();
            if (line != null)
            {
                var entry = new Entry();
                entry.import(line);
                _entries.Add(entry);
            }
            
        }
        //close the file
        sr.Close();

        Console.WriteLine("successfully loaded! Now select display to veiw your old entries.");
    }
    
    public void display()
    {
        Console.WriteLine("---------------------------");
        foreach ( var newEntry in _entries)
        {
            newEntry.display();
        }
        Console.WriteLine("---------------------------");

    }

    public Journal ()
    {
        _promptGenerator.load();
    }

}