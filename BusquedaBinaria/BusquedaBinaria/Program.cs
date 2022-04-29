using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace BusquedaBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[10];

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("Ingrese el numero " + i + " para su almacenamiento");
                arreglo[i] = int.Parse(Console.ReadLine());
            }

            int aux;

            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = 0; j < arreglo.Length - 1; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        aux = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = aux;
                    }
                }

            }

            Console.Clear();
            foreach (int b in arreglo)
            {
                Console.WriteLine();
            }

            Console.WriteLine("Ingrese el valor a buscar: ");
            int valorbuscado = int.Parse(Console.ReadLine());

            int final = arreglo.Length - 1;
            int inicio = 0;
            bool z = false;
            int media;

            do
            {
                media = (inicio + final) / 2;

                if (valorbuscado == arreglo[media])
                {
                    Console.WriteLine("El valor buscado se encuentra en el indice " + media);
                    z = true;
                }
                else if (valorbuscado > arreglo[media])
                {
                    final = media - 1;
                }
                else if (valorbuscado < arreglo[media])
                {
                    inicio = media + 1;
                }

            } while (z == false);

            Console.ReadKey();

        }
    }
}
