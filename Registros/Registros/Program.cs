using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Registro de vehiculos");
            Console.WriteLine("=====================");
            Console.ReadKey();

            Console.WriteLine("Eliga una opcion");
            Console.WriteLine("1. Dar de alta a un auto");
            Console.WriteLine("2. Buscar un auto");
            Console.WriteLine("3. Ordenar un auto");
            Console.WriteLine("4. Quitar un auto");
            Console.WriteLine("5. Dar de alta a un cliente");
            Console.WriteLine("6. Buscar cliente");

            int Opcion = int.Parse(Console.ReadLine());

            bool Confirmar, Busqueda = false;
            string SN;

            switch (Opcion) {
            case 1:
                Console.WriteLine("Dar de alta a un auto");
                
                do
                {
                    Auto AutoNuevo = new Auto();
                    AutoNuevo.MostrarAuto();

                    Console.WriteLine("¿Desea agregar otro dato?");
                    Console.WriteLine("Si / No");
                    SN = Console.ReadLine();

                    Confirmar = true;

                    if (SN.ToLower().Equals("no"))
                    {
                        Confirmar = false;
                    }
                } while (Confirmar);
            break;

            case 2:
                Console.WriteLine("Buscar un auto");
            break;

            case 3:
                Console.WriteLine("Ordenar un auto");
            break;

            case 4:
                Console.WriteLine("Quitar un auto");
            break;

            case 5:
                Console.WriteLine("Dar de alta a un cliente");

                do
                {
                    Cliente ClienteNuevo = new Cliente();
                    ClienteNuevo.MostrarCliente();

                    Console.WriteLine("¿Desea agregar otro dato?");
                    Console.WriteLine("Si / No");
                    SN = Console.ReadLine();

                    Confirmar = true;

                    if (SN.ToLower().Equals("no"))
                    {
                        Confirmar = false;
                    }
                } while (Confirmar);
            break;

            case 6:
                Console.WriteLine("Buscar cliente");
            break;

            // Console.WriteLine("¿Desea realizar otra opcion?");
            // SN = Console.ReadLine();
            }
        }
    }
}