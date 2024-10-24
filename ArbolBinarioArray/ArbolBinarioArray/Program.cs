using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioArray
{
    class Program
    {
        public static int[] Array1 = new int[1];
        public static int[] Array2 = new int[2];
        public static int[] Array3 = new int[4];
        public static int[] Array4 = new int[8];

        static void Main(string[] args)
        {
            // Llenar();
            LlenarDefault();
            Imprimir();
            Eliminar();
            Imprimir();

            Console.ReadKey();
        }
        public static void LlenarDefault()
        {
            Array1[0] = 100;
            Array2[0] = 20;
            Array2[1] = 12;
            Array3[0] = 1;
            Array3[1] = 2;
            Array3[3] = 2;
            Array4[0] = 1;
            Array4[1] = 3;
            Array4[3] = 1;
            Array4[6] = 7;
            Array4[7] = 8;
        }
        public static void Llenar()
        {
            Console.WriteLine("Ingrese el valor del nodo raíz:");
            int Raiz = int.Parse(Console.ReadLine());

            Array1[0] = Raiz;

            string Resp;
            int nodo;

            Resp = IzquierdaDerecha(1);
            if (Resp == "S")
            {
                Guardar(1, 2, 0);
                Resp = IzquierdaDerecha(1);

                if (Resp == "S")
                {
                    Guardar(1, 3, 0);

                    Resp = IzquierdaDerecha(1);
                    if (Resp == "S")
                    {
                        Guardar(1, 4, 0);
                        Console.WriteLine("El nodo llego a su limite");

                        // Temporal.
                        Resp = "N";
                    }
                    if (Resp == "N")
                    {
                        Resp = IzquierdaDerecha(2);

                        if (Resp == "S")
                        {
                            Guardar(2, 4, 1);
                            Console.WriteLine("El nodo llego a su limite");
                        }
                    }
                    // Temporal.
                    Resp = "N";
                }
                if (Resp == "N")
                {
                    Resp = IzquierdaDerecha(2);

                    if (Resp == "S")
                    {
                        Guardar(2, 3, 1);

                        Resp = IzquierdaDerecha(1);
                        if (Resp == "S")
                        {
                            Guardar(1, 4, 2);
                            Console.WriteLine("El nodo llego a su limite");
                            // Temporal.
                            Resp = "N";
                        }
                        if (Resp == "N")
                        {
                            Resp = IzquierdaDerecha(2);

                            if (Resp == "S")
                            {
                                Guardar(2, 4, 3);
                                Console.WriteLine("El nodo llego a su limite");
                            }
                        }
                        // Temporal.
                        Resp = "N";
                    }
                }
                // Temporal.
                Resp = "N";
            }
            if (Resp == "N")
            {
                Resp = IzquierdaDerecha(2);

                if (Resp == "S")
                {
                    Guardar(2, 2, 1);
                    Resp = IzquierdaDerecha(1);

                    if (Resp == "S")
                    {
                        Guardar(1, 3, 2);

                        Resp = IzquierdaDerecha(1);
                        if (Resp == "S")
                        {
                            Guardar(1, 4, 4);
                            Console.WriteLine("El nodo llego a su limite");

                            // Temporal.
                            Resp = "N";
                        }
                        if (Resp == "N")
                        {
                            Resp = IzquierdaDerecha(2);

                            if (Resp == "S")
                            {
                                Guardar(2, 4, 5);
                                Console.WriteLine("El nodo llego a su limite");
                            }
                        }
                        // Temporal.
                        Resp = "N";
                    }
                    if (Resp == "N")
                    {
                        Resp = IzquierdaDerecha(2);

                        if (Resp == "S")
                        {
                            Guardar(2, 3, 3);
                            Resp = IzquierdaDerecha(1);

                            if (Resp == "S")
                            {
                                Guardar(1, 4, 6);
                                Console.WriteLine("El nodo llego a su limite");

                                // Temporal.
                                Resp = "N";
                            }
                            if (Resp == "N")
                            {
                                Resp = IzquierdaDerecha(2);
                                if (Resp == "S")
                                {
                                    Guardar(2, 4, 7);
                                    Console.WriteLine("El nodo llego a su limite");
                                }
                            }
                            // Temporal.
                            Resp = "N";
                        }
                    }
                    // Temporal.
                    Resp = "N";
                }
            }
        }
        public static void Guardar(int Valor, int Nivel, int Indice)
        {
            int Nodo;

            if (Valor == 1)
            {
                Console.WriteLine("Ingrese el valor del nodo izquierdo:");
            }
            else if (Valor == 2)
            {
                Console.WriteLine("Ingrese el valor del nodo derecho:");
            }

            Nodo = int.Parse(Console.ReadLine());

            if (Nivel == 2)
            {
                Array2[Indice] = Nodo;
            }
            else if (Nivel == 3)
            {
                Array3[Indice] = Nodo;
            }
            else if (Nivel == 4)
            {
                Array4[Indice] = Nodo;
            }
        }
        public static string IzquierdaDerecha(int Valor)
        {
            string Resp = " ";

            do
            {
                if (Valor == 1)
                {
                    Console.WriteLine("¿Contiene relación a la izquierda? S/N");
                }
                else if (Valor == 2)
                {
                    Console.WriteLine("¿Contiene relación a la Derecha? S/N");
                }

                Resp = Console.ReadLine();
                if ((Resp != "S" && Resp != "N"))
                {
                    Console.WriteLine("Esa opción no es valida");
                }
            } while (Resp != "S" && Resp != "N");
            return Resp;
        }

        public static void Imprimir()
        {
            string TextArray1 = "", TextArray2 = "", TextArray3 = "", TextArray4 = "";
            string Linea1 = "", Linea2 = "", Linea3 = "", Linea4 = "", Linea5 = "";
            int Contador = 0;

            foreach (int a in Array1)
            {
                TextArray1 = TextArray1 + a;
            }
            foreach (int a in Array2)
            {
                if (a == 0)
                {
                    TextArray2 = TextArray2 + " " + "           ";
                    if (Contador == 0)
                    {
                        Linea1 = " " + "     ";
                        Linea2 = " " + "       ";
                        Linea3 = " " + "         ";
                    }
                    else
                    {
                        Linea1 = Linea1 + " ";
                        Linea2 = Linea2 + " ";
                        Linea3 = Linea3 + " ";
                        Contador = -1;
                    }
                }
                else
                {
                    TextArray2 = TextArray2 + a + "           ";
                    if (Contador == 0)
                    {
                        Linea1 = "/" + "     ";
                        Linea2 = "/" + "       ";
                        Linea3 = "/" + "         ";
                    }
                    else
                    {
                        Linea1 = Linea1 + "\\";
                        Linea2 = Linea2 + "\\";
                        Linea3 = Linea3 + "\\";
                        Contador = -1;
                    }

                }
                Contador++;
            }
            Contador = 0;
            foreach (int a in Array3)
            {
                if (a == 0)
                {
                    TextArray3 = TextArray3 + " " + "     ";
                    if (Contador == 0)
                    {
                        Linea4 = Linea4 + " " + "   ";
                    }
                    else
                    {
                        Linea4 = Linea4 + " " + "       ";
                        Contador = -1;
                    }
                }
                else
                {
                    TextArray3 = TextArray3 + a + "     ";
                    if (Contador == 0)
                    {
                        Linea4 = Linea4 + "/" + "   ";
                    }
                    else
                    {
                        Linea4 = Linea4 + "\\" + "       ";
                        Contador = -1;
                    }
                }
                Contador++;
            }
            foreach (int a in Array4)
            {
                if (a == 0)
                {
                    TextArray4 = TextArray4 + " " + "  ";
                    if (Contador == 0)
                    {
                        Linea5 = Linea5 + " " + " ";
                    }
                    else
                    {
                        Linea5 = Linea5 + " " + "   ";
                        Contador = -1;
                    }
                }
                else
                {
                    TextArray4 = TextArray4 + a + "  ";
                    if (Contador == 0)
                    {
                        Linea5 = Linea5 + "/" + " ";
                    }
                    else
                    {
                        Linea5 = Linea5 + "\\" + "   ";
                        Contador = -1;
                    }
                }
                Contador++;
            }
            Console.WriteLine("                  " + TextArray1);
            // Console.WriteLine("               " + "/" + "     " + "\\");
            // Console.WriteLine("              " + "/" + "       " + "\\");
            // Console.WriteLine("             " + "/" + "         " + "\\");
            Console.WriteLine("               " + Linea1);
            Console.WriteLine("              " + Linea2);
            Console.WriteLine("             " + Linea3);
            Console.WriteLine("            " + TextArray2);
            // Console.WriteLine("          " + "/" + "   " + "\\" + "       " + "/" + "   " + "\\");
            Console.WriteLine("          " + Linea4);
            Console.WriteLine("         " + TextArray3);
            // Console.WriteLine("        " + "/" + " " + "\\" + "   " + "/" + " " + "\\" + "   " + "/" + " " + "\\" + "   " + "/" + " " + "\\");
            Console.WriteLine("        " + Linea5);
            Console.WriteLine("       " + TextArray4);
        }
        public static void Eliminar()
        {
            Console.WriteLine("¿Desea eliminar un nodo o una hoja? S/N");
            string Resp = Console.ReadLine();

            if (Resp == "S")
            {
                int Nivel = 0;

                do
                {
                    Console.WriteLine("¿Que desea eliminar la hoja o el nodo?");
                    Nivel = int.Parse(Console.ReadLine());
                    if (Nivel < 1 || Nivel > 5)
                    {
                        Console.WriteLine("Valor incorrecto, solo se puede seleccionar un valor entre el 1 y el 4");
                    }
                } while (Nivel < 1 || Nivel > 5);

                ImprimirNivel(Nivel);

                int NodoEliminar;
                int Incorrecto = 0;

                do
                {
                    Console.WriteLine("Indique la posición del nodo a Eliminar");
                    NodoEliminar = int.Parse(Console.ReadLine());

                    if (Nivel == 1 && (NodoEliminar > 0 || NodoEliminar < 0))
                    {
                        Console.WriteLine("El nodo a Eliminar es incorrecto");
                    }
                    else if (Nivel == 2 && (NodoEliminar > 1 || NodoEliminar < 0))
                    {
                        Console.WriteLine("El nodo a Eliminar es incorrecto");
                    }
                    else if (Nivel == 3 && (NodoEliminar > 3 || NodoEliminar < 0))
                    {
                        Console.WriteLine("El nodo a Eliminar es incorrecto");
                    }
                    else if (Nivel == 4 && (NodoEliminar > 7 || NodoEliminar < 0))
                    {
                        Console.WriteLine("El nodo a Eliminar es incorrecto");
                    }
                    else
                    {
                        Incorrecto = 1;
                    }
                } while (Incorrecto == 0);
                if (Nivel == 1)
                {
                    Array1[NodoEliminar] = 0;
                }
                else if (Nivel == 2)
                {
                    Array2[NodoEliminar] = 0;
                }
                else if (Nivel == 3)
                {
                    Array3[NodoEliminar] = 0;
                }
                else if (Nivel == 4)
                {
                    Array4[NodoEliminar] = 0;
                }
                for (int i = 0; i < Array1.Length; i++)
                {
                    if (Array1[i] == 0)
                    {
                        Array2[0] = 0;
                        Array2[1] = 0;
                    }
                    int a = 0, b = 1;
                    for (int j = 0; j < Array2.Length; j++)
                    {
                        if (Array2[j] == 0)
                        {
                            Array3[a] = 0;
                            Array3[b] = 0;
                        }
                        int c = 0, d = 1;
                        for (int k = 0; k < Array3.Length; k++)
                        {
                            if (Array3[k] == 0)
                            {
                                Array4[c] = 0;
                                Array4[d] = 0;
                            }
                            c = c + 2;
                            d = d + 2;
                        }
                        a = a + 2;
                        b = b + 2;
                    }
                }
            }
        }
        public static void ImprimirNivel(int Nivel)
        {
            string Valor = "  |  ";
            string Posicion = "  |  ";

            if (Nivel == 1)
            {
                for (int i = 0; i < Array1.Length; i++)
                {
                    if (Array1[i] > 0)
                    {
                        Posicion = Posicion + i + "   |   ";
                        Valor = Valor + Array1[i] + "   |" + "   ";
                    }
                }
                Console.WriteLine(Posicion + "Posición");
                Console.WriteLine(Valor + "Valor");
            }
            else if (Nivel == 2)
            {
                for (int i = 0; i < Array2.Length; i++)
                {
                    if (Array2[i] > 0)
                    {
                        Posicion = Posicion + i + "   |   ";
                        Valor = Valor + Array2[i] + "   |  ";
                    }
                }
                Console.WriteLine(Posicion + "Posición");
                Console.WriteLine(Valor + "Valor");
            }
            else if (Nivel == 3)
            {
                for (int i = 0; i < Array3.Length; i++)
                {
                    if (Array3[i] > 0)
                    {
                        Posicion = Posicion + i + "   |   ";
                        Valor = Valor + Array3[i] + "   |   ";
                    }
                }
                Console.WriteLine(Posicion + "Posición");
                Console.WriteLine(Valor + "Valor");
            }
            else if (Nivel == 4)
            {
                for (int i = 0; i < Array4.Length; i++)
                {
                    if (Array4[i] > 0)
                    {
                        Posicion = Posicion + i + "   |   ";
                        Valor = Valor + Array4[i] + "   |   ";
                    }
                }
                Console.WriteLine(Posicion + "Posición");
                Console.WriteLine(Valor + "Valor");
            }
        }
    }
}