using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    namespace MyLibrary
    {
        public class MyMethods
        {
            public void SayHello(string name)
            {
                System.Console.WriteLine($"Привет, {name}!");
            }

            public void PrintSum(int a, int b)
            {
                System.Console.WriteLine($"Сумма {a} и {b} = {a + b}");
            }
            public string HI(string name)
            {
                return $"Приветствуем, {name}!";
            }
            public int Substraction(int a, int b)
            {
                return a - b;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
