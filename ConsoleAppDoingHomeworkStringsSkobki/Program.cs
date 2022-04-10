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

            int balanceBrackets = 0;
            
            for (int i = 0; i < inputStr.Length; i++)
            {
                if (inputStr[i] == '(')
                {
                    balanceBrackets++;
                }
                if (inputStr[i] == ')')
                {
                    balanceBrackets--;
                }

                if (balanceBrackets < 0)
                {
                    result = false;
                    break;
                }
            }

            if (balanceBrackets > 0)
            {
                result = false;
            }


            if (result == true)
            {
                Console.WriteLine("скобки расставлены правильно");
            }
            else
            {
                Console.WriteLine("скобки расставлены НЕправильно");
            }

            Console.ReadKey();
        }
    }
}
