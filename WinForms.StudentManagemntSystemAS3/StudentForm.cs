using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.StudentManagemntSystemAS3
{
    public partial class StudenDetailsForm : Form
    {
        public StudenDetailsForm()
        {
            InitializeComponent();
        }
        public void RefreshGridView()
        {
            
            StudentDataGridView.Rows.Clear();
            List<Student> studentlist = StudentDB.GetStudents();
            foreach (Student student in studentlist)
            {
                StudentDataGridView.Rows.Add(student.StudentID, student.FirstName, student.LastName, student.Age, student.Gender, student.ClassName, student.Grade);
            }

        }
        private void StudentForm_Load(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void button1Add_Click(object sender, EventArgs e)
        {

            AddStudentForm addStudent = new AddStudentForm(false, null);
            addStudent.ShowDialog();
            RefreshGridView();
        }

        private void Button3Delete_Click(object sender, EventArgs e)
        {
            if (StudentDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = StudentDataGridView.SelectedRows[0].Index;
                // Delete the selected student
                StudentDB.DeleteStudent(selectedIndex);
                RefreshGridView();
            }
            else
            {
                MessageBox.Show("Please select a student to delete");
            }
        }

        private void button2edit_Click(object sender, EventArgs e)
        {
            if (StudentDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = StudentDataGridView.SelectedRows[0].Index;

                Student selectedStudent = StudentDB.GetStudents()[selectedIndex];
                AddStudentForm addStudent = new AddStudentForm(true, selectedStudent);
                addStudent.ShowDialog();
                RefreshGridView();
            }
            else
            {
                MessageBox.Show("Please select a student to edit");
            }
        }

        private void button5Search_Click(object sender, EventArgs e)
        {
            string search = textboxsearch.Text;
            List<Student> studentlist = StudentDB.GetStudents();
            if (string.IsNullOrEmpty(search))
            {
                RefreshGridView();
                return;
            }
            else
            {
                var searchResult = studentlist.Where(s => s.StudentID.ToString().Contains(search) || s.FirstName.Contains(search) || s.LastName.Contains(search)).ToList();
                StudentDataGridView.Rows.Clear();
                foreach (Student student in searchResult)
                {
                    StudentDataGridView.Rows.Add(student.StudentID, student.FirstName, student.LastName, student.Age, student.Gender, student.ClassName, student.Grade);
                }
            }
        }

        private void Button4Exit_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }

}
