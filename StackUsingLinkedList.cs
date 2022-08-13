using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueues
{  /// <summary>
  /// Here, program To Implement Stack Using Linked List . 
  /// </summary>
  
    //Create Stack Using Linked List.
  public  class StackUsingLinkedList
    {
        //A linked List Node.
        private class Node
        {
            //Integer Data
            public int data;

            //Referance Variable Node Type.
            public Node link;
        }
        //Create Global Top Referance Variable.
        Node top;


        // Create Constructor.
        public StackUsingLinkedList()
        {
            this.top = null;
        }
        //Utility Function To Add An Element X In The Stack Insert At The Beginning.
        public void push(int x)
        {
            //Create New Node Temp And Allocate Memory.
            Node temp = new Node();
            //Check If Stack (Heap) Is Full, Then Inserting An Element Would Lead To Stack OverFlow
            if(temp == null)
            {
                Console.WriteLine("Heap overflow");
                return;
            }
            //Intiialize Data Int  Temp Data Field
            temp.data = x;

            //Put Top Reference Into Temp Link.
            temp.link = top;

            //Update Top Referance.
            top = temp;
        }

        //Utility Function To Check If The Stack Is Empty Or Not.
        public bool isEmpty()
        {
            return top == null;
        }
        public void Display()
        {
            //Check For Stack Underflow
            if(top == null)
            {
                Console.WriteLine("Stack underflow");
                return;
            }
            else
            {
                Node temp = top;
                while(temp != null)
                {
                    //Print Node Data
                    Console.WriteLine("{0}-> Is added To Stack ", temp.data);

                    //Assign Temp Link To Temp.
                    temp = temp.link;
                }
            }
        }
    }
}
