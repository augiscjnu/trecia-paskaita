using System;

namespace PirmaPaskaita1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu");
            int a = int.Parse(Console.ReadLine());


            while (a < 0)
            {
                
                if (a % 2 = 0)
                {
                    Console.WriteLine("skaicius yra lyginis");

                  
                }
                else 
                {
                    Console.WriteLine("skaicius nera lyginis");

                
                }
               

                a = int.Parse(Console.ReadLine());




            }


            Console.WriteLine("skaicius nera lyginis");


        }
    }
}




