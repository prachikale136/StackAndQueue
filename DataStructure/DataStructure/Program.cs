﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            /*Console.WriteLine("Hello, World!");
            StackAndQueue stackLinkedList = new StackAndQueue();
            stackLinkedList.Push(56);
            stackLinkedList.Push(30);
            stackLinkedList.Push(70);
            stackLinkedList.Peek();
            stackLinkedList.Pop();
            stackLinkedList.Display();*/

         Queue queueLinkedList = new Queue();
            queueLinkedList.Enqueue(56);
            queueLinkedList.Enqueue(30);
            queueLinkedList.Enqueue(70);
            queueLinkedList.Display();
            Console.ReadKey();
        }
    }
}