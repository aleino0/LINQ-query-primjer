using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_query_primjer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>()
            {
                "C# Tutorials",
                "vs.NET Tutorials",
                "Learn c++",
                "HVC Tutorials",
                "Java"
            };

            var result = from s in stringList
                         where s.Contains("Tutorials")
                         select s;

            foreach (var str in result)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}