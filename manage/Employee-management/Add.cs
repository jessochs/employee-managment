using System;

public class AddEmployee : Employee
{
    // This class enables us to add an employee to the list
    private string Fname{get{return _fname;}}
    private string Lname{get{return _lname;}}
    private string EmployeeId{get{return _employeeId;}}
    private string DateHired{get{return _dateHired;}}
    private string Position{get{return _position;}}
    // getting and setting

    private Information _info = new Information();
    public Information Information{get{return _info;}}
    // I want the personal employee information to be added to each employee
    public AddEmployee(){}

    public AddEmployee(string fname, string lname, string employeeId, string dateHired, string position, Information info)
    {
        _fname = fname;
        _lname = lname;
        _employeeId = employeeId;
        _dateHired = dateHired;
        _position = position;
        _info = info;
    }
     public void  Display()
    {
        Console.WriteLine($"Employee Name: {_lname}, {_fname}");
        Console.WriteLine($"Employee ID: {_employeeId}");
        Console.WriteLine($"Date Hired: {_dateHired}");
        Console.WriteLine($"Job Title: {_position}");
        Console.WriteLine("");
        _info.DisplayInfo();
        // when the employee prints, their information will also print
        Console.WriteLine("");
    }
    
    public override void Confirmation()
    {
        Console.WriteLine("Employee has been succcessfully added.");
    }


} 