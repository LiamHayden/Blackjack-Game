using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appPlayerConsent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // variables
            int age = 0;
            String genderTerm = "They";
            String firstName = txtFirstName.Text;
            String lastName = txtLastName.Text;

            // Ensure age is entered as an int
            if (age.GetType() == typeof(int))
            {
                try
                {
                    age = int.Parse(txtAge.Text);

                }
                catch
                {
                    MessageBox.Show("Age must be in a numeric format. i.e. 26.");
                }
            }
            
            // get gender
            if (radMale.Checked)
            {
                genderTerm = "He";
            }
            else if (radFemale.Checked)
            {
                genderTerm = "She";
            }

            // check age
            if (age < 18)
            {
            MessageBox.Show("Access denied - You must be at least 18 years old.");
            }
            else
            {
                // consent button
                if (chkTerms.Checked)
                {
                    DialogResult result = MessageBox.Show($"The current player is {firstName} {lastName}." + Environment.NewLine +
                        $"{genderTerm} is {age} years of age." + Environment.NewLine +
                        $"{genderTerm} has read the terms & conditions.");

                    // on ok click open form2
                    if (result == DialogResult.OK)
                    {
                        Form2 f2 = new Form2();
                        f2.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    lblMessage.Text = "(You must agree to the terms and conditions.)";
                }
            }
        }
            

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
