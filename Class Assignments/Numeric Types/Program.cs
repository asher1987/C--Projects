using System;

namespace NumericTypes
{
    class Rectangle
    {
        static void Main(string[]args)
        {

            Console.WriteLine("When prompted, enter the length and width of the rectangle to find the area. To finish, hit ENTER");
            Console.WriteLine("What is the length of your rectangle?");
            string length = Console.ReadLine();
            int lengths = Int32.Parse(length);

            Console.WriteLine("What is the width of your rectangle?");
            string width = Console.ReadLine();
            int widths = Int32.Parse(length);

            int area = lengths * widths;
            Console.WriteLine("The area of your rectangle is: " + area);
        }
          

          
        }
    }
