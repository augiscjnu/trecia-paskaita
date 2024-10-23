using System;

namespace PirmaPaskaita1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("iveskite skaiciu:");
                int a = int.Parse(Console.ReadLine());
                string g = "savaites diena";

                switch (a)
                {
                    case 1:
                         g = "pirmadienis";
                        break;
                    case 2:
                        g = "antradienis";
                        break;
                    case 3:
                        g = "treciadienis";
                        break;
                    case 4:
                        g = "ketvirtadienis";
                        break;
                    case 5:
                        g = "penktadienis";
                        break;
                    case 6:
                        g = "sestadienis";
                        break;
                    case 7:
                        g = "sekmadienis";
                        break;

                    default:
                        Console.WriteLine("nesanti diena");
                        Console.WriteLine();
                        continue;



                }
                Console.WriteLine($"siandien yra  {g}");
                Console.WriteLine();

            }
        }
    }
}




