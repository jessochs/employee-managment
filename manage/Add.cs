using System;

public class AddEmployee : Employee
{
    private AddEmployee(){}

    private string Fname{get{return _fname;}}
    private string Lname{get{return _lname;}}
    private string EmployeeId{get{return _employeeId;}}
    private string DateHired{get{return _dateHired;}}
    private string Position{get{return _position;}}

    public AddEmployee(string fname, string lname, string employeeId, string dateHired, string position)
    {
        _fname = fname;
        _lname = lname;
        _employeeId = employeeId;
        _dateHired = dateHired;
        _position = position;
    }
  
    public override void Confirmation()
    {
        Console.WriteLine("Employee has been succcessfully added.");
    }


} 