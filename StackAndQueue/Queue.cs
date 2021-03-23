using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
	public class Queue
	{
		private Node first { get; set; }

		private Node last { get; set; }

		private int length { get; set; }

		public Queue()
		{
			this.first = null;
			this.last = null;
			this.length = 0;
		}

		public void Enqueue(int value)
		{
			Node newNode = new(value);
			if(length == 0)
			{
				this.first = newNode;
				this.last = newNode;
			}
			else
			{				
				this.last.next = newNode;
				this.last = newNode;				
			}

		}

		public void Dequeue()
		{
			if (this.first == null)
				return;

			if(this.length == 0)
			{
				this.last = null;
			}

			Node holdNode = this.first;
			this.first = this.first.next;

			this.length--;


		}
	}
}
