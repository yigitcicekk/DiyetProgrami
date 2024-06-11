namespace DiyetProgrami.PL
{
    partial class YoneticiFormu
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
            btnDieterLogin = new Button();
            btnDietitianLogin = new Button();
            SuspendLayout();
            // 
            // btnDieterLogin
            // 
            btnDieterLogin.Location = new Point(168, 151);
            btnDieterLogin.Name = "btnDieterLogin";
            btnDieterLogin.Size = new Size(148, 81);
            btnDieterLogin.TabIndex = 0;
            btnDieterLogin.Text = "Diyet Yapan Kişi Girişi";
            btnDieterLogin.UseVisualStyleBackColor = true;
            btnDieterLogin.Click += btnDieterLogin_Click;
            // 
            // btnDietitianLogin
            // 
            btnDietitianLogin.Location = new Point(403, 149);
            btnDietitianLogin.Name = "btnDietitianLogin";
            btnDietitianLogin.Size = new Size(167, 84);
            btnDietitianLogin.TabIndex = 1;
            btnDietitianLogin.Text = "Diyetisyen Girişi";
            btnDietitianLogin.UseVisualStyleBackColor = true;
            btnDietitianLogin.Click += btnDietitianLogin_Click;
            // 
            // YoneticiFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDietitianLogin);
            Controls.Add(btnDieterLogin);
            Name = "YoneticiFormu";
            Text = "YoneticiFormu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDieterLogin;
        private Button btnDietitianLogin;
    }
}