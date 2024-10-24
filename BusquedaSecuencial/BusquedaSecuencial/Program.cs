using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaSecuencial
{
    class Program
    {
        static void Main(string[] args)
        {
            BuscarObjeto();
            Console.ReadKey();
        }

        public static void BusquedaEntero()
        {
            int [] ArrayCont = new int [10];
            
            for (int i = 0; i < ArrayCont.Length; i++)
            {
                Console.WriteLine("Ingrese el numero " + i);
                ArrayCont[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese el elemento a buscar");
            int Valor = int.Parse(Console.ReadLine());

            int Cont = 0;
            bool Res = false;

            foreach (int a in ArrayCont)
            {
                if (a == Valor)
                {
                    Console.WriteLine("El valor buscado se encuentra en el indice " + Cont);
                }
                else
                {
                    Console.WriteLine("No se encuentra el elemento buscado");
                }
                Cont++;
            }
            if (Res)
            {
                Console.WriteLine("No se encuentra el elemento buscado");
            }

        }
        public static void BusquedaListas()
        {
            List <string> list = new List<string>();

            list.Add("Juan");
            list.Add("Francisco");
            list.Add("Johana");
            list.Add("Alexis");
            list.Add("Johan");
            list.Add("Luis");
            list.Add("Andres");
            list.Add("Rogelio");

            Console.WriteLine("Ingrese el valor a buscar");
            string ValorBuscado = Console.ReadLine();

            int Cont = 0;
            bool Res = false;

            foreach (string b in list)
            {
                if (b == ValorBuscado)
                {
                    Console.WriteLine("El valor se encuentra en el indice " + Cont);
                    Res = true;
                }
                Cont++;

                if (Res == false)
                {
                    Console.WriteLine("No se encuentra el elemento buscado");
                }
            }
        }

        public static void BuscarObjeto()
        {
            List <Listas> objPersona = new List<Listas>();

            objPersona.Add(new Listas() {Id = 1, Nombre = "Juan", ApellidoPaterno = "Hernandez", ApellidoMaterno = "Velazquez"});
            objPersona.Add(new Listas() {Id = 2, Nombre = "Rogelio", ApellidoPaterno = "Sanchez", ApellidoMaterno = "Hernanadez" });
            objPersona.Add(new Listas() {Id = 3, Nombre = "Manuel", ApellidoPaterno = "Alvarez", ApellidoMaterno = "Noh" });

            foreach (Listas c in objPersona)
            {
                Console.WriteLine("Id: " + c.Id + ", Nombre: " + c.Nombre);
            }

            Console.WriteLine("Ingrese el dato a buscar: ");
            string ValorBuscado = Console.ReadLine();

            bool Resp = false;

            foreach (Listas a in objPersona)
            {
                if (a.Nombre == ValorBuscado || a.ApellidoPaterno == ValorBuscado || a.ApellidoMaterno == ValorBuscado)
                {
                    Console.WriteLine("El valor buscado se encuentra con el ID " + a.Id);
                    Resp = true;
                }
                if (Resp == false)
                {
                    Console.WriteLine("El valor no fue encontrado");
                }
            }
        }
    }
}