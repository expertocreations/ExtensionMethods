using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string post = "This is long long long blog post blah blah blah...";
            var shorten = post.Shorten(8);

            Console.WriteLine(shorten);
        }

    }
    public static class StringExtensions
    {
        public static string Shorten(this string str,int numOfWords)
        {
            if (numOfWords == 0)
                return "";
            var words=str.Split(' ');
            if (words.Length <= numOfWords)
                return str;
            return string.Join(" ",words.Take(numOfWords))+".....";
        }
    }
}
