using System;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack(3000);

            stack.push(1);
            stack.push(2);
            Console.WriteLine(stack.peek()); 
            stack.pop();
            stack.pop();
            Console.WriteLine(stack.empty());

            MyQueue queue = new MyQueue(3000);
            queue.enqueue(1);
            queue.enqueue(2);
            Console.WriteLine(queue.peek());
            queue.dequeue();
            Console.WriteLine(queue.empty());
        }
    }
}
