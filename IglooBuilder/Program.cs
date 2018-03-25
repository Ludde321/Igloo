using System;
using System.Collections.Generic;
using Common;

namespace IglooBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var igloo = new Igloo();
            igloo.Build();

            StlWriter.Create(@"C:\Temp\igloo.stl", igloo.Triangles, igloo.Vertexes);

            Console.WriteLine("Done!");
        }
    }
}
