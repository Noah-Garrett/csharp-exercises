﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Gradebook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> students = new List<string>();
            List<double> grades = new List<double>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    students.Add(newStudent);
                }
            }
            while (newStudent != "");

            //write a index based for loop to print the students list
            for (int i = 0; i<students.Count; i++)
            {
                Console.WriteLine((i+1)+ " " + students[i]);
            }

            // Get student grades
            foreach (string student in students)
            {
                Console.WriteLine("Grade for " + student + ": ");
                double newGrade = double.Parse(Console.ReadLine());
                grades.Add(newGrade);
            }

            // Print class roster
            Console.WriteLine("\nClass roster:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i] + " (" + grades[i] + ")");
            }

            double sum = grades.Sum();
            double avg = sum / grades.Count;
            Console.WriteLine("Average grade: " + avg);

            Console.ReadLine();
        }
    }
}
