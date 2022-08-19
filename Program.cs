using System;

namespace StackAndQueue
{
    //Driver Class
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("::::::::::Welcome To Stack And Queue Program:::::::::");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("***Press 0 To Exit****");
            Console.WriteLine("***1. Queue Operation Using LinkedList, For Checking Enqueue method  56->30->70 getting 56 At Front ***");
            Console.WriteLine("***2. Queue Operation Using LinkedList,For Checking Dequeue method***");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("**Output For Checking Queue **");
                    Queue queue = new Queue();

                    queue.Enqueue(56);
                    queue.Enqueue(30);
                    queue.Enqueue(70);
                    Console.WriteLine("Queue Front" + queue.front.key);
                    Console.WriteLine("Queue Rear" + queue.rear.key);
                    break;
                case 2:
                    Console.WriteLine("**Output For Checking Dequeue**");

                    Queues queues = new Queues();

                    queues.Enqueue(56);
                    queues.Enqueue(30);
                    queues.Enqueue(70);
                    Console.WriteLine("Queue Front" + queues.front.key);
                    Console.WriteLine("Queue Rear" + queues.rear.key);

                    Console.WriteLine("Dequeue");
                    queues.Dequeue();
                    queues.Dequeue();
                    queues.Dequeue();
                    break;



            }
        }
    }
}
