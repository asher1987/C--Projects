using System;

namespace CountingCharacters
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string
            value = " ";
            foreach (char a in value)
            {
                Console.WriteLine (a);
            }
                    Dictionary<char, int> diclist = new Dictionary<char, int> ();
                Console.WriteLine("Please Enter Your Phrase");

                foreach (var chr in Console.ReadLine())
          {
            int count = 0; 
            if(diclist.ContainsKey(chr))
            {
                count = diclist[chr];

            }
            diclist[chr] = count +1;
                }
                foreach (KeyValuePair<char, int> pair in diclist)
                {
                    Console.WriteLine(pair.Key + " = " + pair.Value);
                }      
            Console.ReadLine();

        }
    }
}