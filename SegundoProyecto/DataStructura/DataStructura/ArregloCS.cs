using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructura
{
    public class ArregloCS
    {
		public void arreglo()
		{

			//declara un conjunto de números enteros. 
			int[] intArray;

			// asignando memoria para 5 números enteros.
			intArray = new int[5];

			intArray[0] = 10;
			intArray[1] = 20;
			intArray[2] = 30;
			intArray[3] = 40;
			intArray[4] = 50;

			// Accediendo al Loop
			Console.Write("For (Ciclo) loop :");
			for (int i = 0; i < intArray.Length; i++)
				Console.Write(" " + intArray[i]);

			Console.WriteLine("");
			Console.Write("For-each ciclo :");

			foreach (int i in intArray)
				Console.Write(" " + i);

			Console.WriteLine("");
			Console.Write("while ciclo :");

			int j = 0;
			while (j < intArray.Length)
			{
				Console.Write(" " + intArray[j]);
				j++;
			}

			Console.WriteLine("");
			Console.Write("Do-while cicli :");

			int k = 0;
			do
			{
				Console.Write(" " + intArray[k]);
				k++;
			} while (k < intArray.Length);
		}

	}
}
