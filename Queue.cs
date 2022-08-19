using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    /// <summary>
    /// Program For Linked List Implemantation Of Queue.
    /// </summary>

    //A Linked list(LL) node to store a queue entry.
    public class Node
    {
        public int key;
        public Node next;

        //Constructor to create a new linked list node.
        public Node(int key)
        {
            this.key = key;
            this.next = null;

        }
    }
    //A class to represent a queue, The queue front stores the front Node of LL and rear stores the last node of LL.
    public class Queue
    {
       public Node front, rear;
        public Queue()
        {
            this.front = this.rear = null;
        }
        //Method To add an Key To The Queue.
       public void Enqueue(int key)
        {
            //Create a new LL node.
            Node temp = new Node(key);
            
            //If queue is empty , then new node is front and rear both.
            if (this.rear == null)
            {

                this.front = this.rear = temp;
                return;

            }
            //Add new node at the end of quque andchange rear.
            this.rear.next = temp;
            this.rear = temp;
            Console.WriteLine("The Item inserted into Queue is {0}", key);

        }


    }
}
