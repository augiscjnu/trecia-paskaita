using System;

namespace PirmaPaskaita1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite slaptazodi");
            int a = int.Parse(Console.ReadLine());

            int s = 123456789;

            while (a != s)
            {
                if (a == s)
                {
                    break;
                }

                Console.WriteLine("slaptazodis netiesingas");
                Console.WriteLine();

                a = int.Parse(Console.ReadLine());




            }

            Console.WriteLine("svieki prisijunge");
            Console.WriteLine();

        }
    }
}




