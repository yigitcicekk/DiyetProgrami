namespace DiyetProgrami.PL
{
    partial class RegisterForm
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
            label7 = new Label();
            btnRegister = new Button();
            checkbxShowPass = new CheckBox();
            txtComPassword = new TextBox();
            label6 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lblBackToLogin = new Label();
            radioBtnDieter = new RadioButton();
            radioBtnDietitian = new RadioButton();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(63, 590);
            label7.Name = "label7";
            label7.Size = new Size(163, 17);
            label7.TabIndex = 27;
            label7.Text = "Already Have an Account";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(116, 86, 174);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(34, 539);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(216, 35);
            btnRegister.TabIndex = 26;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // checkbxShowPass
            // 
            checkbxShowPass.AutoSize = true;
            checkbxShowPass.Cursor = Cursors.Hand;
            checkbxShowPass.FlatStyle = FlatStyle.Flat;
            checkbxShowPass.Location = new Point(128, 466);
            checkbxShowPass.Name = "checkbxShowPass";
            checkbxShowPass.Size = new Size(119, 21);
            checkbxShowPass.TabIndex = 25;
            checkbxShowPass.Text = "Show Password";
            checkbxShowPass.UseVisualStyleBackColor = true;
            checkbxShowPass.CheckedChanged += checkbxShowPass_CheckedChanged;
            // 
            // txtComPassword
            // 
            txtComPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtComPassword.BorderStyle = BorderStyle.None;
            txtComPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComPassword.Location = new Point(34, 432);
            txtComPassword.Multiline = true;
            txtComPassword.Name = "txtComPassword";
            txtComPassword.Size = new Size(216, 28);
            txtComPassword.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 412);
            label6.Name = "label6";
            label6.Size = new Size(120, 17);
            label6.TabIndex = 23;
            label6.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(34, 361);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 341);
            label4.Name = "label4";
            label4.Size = new Size(66, 17);
            label4.TabIndex = 21;
            label4.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(230, 231, 233);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(34, 294);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 28);
            txtEmail.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 274);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 19;
            label5.Text = "Email";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(230, 231, 233);
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(34, 230);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(216, 28);
            txtLastName.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 210);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 17;
            label3.Text = "Last Name";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(230, 231, 233);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(34, 163);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(216, 28);
            txtName.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 143);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 15;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(34, 94);
            label1.Name = "label1";
            label1.Size = new Size(145, 27);
            label1.TabIndex = 14;
            label1.Text = "FitJourney";
            // 
            // lblBackToLogin
            // 
            lblBackToLogin.AutoSize = true;
            lblBackToLogin.Cursor = Cursors.Hand;
            lblBackToLogin.ForeColor = Color.FromArgb(116, 86, 174);
            lblBackToLogin.Location = new Point(92, 615);
            lblBackToLogin.Name = "lblBackToLogin";
            lblBackToLogin.Size = new Size(97, 17);
            lblBackToLogin.TabIndex = 28;
            lblBackToLogin.Text = "Back to LOGIN";
            lblBackToLogin.Click += lblBackToLogin_Click;
            // 
            // radioBtnDieter
            // 
            radioBtnDieter.AutoSize = true;
            radioBtnDieter.Location = new Point(34, 478);
            radioBtnDieter.Name = "radioBtnDieter";
            radioBtnDieter.Size = new Size(64, 21);
            radioBtnDieter.TabIndex = 29;
            radioBtnDieter.TabStop = true;
            radioBtnDieter.Text = "Dieter";
            radioBtnDieter.UseVisualStyleBackColor = true;
            // 
            // radioBtnDietitian
            // 
            radioBtnDietitian.AutoSize = true;
            radioBtnDietitian.Location = new Point(34, 505);
            radioBtnDietitian.Name = "radioBtnDietitian";
            radioBtnDietitian.Size = new Size(80, 21);
            radioBtnDietitian.TabIndex = 30;
            radioBtnDietitian.TabStop = true;
            radioBtnDietitian.Text = "Dietitian";
            radioBtnDietitian.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(285, 700);
            Controls.Add(radioBtnDietitian);
            Controls.Add(radioBtnDieter);
            Controls.Add(lblBackToLogin);
            Controls.Add(label7);
            Controls.Add(btnRegister);
            Controls.Add(checkbxShowPass);
            Controls.Add(txtComPassword);
            Controls.Add(label6);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button btnRegister;
        private CheckBox checkbxShowPass;
        private TextBox txtComPassword;
        private Label label6;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private Label lblBackToLogin;
        private RadioButton radioBtnDieter;
        private RadioButton radioBtnDietitian;
    }
}