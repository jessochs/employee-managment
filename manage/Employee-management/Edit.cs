using System;
using System.Data;

public class Edit : Employee 
{
    

    protected int _answer;

    public int WhichEmp()
    {
        Console.Write("Which employee would you like to delete? Options: 0, 1, or 2");
        _answer = int.Parse(Console.ReadLine());
        return _answer;
    }

    public override void Confirmation()
    {
        
        Console.WriteLine($"{_answer} has been removed");
        Console.WriteLine("");
    }
}
