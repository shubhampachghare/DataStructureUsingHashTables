using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureUsingHashTables
{
    public class MyMapNode<k, v>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<k, v>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<k, v>>[size];
        }

        public int GetArrayPosition(k key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }


        public int Get(k key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<k, v>> linkedList = GetLinkedList(position);
            foreach (KeyValue<k, v> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    string s = item.Value.ToString();
                    return int.Parse(s);
                }
            }
            return 0;
        }


        public LinkedList<KeyValue<k, v>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<k, v>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<k, v>>();
                items[position] = linkedList;
            }
            return linkedList;
        }


        public struct KeyValue<k, v>
        {
            public k Key { get; set; }
            public v Value { get; set; }
        }


        public int getFrequencyOfWords(k key)
        {
            int poistion = GetArrayPosition(key);
            LinkedList<KeyValue<k, v>> linkedList = GetLinkedList(poistion);
            foreach (KeyValue<k, v> items in linkedList)
            {
                if (items.Key.Equals(key))
                {
                    string s = items.Value.ToString();
                    return s.Split(" ").Length;
                }
            }
            return 0;
        }


        public void Add(k key, v value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<k, v>> linkedList = GetLinkedList(position);
            KeyValue<k, v> item = new KeyValue<k, v>() { Key = key, Value = value, };
            linkedList.AddFirst(item);
        }


        public void Remove(k key)
        {
            int poistion = GetArrayPosition(key);
            LinkedList<KeyValue<k, v>> linkedList = GetLinkedList(poistion);
            bool itemFound = false;
            KeyValue<k, v> foundItem = default(KeyValue<k, v>);
            foreach (KeyValue<k, v> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                Console.WriteLine(key + " removed ");
                linkedList.Remove(foundItem);
            }
        }
    }

}
