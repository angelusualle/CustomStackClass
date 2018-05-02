using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStackClassCS
{
    class CStack<T>
    {
        public class CStackNode<T>
        {
            public T data { get; set; }
            public CStackNode<T> next { get; set; }
            public CStackNode(T data)
            {
                this.data = data;
            }
        }
        private CStackNode<T> top;
        public T pop()
        {
            T datat = top.data;
            top = top.next;
            return datat;
        }
        public void push(T item)
        {
            CStackNode<T> topt = top;
            top = new CStackNode<T>(item);
            top.next = topt;
        }
        public T peek()
        {
            return top.data;
        }
        public bool isEmpty()
        {
            return top == null;
        }
    }
}
