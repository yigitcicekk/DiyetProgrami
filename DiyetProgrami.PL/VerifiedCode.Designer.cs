namespace DiyetProgrami.PL
{
    partial class VerifiedCode
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
            txtOnayKodu = new TextBox();
            btnKayit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 0;
            label1.Text = "Onay Kodunu Giriniz:";
            // 
            // txtOnayKodu
            // 
            txtOnayKodu.Location = new Point(165, 23);
            txtOnayKodu.Name = "txtOnayKodu";
            txtOnayKodu.Size = new Size(168, 27);
            txtOnayKodu.TabIndex = 1;
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(165, 77);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(168, 29);
            btnKayit.TabIndex = 2;
            btnKayit.Text = "Kodu Doğrula";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // VerifiedCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 137);
            Controls.Add(btnKayit);
            Controls.Add(txtOnayKodu);
            Controls.Add(label1);
            Name = "VerifiedCode";
            Text = "VerifiedCode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOnayKodu;
        private Button btnKayit;
    }
}