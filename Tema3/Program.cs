using MyLibrary.MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            MyMethods methods = new MyMethods();
            Console.WriteLine("Введите 1-ое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2-ое число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваше Имя");
            String name = Console.ReadLine();
            methods.SayHello($"{name}");
            methods.PrintSum(a, b);
            string Privetstvie = methods.HI(name);
            Console.WriteLine(Privetstvie);
            int Sub = methods.Substraction(a, b);
            Console.WriteLine($"Результат Вычитания Из {a} число {b}: {Sub}");
        }
    }
}
