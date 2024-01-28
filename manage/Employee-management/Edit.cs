using System;
using System.Data;

public class Edit : Employee 
{
    // This class is responsible for taking input from the user and converting it to an index so it can be used to remove and index from a list
    

    protected int _answer;

    public int WhichEmp()
    {
        Console.Write("Which employee would you like to delete? Options: 0, 1, or 2");
        // The options are 0-2 since those are the indexes definately in the list
        _answer = int.Parse(Console.ReadLine());
        // reads the input and converts it to an integer
        return _answer;
        // returns the answer when the method is called
    }

    public override void Confirmation()
    {
        
        Console.WriteLine($"{_answer} has been removed");
        Console.WriteLine("");
    }
}
