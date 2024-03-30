using System;

namespace WinForms.StudentManagemntSystemAS3
{
    // Class representing a Student entity
    public class Student
    {
        // Properties
        public int StudentID { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public int Age { get; set; } 
        public string Gender { get; set; } 
        public string ClassName { get; set; } 
        public int Grade { get; set; } 

       

        // Default constructor
        public Student()
        {
            
        }

        // Parameterized constructor
        public Student(int studentID, string firstName, string lastName, int age, string gender, string classname, int grade)
        {
            // Assigning values to properties
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            ClassName = classname;
            Grade = grade;
        }

    }
}
