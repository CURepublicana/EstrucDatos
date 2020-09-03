using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrucDatosII
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            int Opcion = 0;
            do
            {
                Console.WriteLine("BIENVENIDOS A SU PROGRAMA!!!");
                Console.WriteLine("1. Pilas");
                Console.WriteLine("2. Colas");
                Console.WriteLine("3. Lista");
                Console.WriteLine("9. Salir");
                Console.Write("Opciones: ");
                Opcion = int.Parse(Console.ReadLine());

                switch (Opcion)
                {
                    case 1:
                        Pila_ED pila_ED = new Pila_ED();
                        pila_ED.Pila();
                        break;
                    case 2: 
                        Cola_ED cola_ED = new Cola_ED();
                        cola_ED.Cola();
                        break;
                    case 3:
                        Lista_ED lista_ED = new Lista_ED();
                        lista_ED.Lista();
                        break;
                    default:
                        Console.WriteLine("Chao!!!!");
                        Console.ReadKey();
                        salir = true;
                        break;
            }
            }while(salir);            
        }
    }
}
