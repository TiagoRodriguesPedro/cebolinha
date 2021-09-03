using System;

namespace cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string Frasedigitada, Frasecomdislalia;
            Console.WriteLine("digite uma flase");
            Frasedigitada = Console.ReadLine();

            Frasecomdislalia = Frasedigitada.Replace("r", "l").Replace("R","L");

            Console.WriteLine(Frasecomdislalia);

        }
    }
}
