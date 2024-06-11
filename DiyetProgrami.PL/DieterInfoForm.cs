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
    public partial class DieterInfoForm : Form
    {
        public int Age { get; private set; }
        public string Gender { get; private set; }
        public float Height { get; private set; }
        public float Weight { get; private set; }

        public DieterInfoForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            Age = int.Parse(txtAge.Text);
            Gender = radioBtnMale.Checked ? "Male" : "Female";
            Height = float.Parse(txtHeight.Text);
            Weight = float.Parse(txtWeight.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Please enter age.");
                return false;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Please enter a valid age.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                MessageBox.Show("Please enter height.");
                return false;
            }

            if (!float.TryParse(txtHeight.Text, out float height) || height <= 0)
            {
                MessageBox.Show("Please enter a valid height.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtWeight.Text))
            {
                MessageBox.Show("Please enter weight.");
                return false;
            }

            if (!float.TryParse(txtWeight.Text, out float weight) || weight <= 0)
            {
                MessageBox.Show("Please enter a valid weight.");
                return false;
            }

            if (!radioBtnMale.Checked && !radioBtnFemale.Checked)
            {
                MessageBox.Show("Please select gender.");
                return false;
            }

            return true;
        }
    }
}
