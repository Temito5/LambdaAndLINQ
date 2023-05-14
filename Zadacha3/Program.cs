using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string izrechenie = Console.ReadLine().ToLower();
            char[] charseparator = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\"', '\'', '/', '!', '?', ' ' };
            string[] words = izrechenie.Split(charseparator);
            var result = words.
                Where(x => x.Length < 5)
                .OrderBy(w => w)
                .Distinct();
            Console.WriteLine(string.Join("  ", result));
        }
    }
}
