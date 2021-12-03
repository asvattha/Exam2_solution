using System;
using System.Collections.Generic;
using System.Text;

namespace Exam2
{
    class MyQueue
    {
        ICollection pushStack;
        ICollection popStack;

        public MyQueue(int size)
        {
            this.pushStack = new MyStack(size);
            this.popStack = new MyStack(size);
        }

        public void enqueue(int data)
        {
            pushStack.push(data);
        }

        public void dequeue()
        {
            if(popStack.empty() && pushStack.empty())
            {
                Console.WriteLine("Can't dequeue nothign in the queue");
                return;
            }
            if (popStack.empty())
            {
                for(int i = 0; i < popStack.getSize() - 1; i++)
                {
                    popStack.push(pushStack.peek());
                    pushStack.pop();
                }
            }
            popStack.pop();
        }

        public int peek()
        {
            int result  =0;
            if (popStack.empty())
            {
                for (int i = 0; i < popStack.getSize() - 1; i++)
                {
                    popStack.push(pushStack.peek());
                }
                result = popStack.peek();
                for (int i = 0; i < popStack.getSize() - 1; i++)
                {
                    popStack.pop();
                }
            }
            return result;
            
        } 

        public bool empty()
        {
            if(pushStack.empty() && popStack.empty())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
