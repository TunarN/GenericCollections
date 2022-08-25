using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.models
{
    class CustomLIst<T>
    {
        T[] _arr;
        int _counter;
        public int Capacity { get; set; } = 3;
        public int Count { get => _arr.Length - _counter; }
        public CustomLIst()
        {
            _arr = new T[0];
        }
        public T this[int index]
        {
            get
            {
                if (index < _arr.Length)
                {
                    return _arr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index < _arr.Length)
                {
                    _arr[index] = value;
                }
                throw new IndexOutOfRangeException();
            }
        }
        public void Add(T value)
        {
            if (_counter == 0)
            {
                Array.Resize(ref _arr, _arr.Length + Capacity);
                _counter = Capacity;
            }
            _arr[Count] = value;
            _counter--;

        }
        public void Clear()
        {
            _counter = 0;
            _arr = new T[0];
        }
        public bool Exist(T item)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (object.Equals(item, _arr[i]))
                    return true;
            }

            return false;
        }
        public void Remove(T item)
        {
            for (int i = IndexOf(item); i < _arr.Length - 1; i++)
            {
                _arr[i] = _arr[i + 1];
            }
            Array.Resize(ref _arr, _arr.Length - 1);
        }
        public int IndexOf(T item)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (object.Equals(_arr[i], item))
                    return i;
            } 

            throw new KeyNotFoundException();
        }
        public int LastIndexOf(T item)
        {
            for (int i = _arr.Length - 1; i >= 0; i--)
            {
                if (object.Equals(_arr[i], item))
                    return i;
            }
            throw new KeyNotFoundException();
        }
    }
}
