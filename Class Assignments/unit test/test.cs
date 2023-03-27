using System;
using System.Collections.Generic;

class Program1
{
    static void Main1()
    {
        string inputString = "this is a test";
        Dictionary<char, int> expectedOutput = new Dictionary<char, int> ()
        {
            {'t', 3},
            {'h', 1},
            {'i', 2},
            {'s', 3},
            {'a', 1},
            {'e', 1}
        };
        Dictionary<char, int> actualOutput = CountCharacters(inputString);
        Console.WriteLine("Expected output: ");
        PrintDictionary(expectedOutput);
        Console.WriteLine("Acutal output: ");
        PrintDictionary(actualOutput);

        if (DictionaryEquals(expectedOutput, actualOutput))
        {
            Console.WriteLine("The test passed");
        }
        else
        {
            Console.WriteLine("Test failed");
        }
    }

    static Dictionary<char, int> CountCharacters(string inputString)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        foreach (char c in inputString)
        {
            if (charCount.ContainsKey(c))
            {
                charCount [c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }
        return charCount;
    }

    static void PrintDictionary(Dictionary<char, int> dict)
    {
        foreach (KeyValuePair<char, int> pair in dict)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }
    static bool DictionaryEquals(Dictionary<char, int> dict1, Dictionary<char, int> dict2)
    {
        if (dict1.Count != dict2.Count)
        {
            return false; 
        }
        foreach (KeyValuePair<char, int> pair in dict1)
        {
            if (!dict2.ContainsKey(pair.Key) || dict2[pair.Key] != pair.Value)
            {
                return false;
            }
        }
        return true;
    }
}
