using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBiarioArray
{
    class Program
    {
        public static int [] array1 = new int [1];
        public static int [] array2 = new int [2];
        public static int [] array3 = new int [4];
        public static int [] array4 = new int [8];

    static void Main(string[] args)
    {
        // llenar();
        LlenarDefault();
        Imprimir();
        Eliminar();
        Imprimir();

        Console.ReadKey();
    }
    public static void LlenarDefault()
    {
        array1 [0] = 100;
        array2 [0] = 20;
        array2 [1] = 12;
        array3 [0] = 1;
        array3 [1] = 2;
        array3 [3] = 2;
        array4 [0] = 1;
        array4 [1] = 3;
        array4 [3] = 1;
        array4 [6] = 7;
        array4 [7] = 8;
    }
    public static void llenar()
    {
        Console.WriteLine("Ingrese el valor del nodo raíz:");
        int raiz = int.Parse(Console.ReadLine());

        array1 [0] = raiz;

        string Resp;
        int nodo;

        Resp = IzquierdaDerecha (1);
        if (Resp == "S")
            {
            Guardar (1, 2, 0);
            Resp = IzquierdaDerecha (1);

            if (Resp == "S")
            {
                Guardar (1, 3, 0);

                Resp = IzquierdaDerecha (1);
                if (Resp == "S")
                {
                    Guardar (1, 4, 0);
                    Console.WriteLine("El nodo llego a su limite");

                    // Temporal
                    Resp = "N";
                }
                if (Resp == "N")
                {
                    Resp = IzquierdaDerecha (2);

                    if (Resp == "S")
                    {
                        Guardar (2, 4, 1);
                        Console.WriteLine("El nodo llego a su limite");
                    }
                }
                // Temporal
                Resp = "N";
            }
            if (Resp == "N")
            {
                Resp = IzquierdaDerecha (2);

                if (Resp == "S")
                {
                    Guardar (2, 3, 1);

                    Resp = IzquierdaDerecha (1);
                    if (Resp == "S")
                    {
                        Guardar (1, 4, 2);
                        Console.WriteLine("El nodo llego a su limite");
                        // Temporal
                        Resp = "N";
                    }
                    if (Resp == "N")
                    {
                        Resp = IzquierdaDerecha (2);

                        if (Resp == "S")
                        {
                            Guardar (2, 4, 3);
                            Console.WriteLine("El nodo llego a su limite");
                        }
                    }
                    // Temporal
                    Resp = "N";
                }
            }
            // Temporal
            Resp = "N";
        }
        if (Resp == "N")
        {
            Resp = IzquierdaDerecha (2);

            if (Resp == "S")
            {
                Guardar (2, 2, 1);
                Resp = IzquierdaDerecha (1);

                if (Resp == "S")
                {
                    Guardar (1, 3, 2);

                    Resp = IzquierdaDerecha (1);
                    if (Resp == "S")
                    {
                        Guardar (1, 4, 4);
                        Console.WriteLine("El nodo llego a su limite");

                        // Temporal
                        Resp = "N";
                    }
                    if (Resp == "N")
                    {
                        Resp = IzquierdaDerecha (2);

                        if (Resp == "S")
                        {
                            Guardar (2, 4, 5);
                            Console.WriteLine("El nodo llego a su limite");
                        }
                    }
                    // Temporal
                    Resp = "N";
                }
                if (Resp == "N")
                {
                    Resp = IzquierdaDerecha (2);

                    if (Resp == "S")
                    {
                        Guardar (2, 3, 3);
                        Resp = IzquierdaDerecha (1);

                        if (Resp == "S")
                        {
                            Guardar (1, 4, 6);
                            Console.WriteLine("El nodo llego a su limite");

                            // Temporal
                            Resp = "N";
                        }
                        if (Resp == "N")
                        {
                            Resp = IzquierdaDerecha (2);
                            if (Resp == "S")
                            {
                                Guardar (2, 4, 7);
                                Console.WriteLine("El nodo llego a su limite");
                            }
                        }
                        // Temporal
                        Resp = "N";
                    }
                }
                // Temporal
                Resp = "N";
            }
        }
    }
        public static void Guardar(int valor, int nivel, int indice)
        {
            int nodo;

            if (valor == 1)
            {
                Console.WriteLine("Ingrese el Valor del nodo izquierdo:");
            }
            else if (valor == 2)
            {
                Console.WriteLine("Ingrese el Valor del nodo derecho:");
            }

            nodo = int.Parse (Console.ReadLine());

            if (nivel == 2)
            {
                array2 [indice] = nodo;
            }
            else if (nivel == 3)
            {
                array3 [indice] = nodo;
            }
            else if (nivel == 4)
            {
                array4 [indice] = nodo;
            }
        }
        public static string IzquierdaDerecha(int valor)
        {
            string Resp = " ";

            do
            {
                if (valor == 1)
                {
                    Console.WriteLine("¿Contiene relación a la izquierda? S/N");
                }
                else if (valor == 2)
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
            string textarray1 = "", textarray2 = "", textarray3 = "", textarray4 = "";
            string linea1 = "", linea2 = "", linea3 = "", linea4 = "", linea5 = "";
            int Contador = 0;

            foreach (int a in array1)
            {
                textarray1 = textarray1 + a;
            }
            foreach (int a in array2)
            {
                if (a == 0)
                {
                    textarray2 = textarray2 + " " + "           ";
                    if (Contador == 0)
                    {
                        linea1 = " " + "     ";
                        linea2 = " " + "       ";
                        linea3 = " " + "         ";
                    }
                    else
                    {
                        linea1 = linea1 + " ";
                        linea2 = linea2 + " ";
                        linea3 = linea3 + " ";
                        Contador = -1;
                    }
                }
                else
                {
                    textarray2 = textarray2 + a + "           ";
                    if (Contador == 0)
                    {
                        linea1 = "/" + "     ";
                        linea2 = "/" + "       ";
                        linea3 = "/" + "         ";
                    }
                    else
                    {
                        linea1 = linea1 + "\\";
                        linea2 = linea2 + "\\";
                        linea3 = linea3 + "\\";
                        Contador = -1;
                    }

                }
                Contador++;
            }
            Contador = 0;
            foreach (int a in array3)
            {
                if (a == 0)
                {
                    textarray3 = textarray3 + " " + "     ";
                    if (Contador == 0)
                    {
                        linea4 = linea4 + " " + "   ";
                    }
                    else
                    {
                        linea4 = linea4 + " " + "       ";
                        Contador = -1;
                    }
                }
                else
                {
                    textarray3 = textarray3 + a + "     ";
                    if (Contador == 0)
                    {
                        linea4 = linea4 + "/" + "   ";
                    }
                    else
                    {
                        linea4 = linea4 + "\\" + "       ";
                        Contador = -1;
                    }
                }
                Contador++;
            }
            foreach (int a in array4)
            {
                if (a == 0)
                {
                    textarray4 = textarray4 + " " + "  ";
                    if (Contador == 0)
                    {
                        linea5 = linea5 + " " + " ";
                    }
                    else
                    {
                        linea5 = linea5 + " " + "   ";
                        Contador = -1;
                    }
                }
                else
                {
                    textarray4 = textarray4 + a + "  ";
                    if (Contador == 0)
                    {
                        linea5 = linea5 + "/" + " ";
                    }
                    else
                    {
                        linea5 = linea5 + "\\" + "   ";
                        Contador = -1;
                    }
                }
                Contador++;
            }
            Console.WriteLine("                  " + textarray1);
            //Console.WriteLine("               " + "/" + "     " + "\\");
            //Console.WriteLine("              " + "/" + "       " + "\\");
            //Console.WriteLine("             " + "/" + "         " + "\\");
            Console.WriteLine("               " + linea1);
            Console.WriteLine("              " + linea2);
            Console.WriteLine("             " + linea3);
            Console.WriteLine("            " + textarray2);
            //Console.WriteLine("          " + "/" + "   " + "\\" + "       " + "/" + "   " + "\\");
            Console.WriteLine("          " + linea4);
            Console.WriteLine("         " + textarray3);
            //Console.WriteLine("        " + "/" + " " + "\\" + "   " + "/" + " " + "\\" + "   " + "/" + " " + "\\" + "   " + "/" + " " + "\\");
            Console.WriteLine("        " + linea5);
            Console.WriteLine("       " + textarray4);
        }
        public static void Eliminar()
        {
            Console.WriteLine("¿Desea eliminar un nodo o una hoja? S/N");
            string Resp = Console.ReadLine();

            if (Resp == "S")
            {
                int nivel = 0;

                do
                {
                    Console.WriteLine("¿Que desea eliminar la hoja o el nodo?");
                    nivel = int.Parse (Console.ReadLine());
                    if (nivel < 1 || nivel > 5)
                    {
                        Console.WriteLine("Valor incorrecto, solo se puede seleccionar un valor entre el 1 y el 4");
                    }
                } while (nivel < 1 || nivel > 5);

                imprimirNivel (nivel);

                int nodoEliminar;
                int incorrecto = 0;

                do
                {
                    Console.WriteLine("Indique la posición del nodo a Eliminar");
                    nodoEliminar = int.Parse (Console.ReadLine());

                    if (nivel== 1 && (nodoEliminar > 0 || nodoEliminar < 0 ))
                    {
                        Console.WriteLine("El nodo a Eliminar es incorrecto");
                    }
                    else if (nivel == 2 && ( nodoEliminar > 1 || nodoEliminar < 0))
                    {
                        Console.WriteLine("El nodo a Eliminar es incorrecto");
                    }
                    else if (nivel == 3 && (nodoEliminar > 3 || nodoEliminar < 0))
                    {
                        Console.WriteLine("El nodo a Eliminar es incorrecto");
                    }
                    else if (nivel == 4 && (nodoEliminar > 7 || nodoEliminar < 0))
                    {
                        Console.WriteLine("El nodo a Eliminar es incorrecto");
                    }
                    else
                    {
                        incorrecto = 1;
                    }
                } while (incorrecto == 0);
                if (nivel == 1)
                {
                    array1 [nodoEliminar] = 0;
                }
                else if (nivel == 2)
                {
                    array2 [nodoEliminar] = 0;
                }
                else if (nivel == 3) 
                {
                    array3 [nodoEliminar] = 0;
                }
                else if (nivel == 4)
                {
                    array4 [nodoEliminar] = 0;
                }
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1 [i] == 0)
                    {
                        array2 [0] = 0;
                        array2 [1] = 0;
                    }
                    int a = 0, b = 1;
                    for (int j = 0; j < array2.Length; j++)
                    {
                        if (array2 [j] == 0)
                        {
                            array3 [a] = 0;
                            array3 [b] = 0;
                        }
                        int c = 0, d = 1;
                        for (int k = 0; k < array3.Length; k++)
                        {
                            if (array3 [k] == 0)
                            {
                                array4 [c] = 0;
                                array4 [d] = 0;
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
        public static void imprimirNivel(int nivel)
        {
            string valor = "  |  ";
            string posicion = "  |  ";

            if (nivel == 1)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1 [i] > 0)
                    {
                        posicion = posicion + i + "   |   ";
                        valor = valor + array1 [i] + "   |" + "   ";
                    }
                }
                Console.WriteLine(posicion + "Posición");
                Console.WriteLine(valor + "Valor");
            }
            else if (nivel == 2)
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    if (array2 [i] > 0)
                    {
                        posicion = posicion + i + "   |   ";
                        valor = valor + array2 [i] + "   |  ";
                    }
                }
                Console.WriteLine(posicion + "Posición");
                Console.WriteLine(valor + "Valor");
            }
            else if (nivel == 3)
            {
                for (int i = 0; i < array3.Length; i++)
                {
                    if (array3 [i] > 0)
                    {
                        posicion = posicion + i + "   |   ";
                        valor = valor + array3 [i] + "   |   ";
                    }
                }
                Console.WriteLine(posicion + "Posición");
                Console.WriteLine(valor + "Valor");
            }
            else if (nivel == 4)
            {
                for (int i = 0; i < array4.Length; i++)
                {
                    if (array4 [i] > 0)
                    {
                        posicion = posicion + i + "   |   ";
                        valor = valor + array4 [i] + "   |   ";
                    }
                }
                Console.WriteLine(posicion + "Posición");
                Console.WriteLine(valor + "Valor");
            }
        }
    }
}