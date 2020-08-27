using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructura
{
    public class ArrayListDatos
    {

		public static void Main()
		{

			ArrayList Lista = new ArrayList();

			Lista.Add(2);
			Lista.Add(4);
			Lista.Add(6);
			Lista.Add(8);
			Lista.Add(10);
			Lista.Add(12);
			Lista.Add(14);
			Lista.Add(16);
			Lista.Add(18);
			Lista.Add(20);

			Console.WriteLine("La lista inicial de ArrayList: ");

			foreach (int i in Lista)
			{
				Console.WriteLine(i);
			}

			// eliminando 4 elementos a partir del índice 0 
			Lista.RemoveRange(0, 4);

			// Mostrando la Lista de Arreglos modificada 
			Console.WriteLine("La lista de arreglos después de quitar los elementos: ");

			// Mostrando los elementos en ArrayList 
			foreach (int i in Lista)
			{
				Console.WriteLine(i);
			}
		}

	}
}




	

