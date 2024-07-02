using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registros
{
    public class Auto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Anio { get; set; }
        public string Tipo { get; set; }
        public string Precio { get; set; }

        public void MostrarAuto() {
            List <Auto> ListaAuto = new List <Auto>();

            Console.WriteLine("Ingrese marca");
            string Marca = Console.ReadLine();
            Console.WriteLine("Ingrese modelo");
            string Modelo = Console.ReadLine();
            Console.WriteLine("Ingrese año");
            string Anio = Console.ReadLine();
            Console.WriteLine("Ingrese tipo");
            string Tipo = Console.ReadLine();
            Console.WriteLine("Ingrese precio");
            string Precio = Console.ReadLine();
        }
    }
}