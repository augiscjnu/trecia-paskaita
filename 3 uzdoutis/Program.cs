﻿using System;

namespace PirmaPaskaita1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("iveskite amziu :");
                int amzius = int.Parse(Console.ReadLine());
                string grupe = "grupe";

                switch (amzius)
                {
                    case >= 1 and < 13:
                        grupe = "vaikas";
                        break;
                    case >= 13 and < 18:
                        grupe = "paauglys";
                        break;
                    case >= 18 and < 65:
                        grupe = "suauges";
                        break;
                    case >= 65 and < 120:
                        grupe = "senjoras";
                        break;
                    case >= 120:
                        grupe = "ko gero negyvas";
                        break;
                    default:
                        Console.WriteLine("nevalidus amzius");
                        Console.WriteLine();
                        continue;



                }
                Console.WriteLine($"{amzius} m vartotojas yra {grupe}");
                Console.WriteLine();

            }
        }
    }
}



        
