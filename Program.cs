using System;

//Create a simple program that calculates the number of life hours this class consumes.
// Have the program ask the user the following:
//What is your name? userName
//What is the name of your class? courseName
//How many weeks long is your class? classWeeks
//How many hours per week does your class meet? classHours
//How many students and instructors are in the class? classPeople

static void UserInput(string[] args) 
{
    //inputs that should have a string
    string userName, input;
    string courseName, input;

    //inputs that should have an int
    int classPeople;
    int classHours;
    int classWeeks;

//Strings
    Console.WriteLine("Hello. What is your first name?");
    userName = Console.ReadLine();
    if (userName == "") {
        Console.WriteLine($"This is not a valid response. Please try again.");
    }
    else
     {
        Console.WriteLine("That is an invalid response. Make sure you are only using letters in your respone. Example: Intro to Programming.");
     }

    Console.WriteLine("Thank you. What is the name of your course?");
    courseName = Console.ReadLine();
     if (courseName == "") {
        Console.WriteLine($"This is not a valid response. Please try again."); 
     }
     else
     {
        Console.WriteLine("That is an invalid response. Make sure you are only using letters in your respone. Example: Intro to Programming.");
     }

//Ints
    Console.WriteLine("How many people, including instructors, are in your course?");
    input = Console.ReadLine();
    classPeople = Convert.ToInt32(input);

    Console.WriteLine("How many hours per week does your class meet?");
    classHours = Convert.ToInt32(input);
    if (classHours > 1 ) {
        Console.WriteLine("That is an invalid response. Please try again.");
    }
    else
    {
        Console.WriteLine("That is an invalid response. Make sure you are only inputting integers. Example: 5.");
    }
    Console.WriteLine("How many weeks does your class meet?");
    classWeeks = Convert.ToInt32(input);
    if (classWeeks > 1 ) {
        Console.WriteLine("That is an invalid response. Please try again.");
        }
    else
    {
        Console.WriteLine("That is an invalid response. Make sure you are only inputting integers. Example: 5.");
    }

//doing the work
lifeHours = classHours * classWeeks * classPeople ;
    Console.WriteLine("Thank you for your responses. Calculating LifeHours.");
    Console.WriteLine("Are you ready to compute your life hours? Please type 'Yes' to continue.");
    if (Console.ReadLine == "Yes") {
        Console.WriteLine($"{lifeHours} is the number of life hours for this course.");
    }
    else
    {
        Console.WriteLine("That is an invalid response. Please type 'Yes' to continue.");
    }

}