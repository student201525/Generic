using System;

namespace BinaryHeap
{
    class MinBinaryHeap<T> : BinaryHeap<T>
        where T : IComparable
    {

        public MinBinaryHeap() : base() { }

        public void Insert(T value)
        {
            heap.Add(value);

            int i = HeapSize - 1;
            int parent = (i - 1) / 2;

            while (i > 0 && heap[parent].CompareTo(heap[i]) < 0)
            {
                T temp = heap[i];
                heap[i] = heap[parent];
                heap[parent] = temp;
                i = parent;
                parent = (i - 1) / 2;
            }
        }

        public T Extract()
        {
            var value = heap[0];
            heap[0] = heap[HeapSize - 1];
            heap.RemoveAt(HeapSize - 1);

            if (HeapSize > 0)
            {
                rebuild();
            }

            return value;
        }

        void rebuild()
        {
            int LeftParent;
            int RightParent;
            int max;
            int i = 0;

            for (;;)
            {
                LeftParent = 2 * i + 1;
                RightParent = 2 * i + 2;
                max = i;

                if (LeftParent < HeapSize && heap[LeftParent].CompareTo(heap[max]) > 0)
                {
                    max = LeftParent;
                }

                if (RightParent < HeapSize && heap[RightParent].CompareTo(heap[max]) > 0)
                {
                    max = RightParent;
                }

                if (max != i)
                {
                    T temp = heap[max];
                    heap[max] = heap[i];
                    heap[i] = temp;
                    i = max;
                }

                else
                {
                    break;
                }
            }
        }
    }
}
