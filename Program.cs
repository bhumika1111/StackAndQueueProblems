using System;

namespace StackAndQueues
{
    //Driver Code.
    public class Program
    {

       public static void Main(string[] args)
        {
            Console.WriteLine(":::::::Welcome To Stack And Queues Program::::::::");
            Console.WriteLine("Press 0 For Exit ");
            Console.WriteLine("1. Create Stack For 56->30->70->");
            Console.WriteLine("2. Peek And Pop Operation In Stack Until Stack Is Not Empty");
           
            int Choice = Convert.ToInt32(Console.ReadLine());
            switch(Choice)

            {
                case 1:
                Console.WriteLine("***output for Creating Stack Using LinkedList For 56->30->70->***");
               // Create Object Of Implementing Class.
                StackUsingLinkedList obj = new StackUsingLinkedList();

                //Insert Stack Value.
                obj.push(70);
                obj.push(30);
                obj.push(56);

                //Print Stack Element.
                obj.Display();
                    break;

                case 2:
                Console.WriteLine("****Output For Peek And Pop Operation In Stack Until Stack Is Not Empty***");
                 Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                 // Create Object Of Implementing Class.
                PeekAndPopFromStack obj1 = new PeekAndPopFromStack();
                //Insert Stack Value.
                obj1.push(70);
                obj1.push(30);
                obj1.push(56);
                //Print Stack Element.
                obj1.Display();

                //Print Top Element Of Stack.
                Console.WriteLine("Top Element Is {0}", obj1.peek());

                //Delete Top Element Of Stack.
                obj1.pop();
                obj1.pop();

                //Print Stack Element.
                obj1.Display();

                //Print Top Element Of Stack.
                Console.WriteLine("Top Element Is {0}", obj1.peek());
                    break;
             
                    
                   
                    



            }
        }
    }
}
