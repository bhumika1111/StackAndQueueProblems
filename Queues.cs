using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{

    /// <summary>
    /// Program For Linked List Implemantation Of Queue.
    /// </summary>

    //A Linked list(LL) node to store a queue entry.
    public class DNode
    {
        public int key;
        public DNode next;

        //Constructor to create a new linked list node.
        public DNode(int key)
        {
            this.key = key;
            this.next = null;

        }
    }
    //A class to represent a queue, The queue front stores the front Node of LL and rear stores the last node of LL.
    public class Queues
    {
        public DNode front, rear;
        public Queues()
        {
            this.front = this.rear = null;
        }
        //Method To add an Key To The Queue.
        public void Enqueue(int key)
        {
            //Create a new LL node.
            DNode temp = new DNode(key);

            //If queue is empty , then new node is front and rear both.
            if (this.rear == null)
            {

                this.front = this.rear = temp;
                return;

            }
            else
            {
                //Add new node at the end of quque and change rear.
                this.rear.next = temp;
                this.rear = temp;
            }
            Console.WriteLine("The Item inserted into Queue is {0}" , key );
        }
        //Method to remove an key from queue.
        public void Dequeue()
        {
            //If queue is empty, return Null.
            if (this.front == null)
                Console.WriteLine("The Queue Is Empty");
               
            //Store privious front and move front one node ahead.
            DNode temp = this.front;
            //Visit next node
            this.front = this.front.next;
        
            //If front becomes null,then change rear also as null.
            if (this.front == null)
            {
                this.rear = null;
            }
            Console.WriteLine("Item deleted is{0}",temp.key);
        }


    }
}
