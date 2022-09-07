using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registros
{
	public class Cliente
	{
		public string Nombres { get; set; }
		public string Apellidos { get; set; }
		public string Telefono { get; set; }
		public string Correo { get; set; }

		public void MostrarCliente() {
			List <Cliente> ListaCliente = new List <Cliente>();

			Console.WriteLine("Ingrese nombre(s))");
			string nombres = Console.ReadLine();
			Console.WriteLine("Ingrese apellidos");
			string apellidos = Console.ReadLine();
			Console.WriteLine("Ingrese telefono");
			string telefono = Console.ReadLine();
			Console.WriteLine("Ingrese correo");
			string correo = Console.ReadLine();
		}
	}
}
