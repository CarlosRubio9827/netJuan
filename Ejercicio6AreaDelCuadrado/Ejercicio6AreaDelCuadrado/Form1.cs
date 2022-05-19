using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6AreaDelCuadrado
{
    public partial class AreaDelTriangulo : Form
    {
        public AreaDelTriangulo()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtlado1.Text))
            {
                MessageBox.Show("Digite la Base", "Notificación");
                this.txtlado1.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(this.txtlado2.Text))
                {
                    MessageBox.Show("Digite la altura", "Notificación");
                    this.txtlado2.Focus();
                }
                else
                {
                    this.txtarea.Text = ((Convert.ToDecimal(this.txtlado1.Text) * Convert.ToDecimal(this.txtlado2.Text))).ToString();
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtlado1.Text = String.Empty;
            this.txtlado2.Text = String.Empty;
            this.txtarea.Text = String.Empty;
            this.txtlado1.Focus();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
