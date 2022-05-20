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

        public int SearchLinkedList(int searchdata)
        {
            
            int index = 0;
            
            Node temp = head;
            
            if (head == null)
            {
                Console.WriteLine("Empty Linked List");
                return 0;
            }
            
            while (temp != null)
            {
                index += 1;
                
                if (temp.data == searchdata)
                {
                    Console.WriteLine($"{searchdata} is present in the list at {index} position.");
                    
                    return index;
                }
                
                temp = temp.next;
            }
            return 0;
        }
       
        public void InsertingElementWithData(int data, int searchData)
        {
            Node node = new Node(data);
            Console.WriteLine("\ninserting element after the given data\n");
            
            int positionForGivenData = SearchLinkedList(searchData);
            if (positionForGivenData == 0)
            {

                Console.WriteLine("Given value do not exist in the linkedlist:\t{0}", searchData);
            }
            else if (positionForGivenData == 1)
            {
                node.next = head;
                head = node;
                Console.WriteLine("\nElement inserted in list:\t{0}", node.data);
            }
            
            else
            {
                Node temp = head;
                Node previous = null;
                for (int i = 1; i <= positionForGivenData; i++)
                {
                    previous = temp;
                    temp = temp.next;
                }
                previous.next = node;
                node.next = temp;
                Console.WriteLine("\nElement inserted in list:\t{0}", node.data);
            }


        }

        public void DeleteElementFromList(int data)
        {
            
            int positionForGivenData = SearchLinkedList(data);
            Node temp = head;
            if (positionForGivenData == 0)
            {

                Console.WriteLine("Given value do not exist in the linkedlist:\t{0}", data);
            }
           
            else if (positionForGivenData == 1)
            {
                head = temp.next;
            }
            else
            {
                
                Node previous = null;
                
                for (int i = 1; i < positionForGivenData; i++)
                {
                    previous = temp;
                    temp = temp.next;
                }
                Console.WriteLine("Deleting Specific element from the list:\t{0}", temp.data);
                

                previous.next = temp.next;
            }
        }
    }
}
