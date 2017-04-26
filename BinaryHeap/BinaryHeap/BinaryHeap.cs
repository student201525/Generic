using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryHeap
{
   public class BinaryHeap<T>
       where T : IComparable
    {
        public List<T> heap;

        public BinaryHeap()
        {
            heap = new List<T>();
        }

        public int HeapSize
        {
            get
            {
                return heap.Count();
            }      
        }
    }
}
