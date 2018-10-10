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
                string Vvodnoe = Console.ReadLine();
                double number;
                if (Double.TryParse(Vvodnoe, out number))
                {
                    var VvodnoeChislo = int.Parse(Vvodnoe);
                    switch (VvodnoeChislo)
                    {
                        case 0:
                            continued = false;
                            break;

                        case 1:
                            Console.WriteLine("Vvedite lyuboe chislo");
                            string input = Console.ReadLine();
                            double number1;
                            if (Double.TryParse(input, out number1))
                            {
                                chislo1 = Convert.ToInt32(input);
                            }
                            else
                            {
                                Console.WriteLine("Vvedite chislo, a ne tekst '{0}'.", input);
                            }
                            break;

                        case 2:
                            Console.WriteLine("Vvedennoe chislo x10 =");
                            var chislo2 = chislo1;
                            Console.WriteLine(chislo2 * 10);
                            break;

                        case 3:
                            Console.WriteLine("Tekuschaya data:");
                            Console.WriteLine(DateTime.Today);
                            break;

                        default:
                            Console.WriteLine("Nepravilnoye chislo");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Vvedite chislo, a ne tekst '{0}'.", Vvodnoe);
                }
            }
            while (continued);
        }
    }
}