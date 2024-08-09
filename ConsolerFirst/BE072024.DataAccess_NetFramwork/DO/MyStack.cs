using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFramwork.DO
{
    public class MyStack<T>
    {
        public Stack<T> stack = new Stack<T>();
        
        public MyStack() { 
        stack = new Stack<T>();
        }
        public void Push(T item)
        {
            stack.Push(item);
        }
        public T Pop()
        {
           return stack.Pop();
        }
        public T Peek()
        {
           return stack.Peek();
        }
        public bool IsEmpty()
        {
            return stack == null?true:false;
        }

       public string toString()
        {
            return stack.ToString();
        }
    }
}
