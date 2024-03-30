using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.StudentManagemntSystemAS3
{
    // Form for adding or updating student information
    public partial class AddStudentForm : Form
    {
        bool isUpdate; // Indicates whether the form is for updating an existing student
        Student student; // Represents the student being updated (if applicable)

        // Constructor
        public AddStudentForm(bool isUpdate, Student student)
        {
            InitializeComponent();
            this.isUpdate = isUpdate;
            this.student = student;
        }

        // Event handler for form load event
        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            // If the form is for updating an existing student, populate the form fields with student data
            if (isUpdate)
            {
                button1add.Text = "Update"; // Change button text to indicate update action
                Idtextbox.ReadOnly = true; // Disable editing of student ID
                Idtextbox.Text = student.StudentID.ToString(); // Display student ID
                firstnametxtbox.Text = student.FirstName; // Display first name
                lastnametextbox.Text = student.LastName; // Display last name
                agetextbox.Text = student.Age.ToString(); // Display age
                gendertextbox.Text = student.Gender; // Display gender
                classtextbox.Text = student.ClassName; // Display class name
                gradetextbox.Text = student.Grade.ToString(); // Display grade
            }
        }

        // Event handler for add/update button click event
        private void button1add_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (!int.TryParse(Idtextbox.Text, out int id))
            {
                MessageBox.Show("Invalid Student ID , Please enter a valid ID");
            }
            else if (!int.TryParse(agetextbox.Text, out int age))
            {
                MessageBox.Show("Invalid Age. Please enter a valid Age");
            }
            else if (!int.TryParse(gradetextbox.Text, out int grade))
            {
                MessageBox.Show("Invalid Grade. Please enter digit");
            }
            else if (isUpdate)
            {
                // Update existing student
                StudentDB.UpdateStudent(new Student(id, firstnametxtbox.Text, lastnametextbox.Text, age, gendertextbox.Text, classtextbox.Text, grade));
                MessageBox.Show("Student updated successfully");
                this.Close();
            }
            else
            {
                // Add new student
                Student newStudent = new Student(id, firstnametxtbox.Text, lastnametextbox.Text, age, gendertextbox.Text, classtextbox.Text, grade);
                List<Student> students = StudentDB.GetStudents();
                students.Add(newStudent); // Add the newly added student to the list
                StudentDB.SaveStudents(students); // Save the list of students to the file
                MessageBox.Show("Student added successfully");
                this.Close();
            }
        }

        // Event handler for exit button click event
        private void button2Exit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }
    }
}
