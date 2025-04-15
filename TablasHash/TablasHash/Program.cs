using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablasHash
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable Tb = new Hashtable();

            Tb.Add(1, "Jalisco");
            Tb.Add(2, "Mexico");
            Tb.Add(3, "Veracruz");
            Tb.Add(4, "Chiapas");
            Tb.Add(5, "Guerrero");

            foreach (DictionaryEntry Estados in Tb)
            {
                Console.WriteLine(Estados.Key + " " + Estados.Value);
            }

            Tb.Add(6, "Guerrero");
            Console.WriteLine("-----------------------------------");
            foreach (DictionaryEntry Estados in Tb)
            {
                Console.WriteLine(Estados.Key + " " + Estados.Value);
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine(Tb.Count);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine(Tb.Contains(7));

            Console.WriteLine("-----------------------------------");
            Tb.Remove(6);

            Console.WriteLine("-----------------------------------");
            foreach (string b in Tb.Values)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("-----------------------------------");
            foreach (int c in Tb.Keys)
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

                if (Tb.Contains(ValorBuscado))
                {
                    Console.WriteLine("El valor " + ValorBuscado + " existe en la tabla");
                }
                else
                {
                    Console.WriteLine("El valor " + ValorBuscado + " no existe en la tabla");
                }
            }
            else
            if (Tipo == 2)
            {
                Console.WriteLine("Ingrese el valor a buscar: ");
                string ValorBuscado = Console.ReadLine();
                
                bool Encuentra = false;

                foreach (string Val in Tb.Values)
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