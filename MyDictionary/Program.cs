using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1, "Can");
            myDictionary.Add(2, "Yanar");
            foreach (var name in myDictionary.Items)
            {
                Console.WriteLine(name);
            }
        }
    }
}