using System;

namespace DataStructureLinkedList
{
	public class Node
	{
		public int value { get; set; }
		public Node next { get; set; }

		public Node(int value)
		{
			this.value = value;
			this.next = null;
		}
	}
	public class LinkedList
	{
		private Node head;
		private Node tail;

		private int length;

		public LinkedList(int value)
		{
			this.head = new Node(value);
			this.tail = this.head;
			this.length = 1;
		}

		public void append(int value)
		{
			Node newNode = new Node(value);
			this.tail.next = newNode;
			this.tail = newNode;
			this.length++;
		}

		public void prepend(int value)
		{
			Node newNode = new Node(value);
			newNode.next = this.head;
			this.head = newNode;
			this.length++;
		}

		public void insert(int index, int value)
		{
			index = wrapIndex(index);

			if(index == 0)
			{
				prepend(value);
				return;
			}

			if(index == length -1)
			{
				append(value);
				return;
			}

			Node newNode = new Node(value);
			Node insertNode = traverseToIndex(index -1);
			Node holdingPointer = insertNode.next;
			insertNode.next = newNode;
			newNode.next = holdingPointer;

			this.length++;

		}

		public Node getHead()
		{
			return this.head;
		}

		public Node getTail()
		{
			return this.tail;
		}

		public int getLength()
		{
			return this.length;
		}

		private int wrapIndex(int index)
		{
			return Math.Max(Math.Min(index, this.length - 1), 0);
		}


		public void remove(int index)
		{
			index = wrapIndex(index);
			if (index == 0)
			{
				head = head.next;
				return;
			}

			Node previousNode = traverseToIndex(index - 1);
			Node nodeTRemove = previousNode.next;

			previousNode.next = nodeTRemove.next;
			this.length--;

		}

		private Node traverseToIndex(int index)
		{
			int counter = 0;
			index = wrapIndex(index);
			Node currentNode = head;
			while(counter != index)
			{
				currentNode = currentNode.next;
				counter++;
			}

			return currentNode;
		}

		public void printList()
		{
			if (this.head == null)
			{
				return;
			}
			Node current = this.head;
			while (current != null)
			{
				Console.Write("-->" + current.value);
				current = current.next;
			}
			Console.ReadLine();
		}


		public void LinkListOperation()
		{
			Console.Clear();
			Console.WriteLine("Please select");
			Console.WriteLine("Data Structure:\n 1: Append \n 2= Prepend \n 3= Insert \n 4 = Remove \n 5= Print Linked List");
			Console.Write("Please enter your selection: ");
			string str = Console.ReadLine();
			switch (str)
			{
				case "1":
					Console.Write("Please enter your value to append: ");
					string valueAppend = Console.ReadLine();					
					append(Convert.ToInt32(valueAppend));
					LinkListOperation();
					break;
				case "2":
					Console.Write("Please enter your value to Prepend: ");
					string valuePrepend = Console.ReadLine();
					prepend(Convert.ToInt32(valuePrepend));
					LinkListOperation();
					break;				
				case "3":
					Console.Write("Please enter your index: ");
					string index = Console.ReadLine();
					Console.Write("Please enter your index value: ");
					string value = Console.ReadLine();
					insert(Convert.ToInt32(index),Convert.ToInt32(value));					
					LinkListOperation();
					break;
				case "4":
					Console.Write("Please enter your index to remove: ");
					string indexRemoved = Console.ReadLine();
					remove(Convert.ToInt32(indexRemoved));
					LinkListOperation();
					break;
				case "5":
					printList();
					LinkListOperation();
					break;
			}
		}

	}


}
