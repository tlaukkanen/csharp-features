using System;

/*

https://dotnetcoretutorials.com/2020/08/10/relational-pattern-matching-in-c-9/
https://dotnetcoretutorials.com/2019/06/25/switch-expressions-in-c-8/

*/

namespace relational_pattern_matching
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;

            if(a is (>1 and <9) or <1)
            {
                Console.WriteLine("FOO");
            } 
            else
            {
                Console.WriteLine("BAR");
            }

            var temperature = 31;
            string desc = "";


            if(temperature<20) {
                desc = "chilly";
            } else if(temperature>20 && temperature<30) {
                desc = "warm";
            } else {
                desc = "hot";
            }

            desc = temperature switch
            {
                int value when value <20 => "chilly",
                int value when value >= 20 && value <30 => "warm",
                _ => "hot"
            };

            desc = temperature switch
            {
                <20 => "chilly",
                >=20 and <30 => "warm",
                _ => "hot"
            };

            Console.WriteLine($"Temperature {temperature} means it's quite {desc}");
            
        }
    }
}
