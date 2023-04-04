using System;

namespace CsE12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EXERCÍCIO 13
            Console.WriteLine("Achando o intervalo de 25 casas até 100\n\nINFORME UM VALOR: ");
            double v = double.Parse(Console.ReadLine());
            if (v >= 0 && v <= 25)
                Console.WriteLine("\nINTERVALO [0.25]");
            else if (v > 25 && v <= 50)
                Console.WriteLine("\nINTERVALO [25.50]");
            else if (v > 50 && v <= 75)
                Console.WriteLine("\nINTERVALO [50.75]");
            else if (v > 75 && v <= 100)
                Console.WriteLine("\nINTERVALO [75.100]");
            else Console.WriteLine("\nFORA DO INTERVALO");
            Console.WriteLine("\nFim do Programa!");
        }
    }
}
