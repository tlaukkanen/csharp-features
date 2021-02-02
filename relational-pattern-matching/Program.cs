using System;

namespace relational_pattern_matching
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;

            if(a is > 1 and < 9 or < 1) 
            {
                Console.WriteLine("FOO");
            } 
            else
            {
                Console.WriteLine("BAR");
            }
        }
    }
}
