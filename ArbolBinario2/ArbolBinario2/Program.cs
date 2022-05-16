using System;

namespace ArbolBinario2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor del nodo raiz");
			int raiz = int.Parse(Console.ReadLine());

      		int [] array1 = new int [0];
      		int [] array2 = new int [0];
      		int [] array3 = new int [0];
            
			string resp;
			int nodo;
            
			do
			{
				Console.WriteLine("¿Contiene relacion a la izquierda? S/N");
				resp = Console.ReadLine();
			} while (resp != "S" && resp != "N");
			
			if (resp == "S")
			{
				Console.WriteLine("Ingrese el valor del nodo izquierdo");
				nodo = int.Parse(Console.ReadLine());
				array2 [0] = nodo;
			
				do
				{
					Console.WriteLine("¿Contiene relacion a la izquierda? S/N");
					resp = Console.ReadLine();
				} while (resp != "S" && resp != "N");
			
				if (resp == "S")
				{
					Console.WriteLine("Ingrese el valor del nodo izquierdo:");
					nodo = int.Parse(Console.ReadLine());
					array3 [0] = nodo;

					// Temporal
					resp = "S";
				}
			
				if (resp == "N")
				{
					do
					{
						Console.WriteLine("¿Contiene relacion a la derecha? S/N");
						resp = Console.ReadLine();
					} while (resp != "S" && resp != "N");

					if (resp == "S")
					{
						Console.WriteLine("Ingrese el valor del nodo derecho");
						nodo = int.Parse(Console.ReadLine());
						array3 [1] = nodo;
					}
				}
				// Temporal
				resp = "N";
			}
			if (resp == "N")
			{
				do
				{
					Console.WriteLine("¿Contiene relacion a la derecha? S/N: ");
					resp = Console.ReadLine();
				} while (resp != "S" && resp != "N");
			
				if (resp == "S")
				{
					Console.WriteLine("Ingrese el valor del nodo derecho");
					nodo = int.Parse(Console.ReadLine());
					array2 [1] = nodo;
				}
			}
			string textarray1 = "", textarray2 = "", textarray3 = "";

			foreach (int a in array1)
			{
				textarray1 = textarray1 + a;
			}
			foreach (int a in array2)
			{
				textarray2 = textarray2 + a + ",";
			}
			foreach (int a in array3)
			{
				textarray3 = textarray3 + a + ",";
			}
			Console.WriteLine(textarray1);
			Console.WriteLine(textarray2);
			Console.WriteLine(textarray3);
			Console.ReadKey();
        }
    }
}