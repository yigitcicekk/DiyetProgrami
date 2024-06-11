namespace DiyetProgrami.PL
{
    partial class DieterInfoForm
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
            label1 = new Label();
            txtAge = new TextBox();
            txtHeight = new TextBox();
            label2 = new Label();
            txtWeight = new TextBox();
            label3 = new Label();
            radioBtnMale = new RadioButton();
            radioBtnFemale = new RadioButton();
            btnOK = new Button();
            btnCancel = new Button();
            label4 = new Label();
            cmbDietitian = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(18, 24);
            label1.Name = "label1";
            label1.Size = new Size(42, 23);
            label1.TabIndex = 0;
            label1.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.FromArgb(230, 231, 233);
            txtAge.BorderStyle = BorderStyle.None;
            txtAge.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(18, 47);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(130, 32);
            txtAge.TabIndex = 1;
            // 
            // txtHeight
            // 
            txtHeight.BackColor = Color.FromArgb(230, 231, 233);
            txtHeight.BorderStyle = BorderStyle.None;
            txtHeight.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHeight.Location = new Point(18, 105);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(130, 32);
            txtHeight.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(18, 82);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 2;
            label2.Text = "Height";
            // 
            // txtWeight
            // 
            txtWeight.BackColor = Color.FromArgb(230, 231, 233);
            txtWeight.BorderStyle = BorderStyle.None;
            txtWeight.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWeight.Location = new Point(18, 166);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(130, 32);
            txtWeight.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(116, 86, 174);
            label3.Location = new Point(18, 140);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 4;
            label3.Text = "Weight";
            // 
            // radioBtnMale
            // 
            radioBtnMale.AutoSize = true;
            radioBtnMale.ForeColor = Color.FromArgb(116, 86, 174);
            radioBtnMale.Location = new Point(200, 83);
            radioBtnMale.Name = "radioBtnMale";
            radioBtnMale.Size = new Size(70, 27);
            radioBtnMale.TabIndex = 6;
            radioBtnMale.TabStop = true;
            radioBtnMale.Text = "Male";
            radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // radioBtnFemale
            // 
            radioBtnFemale.AutoSize = true;
            radioBtnFemale.ForeColor = Color.FromArgb(116, 86, 174);
            radioBtnFemale.Location = new Point(200, 110);
            radioBtnFemale.Name = "radioBtnFemale";
            radioBtnFemale.Size = new Size(88, 27);
            radioBtnFemale.TabIndex = 7;
            radioBtnFemale.TabStop = true;
            radioBtnFemale.Text = "Female";
            radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.FromArgb(116, 86, 174);
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(293, 155);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(80, 37);
            btnOK.TabIndex = 8;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(116, 86, 174);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(200, 155);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 37);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(116, 86, 174);
            label4.Location = new Point(200, 24);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 10;
            label4.Text = "Dietitian";
            // 
            // cmbDietitian
            // 
            cmbDietitian.BackColor = SystemColors.MenuBar;
            cmbDietitian.FormattingEnabled = true;
            cmbDietitian.Location = new Point(200, 50);
            cmbDietitian.Name = "cmbDietitian";
            cmbDietitian.Size = new Size(151, 29);
            cmbDietitian.TabIndex = 11;
            // 
            // DieterInfoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(383, 226);
            Controls.Add(cmbDietitian);
            Controls.Add(label4);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(radioBtnFemale);
            Controls.Add(radioBtnMale);
            Controls.Add(txtWeight);
            Controls.Add(label3);
            Controls.Add(txtHeight);
            Controls.Add(label2);
            Controls.Add(txtAge);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DieterInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DieterIntoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAge;
        private TextBox txtHeight;
        private Label label2;
        private TextBox txtWeight;
        private Label label3;
        private RadioButton radioBtnMale;
        private RadioButton radioBtnFemale;
        private Button btnOK;
        private Button btnCancel;
        private Label label4;
        private ComboBox cmbDietitian;
    }
}