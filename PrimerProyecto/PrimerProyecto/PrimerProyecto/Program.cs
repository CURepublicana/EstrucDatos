using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUMERO1, NUMERO2, NUMERORETORNO;
            Console.Write("Número 1: ");
            NUMERO1 = int.Parse(Console.ReadLine());
            Console.Write("Número 2: ");
            NUMERO2 = int.Parse(Console.ReadLine());
            NUMERORETORNO = funcion_entera(NUMERO1, NUMERO2);
            Console.WriteLine(NUMERORETORNO);
            EstructurasDatosBasicos estructuras = new EstructurasDatosBasicos();
            estructuras.EstructurasBasicas();
            estructuras.EstructurasSimples();
            estructuras.EstructuraDeDatos();
            Console.ReadKey();
        }

        /// <summary>
        /// función: Una función es un conjunto de líneas de código que realizan una tarea específica 
        /// y puede retornar un valor. ... 
        /// Las funciones son utilizadas para descomponer grandes problemas en tareas simples 
        /// y para implementar operaciones que son comúnmente utilizadas durante un programa 
        /// y de esta manera reducir la cantidad de código.
        /// </summary>
        /// <param name="entero1">argumento 1: de entrada</param>
        /// <param name="entero2">argumento 2: de entrada</param>
        /// <returns>retorno void, int, char, string, double, float O cualquier tipo de datos</returns>
        public static int funcion_entera(int entero1, int entero2)
        {
            int resultado = 0;
            resultado = entero1 + entero2;
            return resultado;
        }
    }
}
