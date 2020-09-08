using System;

namespace Практика1._2
{
    class Task2
    {
        static string s = "Microsoft .NET Framework 2 Application Development Foundation";
        static string[] sa = s.Split(" ");
        static void Main(string[] args)
        {
            Array.Sort(sa);
            s = string.Join(" ", sa); Console.WriteLine(s);
        }
    }
}