using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_act
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string registrationPanelInputs
        {
            set
            {
                emailOutput.Text = value;
            }
        }
        public string registrationUserNameInput
        {
            set 
            {
                usernameOutput.Text = value;
            }
        }
        public string registrationPasswordInput 
        {
            set
            {
                passwordOutput.Text = value;
            }
        }
        public string registrationEmailInput
        {
            set
            {
                emailOutput.Text = value;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            userDetailsPanel.Hide();
            homeControl1.Show();
            homeControl1.BringToFront();

            loginControl1.Hide();
            registrationControl1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userDetailsPanel.Show();
            registrationControl1.Show();
            registrationControl1.BringToFront();

            loginControl1.Hide();
            homeControl1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userDetailsPanel.Hide();
            loginControl1.Show();
            loginControl1.BringToFront();

            registrationControl1.Hide();
            homeControl1.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                //userDetailsPanel should not show up upon loading
            userDetailsPanel.Hide();
            homeControl1.Show();
            homeControl1.BringToFront();

            loginControl1.Hide();
            registrationControl1.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void userdetailsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
