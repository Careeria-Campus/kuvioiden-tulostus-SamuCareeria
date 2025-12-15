using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Kuinka ison neliön haluat tehdä: ");
            int koko = int.Parse(Console.ReadLine());

            TulostaNelio(koko);
        }

        public static void TulostaNelio(int sivunPituus)
        {
            // Ylärivi
            for (int i = 0; i < sivunPituus; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            // Keskirivit
            for (int i = 0; i < sivunPituus - 2; i++)
            {
                for (int e = 0; e < sivunPituus; e++)
                {
                    if (e == 0 || e == sivunPituus - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            // Alarivi
            for (int i = 0; i < sivunPituus; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
