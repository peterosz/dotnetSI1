using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class Program
    {
        public static string Sortit(string str)
        {
            string[] words = str.Split(' ');
            Array.Sort(words);
            string s = string.Join(" ", words);
            return s;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a string to sort: ");
            string str = Console.ReadLine();
            string sorted = Sortit(str);
            Console.Write("\nSorted: ");
            Console.WriteLine(sorted + "\n");
        }
    }
}
