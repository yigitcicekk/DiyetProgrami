using DiyetProgrami.BL.CCS;
using DiyetProgrami.BL.Manager.Concrete;
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
    public partial class LoginForm : Form
    {
        private readonly UserManager _userManager;
        public LoginForm()
        {
            InitializeComponent();
            var dbContext = new DiyetProgramiDbContext();
            var mailSender = new MailSender();
            _userManager = new UserManager(dbContext, mailSender);
        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPassword.UseSystemPasswordChar = !this.checkbxShowPass.Checked;
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void ClearFormField()
        {
            this.txtEmail.Text = "";
            this.txtPassword.Text = "";
            this.checkbxShowPass.Checked = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;
            string password = this.txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter your email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var user = _userManager.Login(email, password);

                YoneticiFormu yoneticiForm = new YoneticiFormu();
                yoneticiForm.ShowDialog();
               
                //if (user != null)
                //{
                //    var userRole = _userManager.GetUserRole(user);

                //    if (userRole == "admin")
                //    {
                //        AdminHomePage adminHomePage = new AdminHomePage();
                //        adminHomePage.Show();
                //    }
                //    else if (userRole == "dieter")
                //    {
                //        DieterHomePage dieterHomePage = new DieterHomePage();
                //        dieterHomePage.Show();
                //    }
                //    else if (userRole == "dietitian")
                //    {
                //        DietitianHomePage dietitianHomePage = new DietitianHomePage();
                //        dietitianHomePage.Show();
                //    }
                //    else
                //    {
                //        MessageBox.Show("User role not recognized.");
                //    }
                //    this.Hide();
                //}
                //else
                //{
                //    MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    ClearFormField();
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " InnerException : " + ex.InnerException?.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
