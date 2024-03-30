using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.StudentManagemntSystemAS3
{
    // Internal class responsible for managing student data in a text file
    internal class StudentDB
    {
        // Path to the file storing student data
        private static readonly string Path = @"C:\Users\JISNA\Desktop\Assignment3c#\WinForms.StudentManagemntSystemAS3\WinForms.StudentManagemntSystemAS3\students.txt";
        // Method to retrieve the list of students from the file
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            // Open the file for reading
            using (StreamReader textIN = new StreamReader(new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read)))
            {
                string row;
                // Read each line from the file
                while ((row = textIN.ReadLine()) != null)
                {
                    // Split the line into columns
                    string[] columns = row.Split(',');

                    // If the line contains all expected columns
                    if (columns.Length == 7)
                    {
                        // Create a new Student object and populate its properties
                        Student student = new Student
                        {
                            StudentID = Convert.ToInt32(columns[0]),
                            FirstName = columns[1],
                            LastName = columns[2],
                            Age = Convert.ToInt32(columns[3]),
                            Gender = columns[4],
                            ClassName = columns[5],
                            Grade = Convert.ToInt32(columns[6])
                        };

                        // Add the student to the list
                        students.Add(student);
                    }
                }
            }
            return students;
        }

        // Method to save the list of students to the file
        public static void SaveStudents(List<Student> students)
        {
            // Open the file for writing
            using (StreamWriter textOUT = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write)))
            {
                // Write each student's data to the file
                foreach (Student student in students)
                {
                    textOUT.Write(student.StudentID + ",");
                    textOUT.Write(student.FirstName + ",");
                    textOUT.Write(student.LastName + ",");
                    textOUT.Write(student.Age + ",");
                    textOUT.Write(student.Gender + ",");
                    textOUT.Write(student.ClassName + ",");
                    textOUT.WriteLine(student.Grade);
                }
            }
        }

        // Method to update an existing student's data in the file
        public static void UpdateStudent(Student updatedStudent)
        {
            // Retrieve the list of students
            List<Student> students = GetStudents();

            // Find the index of the student to update
            int index = students.FindIndex(s => s.StudentID == updatedStudent.StudentID);

            // Update the student at the found index
            students[index] = updatedStudent;

            // Save the updated list of students to the file
            SaveStudents(students);
        }

        // Method to delete a student from the file
        public static void DeleteStudent(int index)
        {
            // Retrieve the list of students
            List<Student> students = GetStudents();

            // Display a confirmation dialog before deleting
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                // If user chooses not to delete, return without further action
                return;
            }

            // Remove the student at the specified index
            students.RemoveAt(index);

            // Save the updated list of students to the file
            SaveStudents(students);
        }
    }
}
