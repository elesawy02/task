//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace task
//{
//    internal class FixedSizeList

//    {
//        public  class FixedSizeList1<T>
//        {
//            private T[] _items;
//            private int _count;

//            public FixedSizeList1(int capacity)
//            {
//                if (capacity <= 0)
//                {
//                    throw new ArgumentException("Capacity must be greater than zero.");
//                }
//                _items = new T[capacity];
//                _count = 0;
//            }

//            public int Count => _count;

//            public int Capacity => _items.Length;

//            public void Add(T item)
//            {
//                if (_count >= _items.Length)
//                {
//                    throw new InvalidOperationException("List is full.");
//                }
//                _items[_count] = item;
//                _count++;
//            }

//            public T Get(int index)
//            {
//                if (index < 0 || index >= _count)
//                {
//                    throw new IndexOutOfRangeException("Invalid index.");
//                }
//                return _items[index];
//            }
//        }
//    }
//}
