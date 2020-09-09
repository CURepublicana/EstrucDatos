using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo
{
    class Program
    {
        static void Main(string[] args)
        { //Recorre los números del 1 al 100. Usa un bucle while
            //int i = 0;
            //while(i < 100)
            //{
            //    Console.WriteLine("{0}", i);
            //    i++;
            //}
            //Console.ReadKey();

            //1) Crear 3 variables numéricas con el valor que tu quieras y en otra variable numérica guardar el
            //valor de la suma de las 3 anteriores.Mostrar por consola

            //5) Pedir el nombre de la semana al usuario y decirle si es fin de semana o no.En caso de error,
            //indicarlo.
            string nombre = string.Empty;
            string dia = string.Empty;
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Dia de la semana: ");
            dia = Console.ReadLine();
            switch (dia.ToLower())
            {
                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes": Console.WriteLine("Dia laboral"); break;
                case "sabado":
                case "domingo": Console.WriteLine("Fin de semana"); break;
                default:
                    Console.WriteLine("Dia invalido");
                    break;
            }
            Console.WriteLine("Gracias {0}", nombre);
            Console.ReadKey();

        }
    }
}
