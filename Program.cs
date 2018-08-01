using System;

namespace Test1

{
    class Program
    {
        static void Main(string[] args)
        {
            var chislo1 = 1;
            var continued = true;
            do
            {
                Console.WriteLine("Vvedite chislo ot 1 do 3 ili 0 dlya zaversheniya");
                var chislo = Console.ReadLine();
                var chisloint = int.Parse(chislo);
                if (chisloint == 0)
                {
                    continued = false;
                }
                if (chisloint == 1)
                {
                    Console.WriteLine("Vvedite lyuboe chislo");
                    var input = Console.ReadLine();
                    chislo1 = Convert.ToInt32(input);
                }
                else if (chisloint == 2)
                {
                    Console.WriteLine("Vvedennoe chislo x10 =");
                    var chislo2 = chislo1;
                    Console.WriteLine(chislo2 * 10);
                }
                else if (chisloint == 3)
                {
                    Console.WriteLine("Tekuschaya data:");
                    Console.WriteLine(DateTime.Today);
                }
                else
                {
                    Console.WriteLine("Nepravilnoye chislo");
                }
            }
            while (continued == true);
        }
    }
}
