using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTriangulo
{
    public partial class AreaTriangulo : Form
    {
        public AreaTriangulo()
        {
            InitializeComponent();
        }

        private void AreaTriangulo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonClean(object sender, EventArgs e)
        {
            this.TxtBase.Text = String.Empty;
            this.TxtAltura.Text = String.Empty;
            this.TxtArea.Text = String.Empty;
            this.TxtBase.Focus();
        }

        private void buttonClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCalcular(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TxtBase.Text))
            {
                MessageBox.Show("Digite La base", "Notificación");
                this.TxtBase.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(this.TxtAltura.Text))
                {
                    MessageBox.Show("Digite La altura", "Notificación");
                    this.TxtAltura.Focus();
                }
                else
                {
                    this.TxtArea.Text = ((Convert.ToDecimal(this.TxtBase.Text) * Convert.ToDecimal(this.TxtAltura.Text)) / 2).ToString();
                }
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TxtBase_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
