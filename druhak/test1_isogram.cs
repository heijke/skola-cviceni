using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_04._11._21
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pole_slov = { "minotaur", "kolo", "automobil", "traktor", "dum", "raketa", "csharp", "motocykl", "aaa" };
            List<string> list_slov = new List<string>();
            
            foreach (var item in pole_slov)
            {
                List<char> buff = new List<char>();
                for (int i = 0; i < item.Length; i++)
                {
                    if (item.IndexOf(item[i]) < item.LastIndexOf(item[i]))
                    {
                        break;
                    }
                    else
                    {
                        buff.Add(item[i]);
                    }
                }
                if (String.Join("", buff) == item)
                {
                    list_slov.Add(item);
                }
            }
            int curr_max_len = 0;
            string longest = "", souhlasky = "";
            char[] sa = { 'a', 'e', 'i', 'o', 'u' };
            foreach (string item in list_slov)
            {
                if (item.Length > curr_max_len)
                {
                    curr_max_len = item.Length;
                    longest = item;
                }
                souhlasky = longest;
            }
            foreach (char item in sa)
            {
                if (souhlasky.Contains(item))
                {
                    souhlasky = souhlasky.Remove(souhlasky.IndexOf(item),1);
                }
            }
            Console.WriteLine(souhlasky.ToUpper());
            Console.WriteLine(longest.Remove(4).Insert(longest.Remove(4).Length, "koala"));
            Console.Read();
        }
    }
}
