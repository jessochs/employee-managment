using System;
using System.Data;

public class Information : Employee
{
    private string _street;
    private string _city;
    private string _country;
    private string _birthday;
    private string _social;

    public Information(){}

    public Information(string street, string city, string country, string birthday, string social)
    {
        _street = street;
        _city = city;
        _country = country;
        _birthday = birthday;
        _social = social;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Employee's Information:");
        Console.WriteLine($"Address: {_street} {_city}, {_country}");
        Console.WriteLine($"Birthday: {_birthday}");
        Console.WriteLine($"Wizard Security Number: {_social}");
        Console.WriteLine("");
    }

    public override void Confirmation()
    {
        Console.WriteLine("Employee information has been added.");
    }

}