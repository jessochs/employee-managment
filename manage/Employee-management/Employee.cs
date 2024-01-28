using System;

public abstract class Employee
{
    protected string _fname;
    protected string _lname;
    protected string _employeeId;
    protected string _dateHired;
    protected string _position; 


    // public void  Display()
    // {
    //     Console.WriteLine($"Employee Name: {_lname}, {_fname}");
    //     Console.WriteLine($"Employee ID: {_employeeId}");
    //     Console.WriteLine($"Date Hired: {_dateHired}");
    //     Console.WriteLine($"Job Title: {_position}");
    //     Console.WriteLine("");
    // }

    public abstract void Confirmation();

    
}

