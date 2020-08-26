using System;
using System.Collections.Generic;

namespace Recuperatorio
{
    class Program
    {
        static void Main(string[] args)

        {
            List<Personaje> personajes = new List<Personaje>();
            personajes.Add(new Zombie());
            personajes.Add(new Zombie());
            personajes.Add(new NoInfectado());
            RecorrerYMostrar(personajes);
        }

        private static void RecorrerYMostrar(List<Personaje> personajes)
        {
            int n = 1;
            foreach (Personaje item in personajes)
            {
                Console.WriteLine($"El personaje {n}:");
                if (item.Vive() == true)
                {
                    Console.WriteLine("Esta vivo y no es un Zombie!");
                }
                else
                {
                    Console.WriteLine("Definitivamente no esta vivo...");
                }
                Console.WriteLine(item.Come());
                Console.WriteLine(item.Camina());
                Console.WriteLine($"Dice: {item.Habla()}");
                Console.WriteLine();
                n++;
            }

            Console.ReadKey();
        }
    }
}
