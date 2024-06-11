using DiyetProgrami.BL.CCS;
using DiyetProgrami.BL.Manager.Concrete;
using DiyetProgrami.BL.Models;
using DiyetProgrami.DAL.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetProgrami.PL
{
    public partial class RegisterForm : Form
    {
        private readonly UserManager _userManager;
        private readonly DiyetProgramiDbContext _dbContext;
        private readonly IMailSender _mailSender;
        public RegisterForm()
        {
            InitializeComponent();
            _dbContext = new DiyetProgramiDbContext();
            _mailSender = new MailSender();
            _userManager = new UserManager(_dbContext, _mailSender);
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateUserInputs())
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (txtPassword.Text != txtComPassword.Text)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }

                var userViewModel = new UserViewModel()
                {
                    FirstName = txtName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text
                };

                string password = txtPassword.Text;

                object additionalInfo = null;

                if (radioBtnDieter.Checked)
                {
                    using (var dieterInfoForm = new DieterInfoForm())
                    {
                        if (dieterInfoForm.ShowDialog() == DialogResult.OK)
                        {
                            var dieterViewModel = new DieterViewModel
                            {
                                Age = dieterInfoForm.Age,
                                Gender = dieterInfoForm.Gender,
                                Height = dieterInfoForm.Height,
                                Weight = dieterInfoForm.Weight
                            };
                            additionalInfo = dieterViewModel;
                        }
                    }
                }
                else if (radioBtnDietitian.Checked)
                {
                    using (var dietitianInfoForm = new DietitianInfoForm())
                    {
                        if (dietitianInfoForm.ShowDialog() == DialogResult.OK)
                        {
                            var dietitianViewModel = new DietitianViewModel
                            {
                                Specialization = dietitianInfoForm.Specialization
                            };
                            additionalInfo = dietitianViewModel;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a role.");
                    return;
                }

                var registeredUser = await _userManager.Register(userViewModel, password, additionalInfo);
                // Mail kodu gelicek ve onun kontrolü yapılcak.

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            //this.txtPassword.PasswordChar = this.checkbxShowPass.Checked ? '\0' : '*';
            //this.txtComPassword.PasswordChar = this.checkbxShowPass.Checked ? '\0' : '*';
            this.txtPassword.UseSystemPasswordChar = this.checkbxShowPass.Checked!;
            this.txtComPassword.UseSystemPasswordChar = this.checkbxShowPass.Checked!;

        }


        private void lblBackToLogin_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private bool ValidateUserInputs()
        {
            // Kullanıcı girişlerini kontrol et
            return !string.IsNullOrWhiteSpace(txtName.Text) &&
                   !string.IsNullOrWhiteSpace(txtLastName.Text) &&
                   !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                   !string.IsNullOrWhiteSpace(txtPassword.Text) &&
                   !string.IsNullOrWhiteSpace(txtComPassword.Text);
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\u2022'; 
            txtComPassword.PasswordChar = '\u2022';
        }
    }
}
