using System.Linq;

var lines = System.IO.File.ReadAllLines(args[0]);
lines.ToList().ForEach(l => System.Console.WriteLine(l.Replace(".", "|")));