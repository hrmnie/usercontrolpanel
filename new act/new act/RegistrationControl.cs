using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_act
{
    public partial class RegistrationControl : UserControl
    {
        public RegistrationControl()
        {
            InitializeComponent();
        }

        private void homeLabel_Click(object sender, EventArgs e)
        {

        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var emailInput = this.emailInput.Text;
            var usernameInput = this.usernameInput.Text;
            var passwordInput = this.passwordInput.Text;

            //Parent

            var parent = this.Parent as Form1;
            parent.registrationUserNameInput = usernameInput;
            parent.registrationEmailInput = emailInput;
            parent.registrationPasswordInput = passwordInput;

        }
    }
}
