using System;

/*
https://devblogs.microsoft.com/dotnet/c-9-0-on-the-record/

A record is still a class, but the record keyword imbues it with 
several additional value-like behaviors. Generally speaking, 
records are defined by their contents, not their identity. 
In this regard, records are much closer to structs, but records 
are still reference types.

While records can be mutable, they are primarily built for better 
supporting immutable data models.
*/

namespace records
{
    public record Person
    {
        public string LastName { get; }
        public string FirstName { get; init; }

        public Person(string first, string last) => (FirstName, LastName) = (first, last);
    }

    public sealed record Student : Person
    {
        public int Level { get; }

        public Student(string first, string last, int level) : base(first, last) => Level = level;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Bill", "Wagner");
            var student = new Student("Bill", "Wagner", 11);

            var jill = person with { FirstName = "Jill"};
            var bill = person with { FirstName = "Bill"};

            Console.WriteLine(student == person); // false
            Console.WriteLine(jill);
            Console.WriteLine(person == bill);
        }
    }
}
