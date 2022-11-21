using System;

namespace HumansBrief {
    class LifeHours {
        public static void Main () {

        


//Create a simple program that calculates the number of life hours this class consumes.
// Have the program ask the user the following:
//What is your name? userName
//What is the name of your class? courseName
//How many weeks long is your class? classWeeks
//How many hours per week does your class meet? classHours
//How many students and instructors are in the class? classPeople


    //inputs that should have a string
    string userName = "";
    string courseName = "";

    //inputs that should have an int
    int classPeople = 0;
    int classHours = 0;
    int classWeeks = 0;
//Strings
// ask them their name until the string has something in it
//if the string is empty, print an error message 
    while (userName == "") {
        Console.WriteLine("Hello. What is your first name?");
        userName = Console.ReadLine();
        if (userName == "") {
            Console.WriteLine($"This is not a valid response. Please try again.");
        }
    }  
    while (courseName == "") {
        Console.WriteLine("What is the name of your class?");
        courseName = Console.ReadLine();
        if (courseName == "") {
            Console.WriteLine($"This is not a valid response. Please try again.");
        }
    }  
 
 //Ints
// Getting the duration in weeks

    while (classPeople > 1) {
        Console.WriteLine("How many people, including instructors, are in your course?");
        int.TryParse(Console.ReadLine(), out classPeople);
            Console.WriteLine("This is not a valid response. Please try again.");
            int.TryParse(Console.ReadLine(),out classPeople );
    }
        }
    }
}