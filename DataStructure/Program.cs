using System;
using System.Collections.Generic;

namespace LinkedList
{
    class program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            //list.Add(56);
            //list.Add(30);
            //list.Add(70);

            //list.Display();

            list.Add(56);
            list.Append(30);
            list.Append(70);
            list.Display();



        }



    }
}