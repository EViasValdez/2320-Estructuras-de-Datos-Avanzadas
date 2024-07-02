using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor del nodo raíz");
			int Raiz = int.Parse(Console.ReadLine());

      		int[] Array1 = new int[0];
      		int[] Array2 = new int[0];
      		int[] Array3 = new int[0];

			string Resp;
			int Nodo;

			do
			{
				Console.WriteLine("¿Contiene relación a la izquierda? S/N");
				Resp = Console.ReadLine();
			} while (Resp != "S" && Resp != "N");
			
			if (Resp == "S")
			{
				Console.WriteLine("Ingrese el valor del nodo izquierdo");
				Nodo = int.Parse(Console.ReadLine());
				Array2[0] = Nodo;
			
				do
				{
					Console.WriteLine("¿Contiene relación a la izquierda? S/N");
					Resp = Console.ReadLine();
				} while (Resp != "S" && Resp != "N");
			
				if (Resp == "S")
				{
					Console.WriteLine("Ingrese el valor del nodo izquierdo:");
					Nodo = int.Parse(Console.ReadLine());
					Array3[0] = Nodo;

					// Temporal
					Resp = "S";
				}
			
				if (Resp == "N")
				{
					do
					{
						Console.WriteLine("¿Contiene relación a la derecha? S/N");
						Resp = Console.ReadLine();
					} while (Resp != "S" && Resp != "N");

					if (Resp == "S")
					{
						Console.WriteLine("Ingrese el valor del nodo derecho");
						Nodo = int.Parse(Console.ReadLine());
						Array3[1] = Nodo;
					}
				}
				// Temporal
				Resp = "N";
			}
			if (Resp == "N")
			{
				do
				{
					Console.WriteLine("¿Contiene relación a la derecha? S/N: ");
					Resp = Console.ReadLine();
				} while (Resp != "S" && Resp != "N");
			
				if (Resp == "S")
				{
					Console.WriteLine("Ingrese el valor del nodo derecho");
					Nodo = int.Parse(Console.ReadLine());
					Array2[1] = Nodo;
				}
			}
			string TextArray1 = "", TextArray2 = "", TextArray3 = "";

			foreach (int a in Array1)
			{
				TextArray1 = TextArray1 + a;
			}
			foreach (int a in Array2)
			{
				TextArray2 = TextArray2 + a + ",";
			}
			foreach (int a in Array3)
			{
				TextArray3 = TextArray3 + a + ",";
			}
			Console.WriteLine(TextArray1);
			Console.WriteLine(TextArray2);
			Console.WriteLine(TextArray3);
			Console.ReadKey();
        }
    }
}