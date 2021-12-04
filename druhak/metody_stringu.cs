using System;

namespace cenzura_cviceni
{
    class Program
    {
        static void Main(string[] args)
        {
            //cv 1
            //text processing v bashi betr

            string[] arr = { "owooo", "jak", "uwu" };
            Console.Write("Napiste vetu k oprave: ");
            string input = Console.ReadLine();
            string[] inputWords = input.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                for (int y = 0; y < inputWords.Length; y++)
                {
                    if (inputWords[y].Contains(arr[i]))
                    {
                        inputWords[y] = inputWords[y].Remove(2, 1).Insert(2, "*");
                    }
                }
            }
            Console.WriteLine(String.Join(" ", inputWords));
            Console.Read();

            //cv 2

            int so_counter = 0, sa_counter = 0;
            char[] sa = { 'a', 'e', 'i', 'o', 'u' };
            char[] so = { 'h', 'k', 'r', 'd', 't', 'n', 'ž', 'š', 'c', 'č', 'ř', 'j', 'ď', 'ť', 'ň' };
            Console.Write("Zadejte vstup: ");
            Console.Read();
            string input2 = Console.ReadLine();
            string outputZ = input2, outputX = input2;
            char[] input2Char = input2.ToCharArray();
            foreach (var item in input2Char)
            {
                foreach (var sa_item in sa)
                {
                    if (item.Equals(sa_item))
                    {
                        sa_counter++;
                    }
                }
                foreach (var so_item in so)
                {
                    if (item.Equals(so_item))
                    {
                        so_counter++;
                    }
                }
            }
            Console.WriteLine("Pocet samohlasek ve vete: {0}\nPocet souhlasek ve vete: {1}", sa_counter, so_counter);
            foreach (var item in sa)
            {
                if (input2.Contains(item.ToString()))
                {
                    outputZ = outputZ.Replace(item, 'Z');
                }
            }
            foreach (var item in so)
            {
                if (input2.Contains(item.ToString()))
                {
                    outputX = outputX.Replace(item, 'X');
                }
            }
            Console.WriteLine(outputZ);
            Console.WriteLine(outputX);
            Console.Read();
        }
    }
}
