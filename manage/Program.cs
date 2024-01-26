using System;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

class Program {

    
    static void Main(string[] args)
    {
        List<Employee> em = new List<Employee>();
        

        AddEmployee emp1 = new AddEmployee("Harry", "Potter", "hw341", "09/04/2004", "Minister of Magic");
        AddEmployee emp2 = new AddEmployee("Hermoine", "Granger", "hw342", "09/04/2004", "Minister of Magic");
        AddEmployee emp3 = new AddEmployee("Ronald", "Weasley", "hw343", "09/04/2004", "Dragon Trainer");
        em.Add(emp1);
        em.Add(emp2);
        em.Add(emp3);

        Edit edit1 = new Edit();

        Console.WriteLine("Welcome to Employee Management");
        Console.WriteLine("");

        bool option = false;

        while(!option)
        {
            
            Console.WriteLine("1. Add and employee");
            Console.WriteLine("2. Delete an employee");
            Console.WriteLine("3. Display all employees");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Please select one of the following:");
            string choice = Console.ReadLine();
            Console.WriteLine("");

            switch(choice)
            {
                case "1":
                AddEmployee emp4 = new AddEmployee("Dean", "Thomas", "hw355", "10/31/2005", "Hogwarts Headmaster");
                em.Add(emp4);
                emp4.Confirmation();
                break;
                
                case "2":
                em.RemoveAt(edit1.WhichEmp());
                edit1.Confirmation();
                break;

                case "3":
                foreach(Employee e in em)
                {
                    e.DisplayInfo();
                }
                break;
                
                case "4":
                return;

            }
        }
    }
}