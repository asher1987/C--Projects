using System;
using System.Collections.Generic;

class Program
{
    static void Main() // entry point method in a C# console app.
    // static is a keyword that indicates the method belongs to the class itself instead of an instance of a class
    // void keyword indicates that the method doesn't return a value. 
    //Main() is a method that takes no arguments. 
    //Static void Main() is a method that is required in a C# program
    {
        string inputString = "this is a test";
        // statement that declares a variable 'inputString' and initalizes it by giving it a value "This is a test"

        Dictionary<char, int> charCount = CountCharacters(inputString);
        // statement that creates a new dictionary and initializes it with key-value pairs
        // the CountCharacters method takes a string parameter and returns a dictionary containing the count of each character from the string
        //charCount is a variable of type Dictionary that stores the count of each character in the input string

        Console.WriteLine("Character counts:");
        //this prints out "Character counts" prior to printing our dictionary 

        foreach (KeyValuePair<char, int> pair in charCount)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value );
        }
        // this is a foreach loop that iterates over the key-value pairs in the
        //'charCount dictionary and prints them to the console. 
        // the string "{0}: {1}" is a formatted string that includes two place holders that
        //will be replaced with the key and the value pair. 
    }

    static Dictionary<char, int> CountCharacters(string inputString)
    // declares a static method named 'CountCharacters'  with a string paramater
    // called inputString and a return type of Dictionary
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        // creates a empty dictionary that can be used to store character counts and assigns it to the variable 'charCount'
        // the new Dictionary<char, int>() creates a new instance of Dictionary and initializies 
        // it with no key-pair values. The empty parenthese indicates that the dictionary is being created
        // with the default constructor 

        foreach (char c in inputString)
        // this loop iterates over each character in the 'inputString' variable
        // the loop will execute once for each character in the 'inputString' variable. 
        //on each iteration, the current charadcter in the loop iteration will be assigned to the 'c' variable
        // and the loop body will execute. 
        {
            if(charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;

            }
            // this block of code is used to count hte number of occurences of each character in the input string a
            // and update the 'charCount' dictionary with the character count
        }
        return charCount;
    }
}
