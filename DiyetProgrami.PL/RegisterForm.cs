using DiyetProgrami.BL.CCS;
using DiyetProgrami.BL.Manager.Concrete;
using DiyetProgrami.BL.Models;
using DiyetProgrami.DAL.Context;
using DiyetProgrami.DAL.Repository.Concrete;
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
        private readonly DietitianRepository _dietitianRepository;

        public RegisterForm()
        {
            InitializeComponent();
            _dbContext = new DiyetProgramiDbContext();
            _mailSender = new MailSender();
            _userManager = new UserManager(_dbContext, _mailSender);
            _dietitianRepository = new DietitianRepository(_dbContext);
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

                bool SembolIceriyorMu(string metin) // Sembol içerip içermediğinin kontrolü yapıldı.
                {
                    int sayac = 0;
                    foreach (char karakter in metin)
                    {
                        if (!char.IsLetterOrDigit(karakter) && !char.IsWhiteSpace(karakter))
                        {
                            sayac++;
                        }
                        if (sayac > 1)
                        {
                            return true;
                        }
                    }
                    return false;
                }

                bool BuyukHarfIceriyorMu(string metin) // Büyük harf kontrolü yapıldı.
                {
                    int sayac = 0;
                    foreach (char karakter in metin)
                    {
                        if (char.IsUpper(karakter))
                        {
                            sayac++;
                        }
                        if (sayac > 1)
                        {
                            return true;
                        }
                    }
                    return false;
                }
                bool MetinRakamIceriyorMu(string metin) // Rakam Kontrolü Yapıldı.
                {
                    foreach (char karakter in metin)
                    {
                        if (char.IsDigit(karakter))
                        {
                            return true;
                        }
                    }
                    return false;
                }
                string password = txtPassword.Text;
                string comPassword = txtComPassword.Text;

                if (password.Length < 8) // Şifre uzunluğu 8 karakterden küçük olamaz kontrolü yapıldı.
                {
                    MessageBox.Show("Şifre 8 karakterden uzun olmak zorundadır. Lütfen daha uzun şifre giriniz!");
                }
                else if (!BuyukHarfIceriyorMu(password) || !MetinRakamIceriyorMu(password) || !SembolIceriyorMu(password))
                {
                    MessageBox.Show("Şifre içerisinde en az 2 büyük harf, rakam ve en az 1 sembol bulunmak zorundadır. Lütfen başka bir şifre deneyiniz!");
                }
                else if (password != comPassword) // Şifre ile şifre tekrarı aynı mı kontrolü yapıldı.
                {
                    MessageBox.Show("Şifre tekrarında girdiğiniz şifrenin aynısını girmelisiniz! Lütfen şifrenizi kontrol edin!");
                }
                else if (_dbContext.Users.FirstOrDefault(k => k.Email == txtEmail.Text) != null) // Kullanıcı adı daha önceden başkası tarafından kullanılıyor mu kontrolü yapıldı.
                {
                    MessageBox.Show("Bu kullanıcı adı sistemde kayıtlı. Lütfen başka bir kullanıcı adı(eposta) kullanarak tekrar deneyiniz!");
                }
                
                var userViewModel = new UserViewModel()
                {
                    FirstName = txtName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,

                };

                object additionalInfo = null;

                if (radioBtnDieter.Checked)
                {
                    using (var dieterInfoForm = new DieterInfoForm(_dbContext,_dietitianRepository))
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

            //VerifiedCode verifiedCode = new VerifiedCode();
            //verifiedCode.ShowDialog();
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
