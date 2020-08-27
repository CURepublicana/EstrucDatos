using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructura
{
    public class DobleEnlazada
    {
		static Node start;

		// La estructura de un nodo
		public class Node
		{
			public int data;
			public Node next;
			public Node prev;
		};

		// Función para insertar al final 
		static void insertEnd(int value)
		{
			Node new_node;

			// Si la lista está vacía, crear un único nodo 
			// circular y doble lista 
			if (start == null)
			{
				new_node = new Node();
				new_node.data = value;
				new_node.next = new_node.prev = new_node;
				start = new_node;
				return;
			}

			// Si la lista no está vacía 

			/* Encontrar el último nodo */
			Node last = (start).prev;

			// Crear Nodo dinámicamente 
			new_node = new Node();
			new_node.data = value;

			// Start va a ser el siguiente de new_node 
			new_node.next = start;

			// Hacer el nuevo nodo anterior de inicio  - start 
			(start).prev = new_node;

			// Hacer el último adelanto del nuevo nodo 
			new_node.prev = last;

			// Make new node next of old last 
			last.next = new_node;
		}

		// Función para insertar el nodo al principio 
		// de la Lista, 
		static void insertBegin(int value)
		{
			// El puntero apunta al último nodo 
			Node last = (start).prev;

			Node new_node = new Node();
			new_node.data = value; // Insertar los datos 

			// estableciendo el anterior y el siguiente de un nuevo nodo 
			new_node.next = start;
			new_node.prev = last;

			// Actualizar los indicadores de inicio siguientes y anteriores 
			// Y por último.
			last.next = (start).prev = new_node;

			// actualiza el comiento con el nuevo nodo
			start = new_node;
		}

		// Función para insertar el nodo con valor como valor1. 
		// El nuevo nodo se inserta después del nodo con 
		// con valor2 
		static void insertAfter(int value1, int value2)
		{
			Node new_node = new Node();
			new_node.data = value1;

			//Encuentra el nodo que tiene valor2 y el siguiente nodo de él
			Node temp = start;
			while (temp.data != value2)
				temp = temp.next;
			Node next = temp.next;

			// insertar nuevo_nodo entre temp y siguiente - next. 
			temp.next = new_node;
			new_node.prev = temp;
			new_node.next = next;
			next.prev = new_node;
		}

		static void display()
		{
			Node temp = start;

			Console.Write("\nTraversal en dirección hacia adelante \n");
			while (temp.next != start)
			{
				Console.Write("{0} ", temp.data);
				temp = temp.next;
			}
			Console.Write("{0} ", temp.data);

			Console.Write("\nTraversal en dirección contraria \n");
			Node last = start.prev;
			temp = last;
			while (temp.prev != last)
			{
				Console.Write("{0} ", temp.data);
				temp = temp.prev;
			}
			Console.Write("{0} ", temp.data);
		}

		
		public static void Main(String[] args)
		{
			/* Empieza con la lista vacía */
			Node start = null;

			// Insertar 5. Así que la lista de enlaces se convierte en 5.null 
			insertEnd(5);

			// Insertar 4 al principio. Así que se unieron... 
			// La lista se convierte en 4.5 
			insertBegin(4);

			// Inserte 7 al final. Así que la lista de enlaces 
			// se convierte en 4.5.7 
			insertEnd(7);

			insertEnd(8);

			insertAfter(6, 5);

			Console.Write("La lista circular doblemente enlazada creada es: ");
			display();
		}
	}
}


