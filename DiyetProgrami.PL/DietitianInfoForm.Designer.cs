namespace DiyetProgrami.PL
{
    partial class DietitianInfoForm
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
            txtSpecialization = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(93, 17);
            label1.TabIndex = 0;
            label1.Text = "Specialization";
            // 
            // txtSpecialization
            // 
            txtSpecialization.BackColor = Color.FromArgb(230, 231, 233);
            txtSpecialization.BorderStyle = BorderStyle.None;
            txtSpecialization.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSpecialization.ForeColor = SystemColors.WindowText;
            txtSpecialization.Location = new Point(24, 49);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new Size(202, 26);
            txtSpecialization.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.FromArgb(116, 86, 174);
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(131, 102);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(95, 31);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(116, 86, 174);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(24, 102);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(101, 31);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // DietitianInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(258, 179);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtSpecialization);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DietitianInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DietitianInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSpecialization;
        private Button btnOK;
        private Button btnCancel;
    }
}