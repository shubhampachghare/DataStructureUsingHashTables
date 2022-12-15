using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureUsingHashTables
{
    public class UC1WordFrequency
    {
        public void Frequency()
        {
            MyMapNode<string, int> myMapNode = new MyMapNode<string, int>(5);
            string sentence = "To be or not to be";
            string[] words = sentence.ToLower().Split(" ");
            foreach (string word in words)
            {
                int value = myMapNode.Get(word);
                if (value == 0)
                    value = 1;
                else
                    value = value + 1;
                myMapNode.Add(word, value);
            }
            int frequency = myMapNode.Get("be");
            Console.WriteLine("Frequency of be = " + frequency);
        }
    }
}
