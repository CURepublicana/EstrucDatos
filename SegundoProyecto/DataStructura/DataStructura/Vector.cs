using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructura
{
    public class Vector
    {
        private int[] sueldos;
        public void Cargar()
        {
            sueldos = new int[5];
            for (int f = 0; f < 5; f++)
            {
                Console.Write("Ingrese valor de la componente: ");
                String linea;
                linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);
            }
        }

        public void Imprimir()
        {
            //       f = 0; f < 5; f++ (0,1,2,3,4)
            for (int f = 0; f < 5; f++)
            {
                Console.WriteLine(sueldos[f]);
            }
            Console.ReadKey();
        }

        public void Inicio()
        {
            Vector pv = new Vector();
            pv.Cargar();
            pv.Imprimir();
        }
    }
}