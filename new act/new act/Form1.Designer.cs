namespace new_act
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.homeBtn = new System.Windows.Forms.Button();
            this.registrationBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginControl1 = new new_act.LoginControl();
            this.registrationControl1 = new new_act.RegistrationControl();
            this.homeControl1 = new new_act.HomeControl();
            this.userDetailsPanel = new System.Windows.Forms.Panel();
            this.userdetailsLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailOutput = new System.Windows.Forms.TextBox();
            this.usernameOutput = new System.Windows.Forms.TextBox();
            this.passwordOutput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.userDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.registrationBtn);
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 474);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "UCP Application";
            // 
            // homeBtn
            // 
            this.homeBtn.Location = new System.Drawing.Point(49, 119);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(94, 23);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // registrationBtn
            // 
            this.registrationBtn.Location = new System.Drawing.Point(49, 161);
            this.registrationBtn.Name = "registrationBtn";
            this.registrationBtn.Size = new System.Drawing.Size(94, 23);
            this.registrationBtn.TabIndex = 2;
            this.registrationBtn.Text = "Registration";
            this.registrationBtn.UseVisualStyleBackColor = true;
            this.registrationBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(49, 206);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(94, 23);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // loginControl1
            // 
            this.loginControl1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.loginControl1.Location = new System.Drawing.Point(194, 0);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Size = new System.Drawing.Size(544, 471);
            this.loginControl1.TabIndex = 3;
            // 
            // registrationControl1
            // 
            this.registrationControl1.BackColor = System.Drawing.Color.Honeydew;
            this.registrationControl1.Location = new System.Drawing.Point(194, 0);
            this.registrationControl1.Name = "registrationControl1";
            this.registrationControl1.Size = new System.Drawing.Size(544, 474);
            this.registrationControl1.TabIndex = 2;
            // 
            // homeControl1
            // 
            this.homeControl1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.homeControl1.Location = new System.Drawing.Point(194, 0);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(544, 474);
            this.homeControl1.TabIndex = 1;
            // 
            // userDetailsPanel
            // 
            this.userDetailsPanel.Controls.Add(this.passwordOutput);
            this.userDetailsPanel.Controls.Add(this.usernameOutput);
            this.userDetailsPanel.Controls.Add(this.emailOutput);
            this.userDetailsPanel.Controls.Add(this.label3);
            this.userDetailsPanel.Controls.Add(this.label2);
            this.userDetailsPanel.Controls.Add(this.emailLabel);
            this.userDetailsPanel.Controls.Add(this.userdetailsLabel);
            this.userDetailsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.userDetailsPanel.Location = new System.Drawing.Point(733, 0);
            this.userDetailsPanel.Name = "userDetailsPanel";
            this.userDetailsPanel.Size = new System.Drawing.Size(226, 474);
            this.userDetailsPanel.TabIndex = 4;
            this.userDetailsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // userdetailsLabel
            // 
            this.userdetailsLabel.AutoSize = true;
            this.userdetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userdetailsLabel.Location = new System.Drawing.Point(61, 52);
            this.userdetailsLabel.Name = "userdetailsLabel";
            this.userdetailsLabel.Size = new System.Drawing.Size(121, 24);
            this.userdetailsLabel.TabIndex = 0;
            this.userdetailsLabel.Text = "User Details";
            this.userdetailsLabel.Click += new System.EventHandler(this.userdetailsLabel_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(18, 120);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(15, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // emailOutput
            // 
            this.emailOutput.Location = new System.Drawing.Point(82, 117);
            this.emailOutput.Name = "emailOutput";
            this.emailOutput.Size = new System.Drawing.Size(121, 20);
            this.emailOutput.TabIndex = 4;
            this.emailOutput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // usernameOutput
            // 
            this.usernameOutput.Location = new System.Drawing.Point(82, 145);
            this.usernameOutput.Name = "usernameOutput";
            this.usernameOutput.Size = new System.Drawing.Size(121, 20);
            this.usernameOutput.TabIndex = 5;
            // 
            // passwordOutput
            // 
            this.passwordOutput.Location = new System.Drawing.Point(82, 180);
            this.passwordOutput.Name = "passwordOutput";
            this.passwordOutput.Size = new System.Drawing.Size(121, 20);
            this.passwordOutput.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 474);
            this.Controls.Add(this.userDetailsPanel);
            this.Controls.Add(this.loginControl1);
            this.Controls.Add(this.registrationControl1);
            this.Controls.Add(this.homeControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.userDetailsPanel.ResumeLayout(false);
            this.userDetailsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button registrationBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Label label1;
        private HomeControl homeControl1;
        private RegistrationControl registrationControl1;
        private LoginControl loginControl1;
        private System.Windows.Forms.Panel userDetailsPanel;
        private System.Windows.Forms.TextBox emailOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label userdetailsLabel;
        private System.Windows.Forms.TextBox passwordOutput;
        private System.Windows.Forms.TextBox usernameOutput;
    }
}

