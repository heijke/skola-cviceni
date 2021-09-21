using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> line, new_line = new List<string>();
            Random rnd = new Random();
            using (StreamReader sr = new StreamReader(@"C:\soubor.txt"))
            {
                while (sr.Peek() > -1)
                {
                    line.Add(sr.ReadLine());
                }
                while (new_line.Count != line.Count)
                {
                    int y = rnd.Next(line.Count);
                    if (!(new_line.Contains(line[y])))
                    {
                        new_line.Add(line[y]);
                    }
                }
                for (int i = 0; i < new_line.Count; i++)
                {
                    Console.Write("{0}) {1}\n", i+1, new_line[i]);
                }
                Console.ReadLine();
            }
        }
    }
}
