using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto
{
    public class EstructurasDatosBasicos
    {
        public void EstructurasBasicas()
        {
            try
            {

                //estructuras básicas
                //int Números enteros(integers)  32  –231 hasta 231 – 1  int count; count = 42;
                int numerico = 0;
                //long Números enteros(bigger range)  64  –263 hasta 263 – 1  long wait; wait = 42L;
                long numero_entero = 0;
                //float Números de punto flotante   32  –3.4 × 10–38 hasta 3.4 × 1038   float away; away = 0.42F;
                float flotante = 0;
                //double Números de punto flotante de Doble - Precisión(más precisos)   64  ±5.0 × 10–324 hasta ±1.7 × 10308    double trouble; trouble = 0.42;
                double doble = 0;
                //decimal Valores Monetarios  128 28 dígitos significativos   decimal coin; coin = 0.42M;
                decimal decimal_monetario = 0;
                //string Secuencia de Caracteres 16 bits por carácter No aplicable    string vest vest = "forty two";
                string cadena = string.Empty;
                //char Carácter único  16  Un único carácter   char grill; grill = 'x';
                char caracter = 'A'; //ASCII 65
                                     //bool Booleanos   8   Verdadero ó Falso   bool teeth; teeth = false;
                bool Booleanos = true; //true o false
                                       //aunque no es un tipo nativo, desde la versión del 2015, ya podemos determinar como 
                                       //tal la referencia determinada como var
                var caracteres = new[] { 'O', 'S', 'C', 'A', 'R', 'D', 'O' };

                numerico = 12;
                numero_entero = 12233434;
                flotante = 15 / 12003003;
                doble = 15 / 12003003;
                decimal_monetario = 23423; //podemos crear elformato monetario ($)
                cadena = "Oscardo";
                caracter = 'B'; //ASCII 66
                Booleanos = false; //true o false
                caracteres = new[] { 'O', 'R', 'T', 'I', 'Z' };

                Console.WriteLine("ENTRADA Y SALIDA DE PANTALLA");
                Console.Write("Numérico: "); //salida
                numerico = int.Parse(Console.ReadLine()); //entrada 
                Console.Write("Numérico entero: "); //salida
                numero_entero = long.Parse(Console.ReadLine()); //entrada 
                Console.Write("Flotante: "); //salida
                flotante = float.Parse(Console.ReadLine()); //entrada
                Console.Write("Doble: "); //salida
                doble = double.Parse(Console.ReadLine()); //in
                Console.Write("decimal monetario: "); //out
                decimal_monetario = decimal.Parse(Console.ReadLine()); //podemos crear elformato monetario ($)
                Console.Write("Carácter: "); //out
                cadena = char.ConvertFromUtf32(Console.Read());//PILAS CONVIERTE A UTF32 DE UN VALOR NUMÉRICO

                //referencia: https://academiadot.net/blog/104740/tipos-de-datos-primitivos-en-c

                Console.WriteLine("SALIDA DE PANTALLA");
                Console.WriteLine("Numérico: {0}", numerico); //salida
                Console.WriteLine("Numérico entero: {0}", numero_entero); //salida
                Console.WriteLine("Flotante: {0}", flotante); //salida
                Console.WriteLine("Doble: {0}", doble); //salida
                Console.WriteLine("decimal monetario: {0}", decimal_monetario); //out
                Console.WriteLine("Carácter: {0}", cadena); //out

                Console.WriteLine("Booleanos: {0}", Booleanos); //out
                Console.WriteLine("Carácteres: {0}", caracteres); //out

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " - " + ex.StackTrace.ToString());
            }
            Console.ReadKey();
        }

        public struct Estructura
        {
            public Estructura(int num, string cad, float flo)
            {
                numero = num;
                cadena_caracteres = cad;
                flotante = flo;
            }
            public int numero { get; set; }
            public string cadena_caracteres { get; set; }
            public float flotante { get; set; }

            public override string ToString() => $"({numero} - {cadena_caracteres} - {flotante})";
        }

        public void EstructurasSimples()
        {
            Estructura estructura = new Estructura(1,"numero", 234);
            estructura.numero = 99;
            estructura.flotante = 45.34f;//número f de float
            
            Console.Write("estructura.numero: ");
            estructura.numero = int.Parse(Console.ReadLine());
            Console.Write("estructura.flotante: ");
            estructura.flotante = float.Parse(Console.ReadLine());
            Console.Write("estructura.cadena_caracteres: ");
            estructura.cadena_caracteres = Console.ReadLine();
            Console.WriteLine(estructura.ToString());
            Console.ReadKey();
        }    

        public void EstructuraDeDatos()
        {
            //using System.Collections;
            //using System.Collections.Generic;
            System.Array array;
            System.Collections.ArrayList arrayList = new ArrayList();
            System.Collections.BitArray bitList = new BitArray(2);
            System.Collections.Queue queue = new Queue();
            System.Collections.Stack stack = new Stack();
            System.Collections.SortedList sortedlist = new SortedList();

            //TRABAJO 
            //Part 1: An Introduction to Data Structures : https://docs.microsoft.com/en-us/previous-versions/ms379570(v=vs.80)?redirectedfrom=MSDN
            //Part 2: The Queue, Stack, and Hashtable : https://docs.microsoft.com/en-us/previous-versions/ms379571(v=vs.80)?redirectedfrom=MSDN
            //Part 3: Binary Trees and BSTs : https://docs.microsoft.com/en-us/previous-versions/ms379572(v=vs.80)?redirectedfrom=MSDN
            //Part 4: Building a Better Binary Search Tree : https://docs.microsoft.com/en-us/previous-versions/ms379573(v=vs.80)?redirectedfrom=MSDN
            //Part 5: From Trees to Graphs : https://docs.microsoft.com/en-us/previous-versions/ms379574(v=vs.80)?redirectedfrom=MSDN
            //Part 6: Efficiently Representing Sets : https://docs.microsoft.com/en-us/previous-versions/ms379575(v=vs.80)?redirectedfrom=MSDN

        }
    }
}
