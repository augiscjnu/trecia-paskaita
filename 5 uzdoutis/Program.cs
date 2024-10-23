using System;

namespace PirmaPaskaita1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu pridejimui");
            int a = int.Parse(Console.ReadLine());

            int s = 0;

            while (s <= 100)
            {
                s = s + a;
                if (s > 100)
                {
                    break;
                }

                Console.WriteLine($"suma: {s}, teskite ivedima");
                Console.WriteLine();

                a = int.Parse(Console.ReadLine());




            }

            Console.WriteLine("suma vyrsita");
            Console.WriteLine($"suma: {s}");

        }
    }
}




