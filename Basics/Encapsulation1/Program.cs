using System;

namespace EncapsulationExample
{
    // Student class encapsulates student details
    public class Student
    {
        // Private fields to store student data
        private string name;
        private int age;
        private double grade;

        // Public property to access and modify the student's name
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be empty or whitespace.");
                }
            }
        }

        // Public property to access and modify the student's age
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age must be a positive number.");
                }
            }
        }

        // Public property to access and modify the student's grade
        public double Grade
        {
            get { return grade; }
            set
            {
                if (value >= 0.0 && value <= 100.0)
                {
                    grade = value;
                }
                else
                {
                    Console.WriteLine("Grade must be between 0 and 100.");
                }
            }
        }

        // Constructor to initialize the student's details
        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        // Method to display the student's details
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Grade: {Grade:F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating a new student
            Student student = new Student("John Doe", 20, 85.5);

            // Displaying the initial details
            student.DisplayDetails();

            // Modifying the student's details using properties
            student.Name = "Jane Smith";
            student.Age = 22;
            student.Grade = 90.0;

            // Displaying the updated details
            Console.WriteLine("\nUpdated Student Details:");
            student.DisplayDetails();

            // Attempting to set invalid values (will trigger error messages)
            student.Name = "";
            student.Age = -5;
            student.Grade = 105.0;
        }
    }
}
