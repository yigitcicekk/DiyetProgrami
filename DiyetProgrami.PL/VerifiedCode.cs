using DiyetProgrami.BL.Models;
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
    public partial class VerifiedCode : Form
    {
        UserViewModel userViewModel = new UserViewModel();
        public VerifiedCode()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            if(userViewModel.VerificationCode == txtOnayKodu.Text)
            {
                userViewModel.IsVerified = true;
                MessageBox.Show("Üyelik aktif duruma gelmiştir.Kayıt başarılı.");
            }
            else
            {
                MessageBox.Show("Girdiğiniz kod uyuşmamaktadır.Lütfen tekrar deneyin.");
            }
        }
    }
}
