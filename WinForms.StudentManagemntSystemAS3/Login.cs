using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.StudentManagemntSystemAS3
{
    // Form for user login
    public partial class Login : Form
    {
        // Path to the file storing user credentials
        private static readonly string UserPath = @"C:\Users\JISNA\Desktop\Assignment3c#\WinForms.StudentManagemntSystemAS3\WinForms.StudentManagemntSystemAS3\user.txt";

        // Constructor
        public Login()
        {
            InitializeComponent();
        }

        // Method to validate user credentials
        private bool ValidateUser(string username, string password)
        {
            // Read the file and store user credentials into a dictionary
            var userCredentials = File.ReadAllLines(UserPath)
                                      .Select(line => line.Split(':'))
                                      .ToDictionary(split => split[0], split => split[1]); // Assuming first element is username and second is password

            // Check if the provided username exists and if the password matches
            if (userCredentials.ContainsKey(username) && userCredentials[username] == password)
            {
                return true; // Credentials match, authentication successful
            }
            else
            {
                return false; // No matching credentials found
            }
        }

        // Event handler for exit button click event
        private void button2exit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }

        // Event handler for login button click event
        private void Loginbutton1_Click(object sender, EventArgs e)
        {
            string username = usernametxtbox.Text;
            string password = passwordtextbox.Text;

            // Check if username or password is empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your  Username and Password");
                return;
            }
            else if (ValidateUser(username, password)) // If user credentials are valid
            {
                MessageBox.Show("Login Successful");
                StudenDetailsForm studentForm = new StudenDetailsForm(); // Create instance of StudentDetailsForm
                this.Hide(); 
                studentForm.ShowDialog(); // Show the StudentDetailsForm
            }
            else // If user credentials are invalid
            {
                MessageBox.Show("Credentials are not valid. Please enter valid credentials");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}


