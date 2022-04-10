using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDoingHomeworkStringsSkobki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStr;
            bool result = true;

            Console.Write("введите выражение: ");
            inputStr = Console.ReadLine();





            if (result == true)
            {
                Console.WriteLine("скобки расставлены правильно");
            }
            else
            {
                Console.WriteLine("скобки расставлены НЕправильно");
            }
        }
    }
}
