using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    internal class Student_report
    {
        public string Name { get; set; }

        // Array to store marks for 3 subjects
        public int[] Marks = new int[3];

        // Method to calculate total marks, average, and grade
        public void CalculateResult(out int total, out double average, out char grade)
        {
            total = 0;

            // Calculate total marks
            for (int i = 0; i < Marks.Length; i++)
            {
                total += Marks[i];
            }

            // Calculate average
            average = total / 3.0;

            // Decide grade based on average
            if (average >= 90)
                grade = 'A';
            else if (average >= 75)
                grade = 'B';
            else if (average >= 60)
                grade = 'C';
            else if (average >= 40)
                grade = 'D';
            else
                grade = 'F';
        }

        // Method to display the student’s report
        public void DisplayResult()
        {
            // Call the calculate method and get the results
            CalculateResult(out int total, out double average, out char grade);

            // Print the student’s report
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("Student Name : " + Name);
            Console.WriteLine("Subject 1    : " + Marks[0]);
            Console.WriteLine("Subject 2    : " + Marks[1]);
            Console.WriteLine("Subject 3    : " + Marks[2]);
            Console.WriteLine("Total Marks  : " + total);
            Console.WriteLine("Average Marks: " + average.ToString("F2"));
            Console.WriteLine("Grade        : " + grade);
            Console.WriteLine("------------------------------");
        }
}

    }
