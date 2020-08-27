using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructura
{
	class ArrayvsArrayList
	{

		public static void Array_list(string[] args)
		{

			// Crear una lista de cadedas 
			ArrayList al = new ArrayList();
			al.Add("Oscar");
			al.Add("Ortiz");
			al.Add(10);
			al.Add(10.10);

			// Iterar el elemento de la lista usando el bucle foreach 
			foreach (var names in al)
			{
				Console.WriteLine(names);
			}
		}
		//aqui
		public static void arreglo(string[] args)
		{
			int[] arr = new int[4];

			arr[0] = 47;
			arr[1] = 77;
			arr[2] = 87;
			arr[3] = 97;

			for (int i = 0; i < arr.Length; i++)
			{

				Console.WriteLine(arr[i]);
			}
		}


	}
}

	





	

