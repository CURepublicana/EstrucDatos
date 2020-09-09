using System;
// TADS fuertemente tipados
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// TADS pila, colas, etc.
using System.Collections;

namespace EstrucDatosII
{
    public class Pila_ED
    {
        public void Pila()
        {
            string palabra;

            Stack miPila = new Stack();
            miPila.Push("hola"); //0
            miPila.Push("buenos"); //1
            miPila.Push("días"); //2
            miPila.Push("1"); //3 
            miPila.Push("Listo"); //3 

            string dato = (string)miPila.Peek();
            Console.WriteLine(dato);
            
            //Peek: mira el valor de la cabeza pero sin desapilar.
            //Clear: borra todo el contenido de la pila.
            //Contains: indica si un cierto elemento está en la pila.
            //GetType: para saber de que tipo son los elementos almacenados en la pila.
            //ToString: devuelve el elemento actual convertido en un string.
            //ToArray.devuelve toda la pila convertida en un array.
            //GetEnumerator: permite usar enumeradores para recorrer la pila.
            //Count: indica cuantos elementos contiene
            for (int i = 0; i < 5; i++)
            {
                palabra = (string)miPila.Pop();
                Console.WriteLine(palabra);
            }

            Console.ReadKey();
        }
    }
}