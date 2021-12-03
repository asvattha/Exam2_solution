using System;
using System.Collections.Generic;
using System.Text;

namespace Exam2
{
    class MyStack: ICollection
    {

        int[] array;
        int topIndex; 

        public MyStack(int size)
        {
            topIndex = -1;
            array = new int[size];
        }

        public void push(int data)
        {
            array[++topIndex] = data;
        }

        public void pop()
        {
            --topIndex;
            Console.WriteLine(topIndex);
        }

        public int peek()
        {
            return array[topIndex];
            
        }

        public bool empty()
        {
            if(topIndex >= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int getSize()
        {
            return topIndex+1;
        }
    }
}
