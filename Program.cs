using System;

namespace DataStructureUsingHashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to data structure using hash table ");
            Console.WriteLine("UC1: ");
            WordFrequency freq = new WordFrequency();
            freq.Frequency();

            Console.WriteLine("\n UC2: ");
            WordFrequency freq1 = new WordFrequency();
            freq1.FreqPara();

            Console.WriteLine("\n UC3: ");
            WordFrequency rm = new WordFrequency();
            rm.Remove();

        }

    }
}
