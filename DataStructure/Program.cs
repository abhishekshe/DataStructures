using System;
using System.Collections.Generic;

namespace LinkedList
{
    class program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            // (****UC1****)
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);

            //list.Display();


            // (*****UC3****)
            //list.Add(56);
            //list.Append(30);
            //list.Append(70);
            //list.Display();


            // (***UC4***)

            list.Add(56);
            
            list.Add(70);
            int a = list.search(56);
            list.InBetween(a + 2, 30);
            Console.WriteLine("index position of element 56 is :" + a);
           
            list.Display();

            // list.DeleteFirstElement();

            //  (***UC6****)

            list.DeleteLastElement();
            list.Display();






        }



    }
}