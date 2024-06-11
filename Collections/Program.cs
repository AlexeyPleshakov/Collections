using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Collections
{
    class Program
    {
        List<string> List = new List<string>();
        LinkedList<string> LinkedList = new LinkedList<string>();
        static void Main(string[] args)
        {
            Program program = new Program();
            string text = File.ReadAllText(args[0]);

            var watchTwo = Stopwatch.StartNew();

            program.List.Add(text);
            Console.WriteLine($"Вставка в List: {watchTwo.Elapsed.TotalMilliseconds}");
            Console.WriteLine();

            watchTwo.Restart();

            program.LinkedList.AddFirst(text);
            Console.WriteLine($"Вставка в LinkedList: {watchTwo.Elapsed.TotalMilliseconds}");
        }
    }
}
