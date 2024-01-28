using System;

internal class Program
{
    private static void Main(string[] args)
    {
        List<AddEmployee> em = new List<AddEmployee>();
        // create a list to add all the employees

        Information info1 = new Information("1441 Green Grass Ln", "London", "England", "July 31, 1980", "XXX-XX-XXXX");
        Information info2 = new Information("1451 Green Grass Ln", "London", "England", "September 19, 1979", "XXX-XX-XXXX");
        Information info3 = new Information("1451 Green Grass Ln", "London", "England", "March 1, 1980", "XXX-XX-XXXX");
        Information info4 = new Information("Wispy Wilows", "Edinborough", "Scottlland", "November 22, 1950", "XXX-XX-XXXX");

        // instantiate and insert information for each employee in the list so it can be added as an AddEmployee parameter
        
        // instantiate the employees
        AddEmployee emp1 = new AddEmployee("Harry", "Potter", "hw341", "09/04/2004", "Head of Auror Office", info1);
        AddEmployee emp2 = new AddEmployee("Hermoine", "Granger", "hw342", "09/04/2004", "Minister of Magic", info2);
        AddEmployee emp3 = new AddEmployee("Ronald", "Weasley", "hw343", "09/04/2004", "Weasley's Wizard Wheezes", info3);
        // add the employees to the list that was created
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
                // creates one new employee that will be added if this menu option is chosen
                AddEmployee emp4 = new AddEmployee("McGonagall", "Minerva", "hw355", "10/31/2005", "Hogwarts Headmaster", info4);
                em.Add(emp4);
                emp4.Confirmation();
                break;
                
                case "2":
                // removes and employee and the desired index
                em.RemoveAt(edit1.WhichEmp());
                edit1.Confirmation();
                break;

                case "3":
                // displays all employees and their information
                foreach(AddEmployee e in em)
                {
                    e.Display();
                }
                break;
                
                case "4":
                return;

            }
        }
    }

    }
