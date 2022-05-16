using System;
using System.Collections.Generic;

namespace BusquedaSecuencial
{
    class Program
    {
        static void Main(string[] args)
        {
            buscarObjeto();
            Console.ReadKey();
        }

        public static void busquedaEntero()
        {
            int [] arrayCont = new int [10];
            
            for (int i = 0; i < arrayCont.Length; i++)
            {
                Console.WriteLine("Ingrese el numero " + i);
                arrayCont[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese el elemento a buscar");
            int valor = int.Parse(Console.ReadLine());

            int cont = 0;
            bool res = false;

            foreach (int a in arrayCont)
            {
                if (a == valor)
                {
                    Console.WriteLine("El valor buscado se encuentra en el indice " + cont);
                }
                else
                {
                    Console.WriteLine("No se encuentra el elemento buscado");
                }
                cont++;
            }
            if (res)
            {
                Console.WriteLine("No se encuentra el elemento buscado");
            }

        }
        public static void busquedaString()
        {
        
        }
        public static void busquedaListas()
        {
            List<string> list = new List<string>();

            list.Add ("Juan");
            list.Add ("Francisco");
            list.Add ("Johana");
            list.Add ("Alexis");
            list.Add ("Johan");
            list.Add ("Luis");
            list.Add ("Andres");
            list.Add ("Rogelio");

            Console.WriteLine("Ingrese el valor a buscar");
            string valorbuscado = Console.ReadLine();

            int cont = 0;
            bool res = false;

            foreach (string b in list)
            {
                if (b == valorbuscado)
                {
                    Console.WriteLine("El valor se encuentra en el indice " + cont);
                    res = true;
                }
                cont++;

                if (res == false)
                {
                    Console.WriteLine("No se encuentra el elemento buscado");
                }
            }
        }

        public static void buscarObjeto()
        {
            List<Listas> objPersona = new List<Listas>();

            objPersona.Add (new Listas(){id = 1, nombre = "Juan", apellidopaterno = "Hernandez", apellidomaterno = "Velazquez"});
            objPersona.Add (new Listas(){id = 2, nombre = "Rogelio", apellidopaterno = "Sanchez", apellidomaterno = "Hernanadez" });
            objPersona.Add (new Listas(){id = 3, nombre = "Manuel", apellidopaterno = "Alvarez", apellidomaterno = "Noh" });

            foreach (Listas c in objPersona)
            {
                Console.WriteLine("Id: " + c.id + ", Nombre: " + c.nombre);
            }

            Console.WriteLine("Ingrese el dato a buscar: ");
            string valorbuscado = Console.ReadLine();

            bool resp = false;

            foreach (Listas a in objPersona)
            {
                if (a.nombre == valorbuscado || a.apellidopaterno == valorbuscado || a.apellidomaterno == valorbuscado)
                {
                    Console.WriteLine("El valor buscado se encuentra con el id " + a.id);
                    resp = true;
                }
                if (resp == false)
                {
                    Console.WriteLine("El valor no fue encontrado");
                }
            }
        }
    }
}