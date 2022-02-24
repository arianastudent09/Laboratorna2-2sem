using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Serednie
    {
        delegate double Average(int x, int y, int z);
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Average chislo = (x, y, z) => (x + y + z) / 3;
            double ser = chislo(10, 15, 20);
            Console.WriteLine(ser);
            Console.ReadKey(true);
        }
    }

}
