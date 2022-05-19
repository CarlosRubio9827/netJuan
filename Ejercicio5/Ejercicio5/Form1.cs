using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txttemperatura.Text))
            {
                MessageBox.Show("Digite la temperatura", "Notificación");
                this.txttemperatura.Focus();
            }
            else
            {
                this.txtresultado.Text = (((Convert.ToDecimal(this.txttemperatura.Text)) * (9) / 5) + (32)).ToString();
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.txttemperatura.Text = String.Empty;
            this.txtresultado.Text = String.Empty;
            this.txttemperatura.Focus();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
