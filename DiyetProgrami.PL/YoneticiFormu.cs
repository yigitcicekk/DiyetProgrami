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
    public partial class YoneticiFormu : Form
    {
        public YoneticiFormu()
        {
            InitializeComponent();
        }

        private void btnDieterLogin_Click(object sender, EventArgs e)
        {
            DieterHomePage dieterHomePage = new DieterHomePage();
            dieterHomePage.Show();
        }

        private void btnDietitianLogin_Click(object sender, EventArgs e)
        {
            DietitianHomePage dietitianHomePage = new DietitianHomePage();
            dietitianHomePage.Show();
        }
    }
}
