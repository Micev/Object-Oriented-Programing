using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrBuilder
{
    class TestStringBulder
    {
        public static void Main()
        {
            StringBuilder str = new StringBuilder("Write a program to demonstrate that your new extension methods work correctly." );
            IEnumerable<string> chars = new List<string>() { "I'", "m", " a", "p", "p", "e", "n", "d" };
            Console.WriteLine(str.Substring(8,7));
            Console.WriteLine(str.RemoveText(" demonstrate"));
            Console.WriteLine(str.AppendAll<string>(chars));
        }
    }
}
