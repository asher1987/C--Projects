using System;
using System.Collections.Generic;

namespace DictionaryGradebook
{
    class Program
    {
        static void Main(string[]args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            string newStudent;

            Console.WriteLine("Enter your students ( or ENTER to finish):");

            // Get student names and grades
            do
            {
                Console.WriteLine("Student: ");
                string input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    Console.WriteLine("Grade: ");
                    input = Console.ReadLine();
                    double newGrade = double.Parse(input);
                    students.Add(newStudent, newGrade);

                    //Read in newLine before looping back
                    Console.ReadLine();
                }
            } while (!Equals(newStudent, ""));

            // Print class roster
            Console.WriteLine("\nClass roster:");
            double sum = 0.0;

            foreach (KeyValuePair<string, double> student in students)
            {
                sum += student.Value;
            }

            double avg = sum / students.Count;
            Console.WriteLine("Average grade: "+ avg);
    
    
            
        }
    }
}