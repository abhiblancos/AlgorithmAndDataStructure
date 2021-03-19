using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLinkedList
{
	public class DoubleNode
	{
		int value { get; set; }

		public DoubleNode next { get; set; }
		public DoubleNode previous { get; set; }

		public DoubleNode(int value)
		{
			this.value = value;
			this.next = null;
			this.previous = null;
		}
	}


	class DoubleLinkedList
	{
		private DoubleNode head;
		private DoubleNode tail;

		private int length;

		public DoubleLinkedList(int value)
		{
			this.head = new DoubleNode(value);
			this.tail = this.head;
			this.length = 1;
		}
		private int WrapIndex(int index)
		{
			return Math.Max(Math.Min(index, this.length - 1), 0);
		}

		public void Insert(int index, int value)
		{
			index = WrapIndex(index);

			if (index == 0)
			{
				Prepend(value);
				return;
			}

			if (index == length - 1)
			{
				Append(value);
				return;
			}

			DoubleNode newNode = new(value);
			DoubleNode travesenode = TraverseNode(index - 1);
			DoubleNode follower = travesenode.next;

			travesenode.next = newNode;
			newNode.previous = travesenode;
			newNode.next = follower;
			follower.previous = newNode;
		}
		public void Append(int value)
		{
			DoubleNode newNode = new(value)
			{
				previous = this.tail
			};
			this.tail.next = newNode;
			this.tail = newNode;
			this.length++;	
		}

		public DoubleNode TraverseNode(int index)
		{
			int counter = 0;
			index = WrapIndex(index);
			DoubleNode currentNode = head;

			while (counter != index)
			{
				currentNode = currentNode.next;
				counter++;
			}

			return currentNode;
		}
		public void Prepend(int value)
		{
			DoubleNode newNode = new(value)
			{
				next = this.head
			};
			this.head.previous = newNode;
			this.head = newNode;
			this.length++;
		}
		public void Remove(int index)
		{

		}
		public void PrintList()
		{

		}

		public void LinkListOperation()
		{
			Console.Clear();
			Console.WriteLine("Please select");
			Console.WriteLine("Data Structure:\n 1: Append \n 2= Prepend \n 3 = Insert \n 4 = Remove \n 5= Print Linked List");
			Console.Write("Please enter your selection: ");
			string str = Console.ReadLine();
			switch (str)
			{
				case "1":
					Console.Write("Please enter your value to append: ");
					string valueAppend = Console.ReadLine();
					Append(Convert.ToInt32(valueAppend));
					LinkListOperation();
					break;
				case "2":
					Console.Write("Please enter your value to Prepend: ");
					string valuePrepend = Console.ReadLine();
					Prepend(Convert.ToInt32(valuePrepend));
					LinkListOperation();
					break;
				case "3":
					Console.Write("Please enter your index: ");
					string index = Console.ReadLine();
					Console.Write("Please enter your index value: ");
					string value = Console.ReadLine();
					Insert(Convert.ToInt32(index), Convert.ToInt32(value));
					LinkListOperation();
					break;
				case "4":
					Console.Write("Please enter your index to remove: ");
					string indexRemoved = Console.ReadLine();
					Remove(Convert.ToInt32(indexRemoved));
					LinkListOperation();
					break;
				case "5":
					PrintList();
					LinkListOperation();
					break;
			}
		}

	}
}
