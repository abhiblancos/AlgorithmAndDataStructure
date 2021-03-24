using System;

namespace Tree
{
	public class BinarySearchTree
	{
		Node root { get; set; }

		public BinarySearchTree()
		{
			this.root = null;
		}


		public void insert(int value)
		{
			Node newNode = new(value);

			if(root == null)
			{
				root = newNode;
				return;
			}

			Node currentNode = this.root;

			while (true)
			{

				if(currentNode.value > value)
				{
					if (currentNode.left == null)
					{
						currentNode.left = new Node(value);
						return;
					}
					currentNode = currentNode.left;
				}
				else
				{
					if (currentNode.right == null)
					{
						currentNode.right = new Node(value);
						return;
					}
					currentNode = currentNode.right;
				}
			}			
		}

		public Node lookup(int value)
		{
			if (root == null)
			{				
				return null;
			}

			Node currentNode = this.root;

			while(currentNode != null)
			{

				if(currentNode.value < value)
				{
					currentNode = currentNode.left;
				}else if(currentNode.value > value)
				{
					currentNode = currentNode.right;
				}
				else if(currentNode.value == value)
				{
					return currentNode;
				}
			}

			return null;
		}

	}

	public class Node
	{
		public int value { get; set; }

		public Node left { get; set; }

		public Node right { get; set; }

		public Node(int vaue)
		{
			this.value = value;
			left = null;
			right = null;
		}

	}
}
