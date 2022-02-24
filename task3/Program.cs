using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public delegate int Diya(int x, int y);

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Обрати математичну операцію: +,-,*,/");
            string x = Console.ReadLine();
            Console.WriteLine("Перший аргумент:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Другий аргумент");
            int b = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case "+":
                    Diya dodano = (c, y) => { return c + b; };
                    int dod = dodano(a, b);
                    Console.WriteLine("Результат:{0}", dod);
                    break;
                case "-":
                    Diya vidnim = (c, y) => { return c - b; };
                    int vid = vidnim(a, b);
                    Console.WriteLine("Рузультат:{0}", vid);
                    break;
                case "*":
                    Diya mnozh = (c, y) => { return c * b; };
                    int mn = mnozh(a, b);
                    Console.WriteLine("Результат:{0}", mn);
                    break;
                case "/":
                    Diya dilumo = (c, y) => { return c / b; };
                    int di = dilumo(a, b);
                    Console.WriteLine("Результат:{0}", di);
                    break;
                default:
                    Console.WriteLine("Інший вибір варіанту");
                    break;
            }

            Console.ReadKey();

        }
    }
}
