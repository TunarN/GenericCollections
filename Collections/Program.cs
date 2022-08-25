using Collections.models;
using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLIst<int> L = new CustomLIst<int>();
            L.Add(5);
            L.Add(3);
            L.Add(7);
            L.Add(23);
            L.Remove(21);
            L.IndexOf(5);
            L.Add(3);
            L.Exist(4);
            L.LastIndexOf(3);
            L.Clear();
            




        }

    }
}
