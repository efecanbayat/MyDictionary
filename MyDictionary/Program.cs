using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(123, "Efe");
            myDictionary.Add(456, "Mücahit");
            myDictionary.Add(789, "Onur");

            myDictionary.List();
            
        }
    }
}
