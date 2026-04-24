using System;
using System.Windows.Forms;

namespace StudentProfileForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // MAIN BUTTON LOGIC
        private void btnProcess_Click(object sender, EventArgs e)
        {
            // check empty fields
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtMarks.Text))
            {
                lblOutput.Text = "Please fill in all fields.";
                return;
            }

            int age;
            int marks;

            // validate age
            if (!int.TryParse(txtAge.Text, out age))
            {
                lblOutput.Text = "Invalid age. Please enter a number.";
                return;
            }

            // validate marks
            if (!int.TryParse(txtMarks.Text, out marks) || marks < 0 || marks > 100)
            {
                lblOutput.Text = "Marks must be between 0 and 100.";
                return;
            }

            string name = txtName.Text;

            string readiness = CalculateReadiness(marks);

            lblOutput.Text =
                "Student Profile\n" +
                $"Name: {name}\n" +
                $"Age: {age}\n" +
                $"Marks: {marks}\n" +
                $"Readiness: {readiness}\n" ;
        }

        //  READINESS METHOD
        private string CalculateReadiness(int marks)
        {
            if (marks >= 75)
                return "High";
            else if (marks >= 50)
                return "Medium";
            else
                return "Low";
        }

        // (ignore these - auto-generated events, safe to leave empty)
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
        private void txtMarks_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void lblOutput_Click(object sender, EventArgs e) { }
    }
}