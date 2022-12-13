using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zadania_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            string pattern = @"[a-zA-Z]+";
            string zamena = "...";
            Regex regex = new Regex(pattern); 
            string res = regex.Replace(text, zamena);
            Console.WriteLine(res);
        }
    }
}
