using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueProblem
{
    internal class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }
        internal void Push(int value) // this method is used the push or add the element in stack
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }
        public void Display() // this method is used to display the elements in stack
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " "); 
                temp = temp.next;
            }
        }
    }
}
