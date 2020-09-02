using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EstrucDatosII
{
    class Cola_ED
    {
        public void Cola()
        {
            string palabra;

            Queue miCola = new Queue();
            miCola.Enqueue("Hola ");
            miCola.Enqueue("buenos ");
            miCola.Enqueue("días.");

            //Peek: mira el valor de la cabeza pero sin extraer.
            //Clear: borra todo el contenido de la cola.
            //Contains: indica si un cierto elemento está en la cola.
            //GetType: para saber de que tipo son los elementos almacenados en la cola.
            //ToString: devuelve el elemento actual convertido en un string.
            //ToArray.devuelve toda la cola convertida en un array.
            //GetEnumerator: permite usar enumeradores para recorrer la pila.
            //Count: indica cuantos elementos contiene.

            for (byte i = 0; i < 3; i++)
            {
                palabra = (string)miCola.Dequeue();
                Console.WriteLine(palabra);
            }

            Console.ReadKey();
        }
    }
}
