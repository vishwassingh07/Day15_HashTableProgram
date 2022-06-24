using System;
namespace HashTableProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the HashTable Program \n================================");
            LinkedHashMap<string, int> linkedHashMap = new LinkedHashMap<string, int>(5);
            string sentence = " to be or not to be";
            string[] words = sentence.ToLower().Split(" ");
            foreach( string word in words)
            {
                int value = linkedHashMap.Get(word);
                if (value == default)
                {
                    value = 1;
                }
                else
                {
                    value = +1;
                }
                linkedHashMap.Add(word, value);
            }
            int frequency = linkedHashMap.Get("not");
            Console.WriteLine(frequency);
        }
    }
}