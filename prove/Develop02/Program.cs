using System;

class Program
{
  
    static void Main(string[] args)
    {
        Journal currentJournal = new Journal();

        int numSelect = -1;
        while (numSelect != 5)
        {
            Console.WriteLine("Please set one of the following choices:");
            //User input prompt 
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            //Line of code to be read 
            Console.Write("what you would like to do?");
            // string numSelect = Console.ReadLine();
            // numSelect = int.Parse(numSelect);
            numSelect = int.Parse(Console.ReadLine());

            //Write will display a prompt and the user can then write a response 
            if (numSelect == 1)
            {
                currentJournal.createEntry();
            }

            //Display will display all the journal entries with the prompt and the time.
            else if (numSelect == 2)
            {
                currentJournal.display();
            }

            //Load is ment to load all entries from the text and display them
            else if (numSelect == 3)
            {
                Journal temp = new Journal();
                temp.load();
                currentJournal = temp;            
            }

            //Save will save the file to the txt file
            else if (numSelect == 4)
            {
                currentJournal.save();
            }
        }
    }
}