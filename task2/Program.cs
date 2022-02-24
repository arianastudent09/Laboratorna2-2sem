using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public delegate int Rahunok();
    public delegate double Average(Rahunok[] array);
    class Program
    {
        static Random vypadok = new Random();
        public static int Randomizer() => vypadok.Next(100, 250);
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Rahunok[] chislo = new Rahunok[3];
            for (int i = 0; i < chislo.Length; i++) chislo[i] = Randomizer;
            Average sered = delegate (Rahunok[] array)
            {
                double dodano = 0;
                for (int i = 0; 
                i < array.Length; i++)
                {
                    int y = array[i]();
                    dodano += y;
                    Console.Write($" {y} ");
                }
                return dodano / array.Length;
            };
            for (int x = 1; x < 5; x++) 
                Console.WriteLine($"= {sered(chislo)}");
            Console.ReadKey();
        }
    }

}
