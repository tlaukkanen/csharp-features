using System;

namespace records
{
    public record Person
    {
        public string LastName { get; }
        public string FirstName { get; }

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

            Console.WriteLine(student == person); // false
        }
    }
}
