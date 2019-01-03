using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmsCsharp.DataStructures
{
    public class LinkedStack<T>:IEnumerable
    {
        private int _n; //size of the stack
        private Node _first = null; //top of the stack
        private class Node
        {
            public T Item;
            public Node Next;
        }

        public Boolean IsEmpty()
        {
            return _first == null;
        }

        public int Size()
        {
            return _n;
        }

        public void Push(T item)
        {
            Node oldfirst = _first;
            _first = new Node
            {
                Item = item,
                Next = oldfirst
            };
            _n++;
        }

        public T Pop()
        {
            if(IsEmpty()) throw new Exception("Stack underflow");
            T item = _first.Item;
            _first = _first.Next;
            _n--;
            return item;
        }

        public T Peek()
        {
            if (IsEmpty()) throw new Exception("Stack underflow");
            return _first.Item;
        }

        public IEnumerator GetEnumerator()
        {
            Node cur = _first;
            while (cur != null)
            {
                yield return cur.Item;
                cur = cur.Next;
            }
        }
    }
}