using System;
using System.Collections;
using System.Collections.Generic;

namespace SimplyLinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        public LinkedList()
        {
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
