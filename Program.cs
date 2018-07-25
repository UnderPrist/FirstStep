using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1

{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                Console.WriteLine("Vvedite chislo ot 1 do 3 ili 'N' dlya zaversheniya");
                var chislo = Console.ReadLine();
                var chislo1 = 1;
                if (chislo == "1")
                {
                    Console.WriteLine("Vvedite lyuboe chislo");
                    var input = Console.ReadLine();
                    chislo1 = Convert.ToInt32(input);
                }
                else if (chislo == "2")
                {
                    Console.WriteLine("Vvedennoe chislo x10 =");
                    Console.WriteLine(chislo1 * 10);
                }
                else
                {
                    Console.WriteLine("Tekuschaya data:");
                    Console.WriteLine(chislo1);
                }
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
