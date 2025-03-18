using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace BusquedaBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] Arreglo = new int [10];

            for (int i = 0; i < Arreglo.Length; i++)
            {
                Console.WriteLine("Ingrese el numero " + i + " para su almacenamiento");
                Arreglo[i] = int.Parse(Console.ReadLine());
            }

            int Aux;

            for (int i = 0; i < Arreglo.Length; i++)
            {
                for (int j = 0; j < Arreglo.Length - 1; j++)
                {
                    if (Arreglo[j] > Arreglo[j + 1])
                    {
                        Aux = Arreglo[j];
                        Arreglo[j] = Arreglo[j + 1];
                        Arreglo[j + 1] = Aux;
                    }
                }
            }
            Console.Clear();
            foreach (int b in Arreglo)
            {
                Console.WriteLine();
            }

            Console.WriteLine("Ingrese el valor a buscar");
            int ValorBuscado = int.Parse(Console.ReadLine());

            int Final = Arreglo.Length - 1;
            int Inicio = 0;
            bool z = false;
            int Media;

            do
            {
                Media = (Inicio + Final) / 2;
                if (ValorBuscado == Arreglo[Media])
                {
                    Console.WriteLine("El valor buscado se encuentra en el indice " + Media);
                    z = true;
                }
                else
                if (ValorBuscado > Arreglo[Media])
                {
                    Final = Media - 1;
                }
                else
                if (ValorBuscado < Arreglo[Media])
                {
                    Inicio = Media + 1;
                }
            } while (z == false);
            Console.ReadKey();
        }
    }
}