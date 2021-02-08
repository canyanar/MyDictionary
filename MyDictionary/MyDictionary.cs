using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] itemkey;
        TValue[] itemvalue;
        public MyDictionary() 
        {
            itemkey = new TKey[0];
            itemvalue = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] tempkey = itemkey;
            TValue[] tempvalue = itemvalue;
            itemkey = new TKey[itemkey.Length + 1];
            itemvalue = new TValue[itemvalue.Length + 1];
            for (int i = 0; i < tempkey.Length; i++)
            {
                itemkey[i] = tempkey[i];
            }
            for (int i = 0; i < tempvalue.Length; i++)
            {
                itemvalue[i] = tempvalue[i];
            }
            itemkey[itemkey.Length - 1] = key;
            itemvalue[itemvalue.Length - 1] = value;
        }
        public TValue[] Items
        {
            get { return itemvalue; }
        }

    }
}