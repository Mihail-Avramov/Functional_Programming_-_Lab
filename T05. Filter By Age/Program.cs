using System;
using System.Collections.Generic;

int n = int.Parse(Console.ReadLine());

List<Person> persons = new List<Person>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);

    Person newPerson = new Person()
        { name = input[0], age = int.Parse(input[1]) };

    persons.Add(newPerson);
}

string filterType = Console.ReadLine();
int filterValue = int.Parse(Console.ReadLine());
string printFormat = Console.ReadLine();

Func<string, int, Predicate<Person>> getFilter = (filterType, filterValue) =>
{
    switch (filterType)
    {
        case "older":
            return a => a.age >= filterValue;
        case "younger":
            return a => a.age < filterValue;
        default:
            return default;
    }
};

Action<List<Person>, string> printAction = (persons, printFormat) =>
{
    foreach (var person in persons)
    {
        if (printFormat == "name")
        {
            Console.WriteLine(person.name);
        }
        else if (printFormat == "age")
        {
            Console.WriteLine(person.age);
        }
        else
        {
            Console.WriteLine($"{person.name} - {person.age}");
        }
    }
};


printAction(persons.FindAll(getFilter(filterType, filterValue)), printFormat);



class Person
{
    public string name;
    public int age;
}