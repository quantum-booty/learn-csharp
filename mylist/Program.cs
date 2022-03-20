using System;

namespace mylist
{

    public class MyList<T>
    {
        const int DefaultCapacity = 4;

        T[] _items;
        int _count;

        public MyList(int capacity = DefaultCapacity)
        {
            _items = new T[capacity];
        }

        public int Count => _count;

        public int Capacity
        {
            get => _items.Length;
            set
            {
                if (value < _count) value = _count;
                if (value != _items.Length)
                {
                    T[] newItems = new T[value];
                    Array.Copy(_items, 0, newItems, 0, _count);
                    _items = newItems;
                }
            }
        }

        // indexer
        // indexer allows class instance to be have cls_inst[idx] syntax for accessing values by index
        public T this[int index]
        {
            get => _items[index];
            set
            {
                _items[index] = value;
                OnChanged();
            }
        }

        public void Add(T item)
        {
            if (_count == Capacity) Capacity = _count * 2;
            _items[_count] = item;
            _count++;
            OnChanged();
        }

        protected virtual void OnChanged() =>
            Changed?.Invoke(this, EventArgs.Empty);

        public override bool Equals(object other) => 
            Equals(this, other as MyList<T>);

        static bool Equals(MyList<T> a, MyList<T> b)
        {
            // if a and b are null, then a==b
            if (Object.ReferenceEquals(a, null)) return Object.ReferenceEquals(b, null);
            // if b is not null, but a and b has different length, a!=b
            if (Object.ReferenceEquals(b, null) || a._count != b._count)
                return false;
            // if any list element does not equal, a!=b
            for (int i = 0; i < a._count; i++)
            {
                if (!object.Equals(a._items[i], b._items[i]))
                {
                    return false;
                }
            }
            // a == b
            return true;
        }

        public event EventHandler Changed;

        public static bool operator ==(MyList<T> a, MyList<T> b) =>
            Equals(a, b);

        public static bool operator !=(MyList<T> a, MyList<T> b) =>
            !Equals(a, b);
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();

            names.Capacity = 100;

            Console.WriteLine(names.Count);
            Console.WriteLine(names.Capacity);
        }
    }
}
