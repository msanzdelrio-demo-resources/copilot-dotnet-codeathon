using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge1
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string result = SortByFrequency(input);
            Console.WriteLine("Sorted string: " + result);
        }

        public static string SortByFrequency(string str)
        {
            var frequencyDict = new Dictionary<char, int>();
            foreach (var c in str)
            {
                if (frequencyDict.ContainsKey(c))
                    frequencyDict[c]++;
                else
                    frequencyDict[c] = 1;
            }

            var sortedDict = frequencyDict.OrderBy(x => x.Key).OrderByDescending(x => x.Value);
            string result = "";
            foreach (var item in sortedDict)
            {
                result += new string(item.Key, item.Value);
            }

            return result;
        }
    }
}