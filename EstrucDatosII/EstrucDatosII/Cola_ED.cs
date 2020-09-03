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

            //Encolar
            miCola.Enqueue("Maria"); //0
            miCola.Enqueue("x"); //3
            miCola.Enqueue("Karina"); //1
            miCola.Enqueue("Daniel"); //2
            miCola.Enqueue("y"); //4
            miCola.Enqueue("z"); //5

            // Console.WriteLine("Cabeza: " + miCola.Peek().ToString()); //Maria
            
            //Peek: mira el valor de la cabeza pero sin extraer.
            //Clear: borra todo el contenido de la cola.
            //Contains: indica si un cierto elemento está en la cola.
            //GetType: para saber de que tipo son los elementos almacenados en la cola.
            //ToString: devuelve el elemento actual convertido en un string.
            //ToArray.devuelve toda la cola convertida en un array.
            //GetEnumerator: permite usar enumeradores para recorrer la pila.
            //Count: indica cuantos elementos contiene.
            //                         6
            for (byte i = 0; i < miCola.Count; i++)
            {
                //desencolar
                palabra = (string)miCola.Dequeue();
                Console.WriteLine(palabra);
            }

            Console.ReadKey();
        }
    }
}
