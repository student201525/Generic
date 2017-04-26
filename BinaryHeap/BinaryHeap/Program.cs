using System;

namespace BinaryHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxBinaryHeap<int> MaxValue = new MaxBinaryHeap<int>();

            MaxValue.Insert(0);
            MaxValue.Insert(3);
            MaxValue.Insert(5);
            MaxValue.Insert(8);
            MaxValue.Insert(2);
            MaxValue.Insert(1);

            while (MaxValue.HeapSize > 0)
            {
                Console.WriteLine(MaxValue.Extract());
            }

        }
    }
}
