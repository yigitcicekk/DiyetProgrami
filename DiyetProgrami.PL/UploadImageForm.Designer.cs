using DiyetProgrami.BL.Manager.Concrete;
using DiyetProgrami.DAL.Context;
using DiyetProgrami.DAL.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiyetProgrami.PL
{
    public partial class UploadImageForm : Form
    {
        private UserManager _userManager;
        private Guid _userId; // User ID should be set appropriately

        public UploadImageForm(UserManager userManager, Guid userId)
        {
            InitializeComponent();
            _userManager = userManager;
            _userId = userId; // This should be set to the actual user ID
        }

        private void InitializeComponent()
        {
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(150, 50);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(175, 220);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(100, 30);
            this.buttonUpload.TabIndex = 1;
            this.buttonUpload.Text = "Upload Image";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.ButtonUpload_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 485);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.pictureBoxProfile);
            this.Name = "Upload Image";
            this.Text = "Upload Image";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
        }

        private async void ButtonUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;
                pictureBoxProfile.Image = Image.FromFile(filePath);

                // Convert image to byte array
                byte[] imageBytes;
                using (var ms = new System.IO.MemoryStream())
                {
                    pictureBoxProfile.Image.Save(ms, pictureBoxProfile.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }

                // Save the image to UserModel
                var result = await _userManager.UpdateUserProfileImage(_userId, imageBytes);
                if (result)
                {
                    MessageBox.Show("Profile image updated successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to update profile image.");
                }
            }
        }

        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
