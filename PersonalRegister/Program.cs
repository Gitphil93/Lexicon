using System;
using System.Dynamic;
using System.Collections.Generic;

List<Employee> employees = new();

int first = 0;
while (true)
{
   if (first == 0)
    {
        Console.WriteLine("Välkommen till personalregistret");
        first = 1;
    }

    Console.WriteLine("Tryck 1 för att lägga till anställd.");
    Console.WriteLine("Tryck 2 för att visa personalregistret.");
    Console.WriteLine("Tryck 3 för att räkna ut medellön.");
    Console.WriteLine("Tryck 0 för att avsluta.");

    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.WriteLine("Ange namn på den anställde: ");
        string name = Console.ReadLine();
        Console.WriteLine("Ange lön för den anställde: ");

        int salary = int.Parse(Console.ReadLine());

        if (salary < 0)
        {
            Console.WriteLine("Lönen kan inte vara en negativ siffra.");
            continue;
        }
        employees.Add(new Employee(name, salary));
    }
    else if (choice == "2")
    {
        Console.WriteLine("Personalregister: ");
        foreach (var e in employees)
        {
            Console.WriteLine($"Namn: {e.fullName}, Lön: {e.salary}");
        }
    }
    else if (choice == "3")
    {
        Console.WriteLine("Medellönen är: ");
        Console.WriteLine($"{calculateAverage(employees)} kr");
    }
    else if (choice == "0")
    {
        Console.WriteLine("Avslutar...");
        break;
    }
    else
    {
        Console.WriteLine("Ogiltigt val.");
    }
}

int calculateAverage(List<Employee> employees)
{
    if (employees.Count == 0) return 0;

    int total = 0;

    foreach (var e in employees)
    {
        total += e.salary;
    }

    return total / employees.Count;

}
class Employee
{
    public string fullName;
    public int salary;

    public string choice;

    public Employee(string name, int _salary)
    {
        fullName = name;
        salary = _salary;
    }

}

