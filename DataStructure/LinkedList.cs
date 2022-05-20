using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        internal Node head;

        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;

                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into a linkedlist", node.data);

        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("linked list isempty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }
        internal void Append(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;


            }
            Console.WriteLine("{0} Append into linked list", node.data);
        }

        internal Node InBetween(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                {
                    Console.WriteLine("position out of range");
                }
            }
            Console.WriteLine("Inseted value is " + head);
            return head;

        }
        internal int search(int value)
        {
            Node node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data! == value)
                {

                    return count;
                }
                node = node.next;
                count++;
                Console.WriteLine(value);

            }
            return count;
            Console.WriteLine(value);

        }
        public void DeleteFirstElement()
        {
            
            Node temp = head;
            Console.WriteLine("Element to be removed :\t{0}", temp.data);
            
            head = temp.next;

        }
        public void DeleteLastElement()
        {
            Node temp = head;
            
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            
            Node lastelement = temp.next;
            Console.WriteLine("Deleting last element:\t{0}", lastelement.data);
            
            temp.next = null;

        }

        public bool SearchLinkedList(int searchdata)
        {
            int index = 0;
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("Empty Linked List");
                return false;
            }
            while (temp.next != null)
            {
                index += 1;
                if (temp.data == searchdata)
                {
                    Console.WriteLine($"{searchdata} is present in the list at {index} position.");
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
    }
}
