using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructura
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenidos");
                Console.WriteLine("Vector:             Digite 1");
                Console.WriteLine("Matrix:             Digite 2");
                Console.WriteLine("Arreglo:            Digite 3");
                Console.WriteLine("ArrayList:          Digite 4");
                Console.WriteLine("ArrayList vs Array: Digite 5");
                Console.WriteLine("Doblemente:         Digite 6");
                Console.WriteLine("Salir:  Digite 0");
                Console.Write("Cual es su opción: ");
                valor = int.Parse(Console.ReadLine());
                if(valor == 1)
                {
                    Vector vector = new Vector();
                    vector.Inicio();
                }
                if (valor == 2)
                {
                    Matriz5 matrizProg = new Matriz5();
                    matrizProg.matriz();
                }
                if (valor == 3)
                {
                    ArregloCS arreglos = new ArregloCS();
                    arreglos.arreglo();
                }
                if (valor == 4)
                {
                    ArrayListDatos datos = new ArrayListDatos();
                    datos.Coleccion();
                }
                if (valor == 5)
                {
                    ArrayvsArrayList vv = new ArrayvsArrayList();
                    vv.Array_Nativa();
                    vv.Array_Objetos();
                }
                if (valor == 6)
                {
                    DobleEnlazada de = new DobleEnlazada();
                    de.Doble();
                }
            } while (valor != 0);
        }
    }
}
