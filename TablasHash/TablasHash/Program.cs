using System;
using System.Collections;

namespace TablasHash
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable tb = new Hashtable();

            tb.Add (1, "Jalisco");
            tb.Add (2, "Mexico");
            tb.Add (3, "Veracruz");
            tb.Add (4, "Chiapas");
            tb.Add (5, "Guerrero");

            foreach (DictionaryEntry estados in tb)
            {
                Console.WriteLine(estados.Key + " " + estados.Value);
            }

            tb.Add (6, "Guerrero");
            Console.WriteLine("-----------------------------------");
            foreach (DictionaryEntry estados in tb)
            {
                Console.WriteLine(estados.Key + " " + estados.Value);
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine(tb.Count);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine(tb.Contains(7));

            Console.WriteLine("-----------------------------------");
            tb.Remove (6);

            Console.WriteLine("-----------------------------------");
            foreach (string b in tb.Values)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("-----------------------------------");
            foreach (int c in tb.Keys)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1. Buscar elemento con Id");
            Console.WriteLine("2. Buscar elemento con valor");
            Console.WriteLine("3. Valor indice");
            Console.WriteLine("Ingrese una opción");
            int tipo = int.Parse(Console.ReadLine());

            if (tipo == 1)
            {
                Console.WriteLine("Ingrese el Id a buscar");
                int valorBuscado = int.Parse(Console.ReadLine());

                if (tb.Contains(valorBuscado))
                {
                    Console.WriteLine("El valor " + valorBuscado + " existe en la tabla");
                }
                else
                {
                    Console.WriteLine("El valor " + valorBuscado + " no existe en la tabla");
                }
            }
            else if (tipo == 2)
            {
                Console.WriteLine("Ingrese el valor a buscar: ");
                string valorBuscado = Console.ReadLine();
                
                bool encuentra = false;

                foreach (string val in tb.Values)
                {
                    if (val == valorBuscado)
                    {
                        Console.WriteLine("El valor " + valorBuscado + " existe en la tabla");
                        encuentra = true;
                    }
                    if (encuentra)
                    {
                        Console.WriteLine("El valor " + valorBuscado + " no existe en la tabla");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}