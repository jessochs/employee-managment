using System;

public abstract class Employee
{
    // this is the super class. Anything in here can be used in the other sub classes.
    protected string _fname;
    protected string _lname;
    protected string _employeeId;
    protected string _dateHired;
    protected string _position; 



    public abstract void Confirmation();
    // abstract method will be changed and used in all of the sub classes
    
}

