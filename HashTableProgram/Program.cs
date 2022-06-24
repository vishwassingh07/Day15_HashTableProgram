using System;
namespace HashTableProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the HashTable Program \n================================");
            LinkedHashMap<string, int> linkedHashMap = new LinkedHashMap<string, int>(5);
            //string sentence = " to be or not to be";
            //string[] words = sentence.ToLower().Split(" ");
            //foreach( string word in words)
            //{
            //    int value = linkedHashMap.Get(word);
            //    if (value == default)
            //    {
            //        value = 1;
            //    }
            //    else
            //    {
            //        value = +1;
            //    }
            //    linkedHashMap.Add(word, value);
            //}
            //int frequency = linkedHashMap.Get("not");
            //Console.WriteLine(frequency);

            //string Paragraph = "“Paranoids are not paranoid because they are " +
            //  "paranoid but because they keep putting themselves deliberately into" +
            //  " paranoid avoidable situations";
            //string[] letters = Paragraph.ToLower().Split(" ");

            //foreach (string word in letters)
            //{
            //    int value = linkedHashMap.Get(word);
            //    if (value == default)
            //    {
            //        value = 1;
            //    }
            //    else value += 1;
            //    linkedHashMap.Add(word, value);
            //}
            //int frequency1 = linkedHashMap.Get("paranoid");
            //Console.WriteLine(frequency1);

            linkedHashMap.Remove("avoidable");
            int frequency2 = linkedHashMap.Get("avoidable");
            Console.WriteLine(frequency2);
        }
    }
}