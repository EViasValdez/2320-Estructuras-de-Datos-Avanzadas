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
            string marca = Console.ReadLine();
            Console.WriteLine("Ingrese modelo");
            string modelo = Console.ReadLine();
            Console.WriteLine("Ingrese año");
            string anio = Console.ReadLine();
            Console.WriteLine("Ingrese tipo");
            string tipo = Console.ReadLine();
            Console.WriteLine("Ingrese precio");
            string precio = Console.ReadLine();
        }
    }
}