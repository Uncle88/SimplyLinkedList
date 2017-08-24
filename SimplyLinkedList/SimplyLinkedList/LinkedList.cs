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
