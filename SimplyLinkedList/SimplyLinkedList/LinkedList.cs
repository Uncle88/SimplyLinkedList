using System;
using System.Collections;
using System.Collections.Generic;

namespace SimplyLinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        Unit<T> head;
        Unit<T> tail;
        int count;

        public void AddUnit(T data)
        {
            Unit<T> _unit = new Unit<T>(data);

            if (head == null)
            {
                head = _unit;
            }
            tail.Next = _unit;
            tail = _unit;

            count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
