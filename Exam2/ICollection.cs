using System;
using System.Collections.Generic;
using System.Text;

namespace Exam2
{
    interface ICollection
    {
        public int peek();
        public bool empty();

        public void push(int data);
        public void pop();
        public int getSize();
    }
}
