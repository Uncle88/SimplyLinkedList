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

        public bool DeleteUnit(T data)
        {
            Unit<T> actual = head;
            Unit<T> antecedent = null;

            while (actual != null)
            {
                if (actual.Data.Equals(data))
                {
                    if (antecedent != null)
                    {
                        antecedent.Next = actual.Next;
                        if (actual.Next == null)
                            tail = antecedent;
                    }
                    else
                    {
                        head = head.Next;

                        if (head == null)
                            tail = null;
                    }

                    count--;
                    return true;
                }

                antecedent = actual;
                actual = actual.Next;
            }
            return false;
        }

        public void AppendFirstUnit(T data)
        {
            Unit<T> _unit = new Unit<T>(data);
            _unit.Next = head;
            head = _unit;

            if (count == 0)
                tail = head;
            count++;
        }

        public bool Contains(T data)
        {
            Unit<T> actual = head;
            while (actual != null)
            {
                if (actual.Data.Equals(data))
                    return true;
                actual = actual.Next;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Unit<T> _unit = head;
            while (_unit != null)
            {
                yield return _unit.Data;
                _unit = _unit.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
