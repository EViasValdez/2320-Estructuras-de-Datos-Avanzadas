using System;
using System.Collections;

namespace TablasHash
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable tb = new Hashtable();

            tb.Add(1, "Jalisco");
            tb.Add(2, "Mexico");
            tb.Add(3, "Veracruz");
            tb.Add(4, "Chiapas");
            tb.Add(5, "Guerrero");

            foreach (DictionaryEntry Estados in tb)
            {
                Console.WriteLine(Estados.Key + " " + Estados.Value);
            }

            tb.Add (6, "Guerrero");
            Console.WriteLine("-----------------------------------");
            foreach (DictionaryEntry Estados in tb)
            {
                Console.WriteLine(Estados.Key + " " + Estados.Value);
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
            int Tipo = int.Parse(Console.ReadLine());

            if (Tipo == 1)
            {
                Console.WriteLine("Ingrese el Id a buscar");
                int ValorBuscado = int.Parse(Console.ReadLine());

                if (tb.Contains(ValorBuscado))
                {
                    Console.WriteLine("El valor " + ValorBuscado + " existe en la tabla");
                }
                else
                {
                    Console.WriteLine("El valor " + ValorBuscado + " no existe en la tabla");
                }
            }
            else if (Tipo == 2)
            {
                Console.WriteLine("Ingrese el valor a buscar: ");
                string ValorBuscado = Console.ReadLine();
                
                bool Encuentra = false;

                foreach (string Val in tb.Values)
                {
                    if (Val == ValorBuscado)
                    {
                        Console.WriteLine("El valor " + ValorBuscado + " existe en la tabla");
                        Encuentra = true;
                    }
                    if (Encuentra)
                    {
                        Console.WriteLine("El valor " + ValorBuscado + " no existe en la tabla");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}