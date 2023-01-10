using System;

class Program
{
    static void Main(string[] args)
    {
        displayWelcomeMessage();

        string inputName = userName();
        int inputNumber = promptUserNumber();

        int squared = square(inputNumber);

        results(inputName, squared);
    }

    static void displayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string userName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int promptUserNumber()
    {
      Console.Write("Please enter your favorite number: ");  
      int number = int.Parse(Console.ReadLine());
      return number;
    }

    static int square(int number)
    {
        int square = number * number;
        return square;
    }
    static void results (string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}