using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            {
                {
                    if (string.IsNullOrEmpty(this.txtvalor1.Text))
                    {
                        MessageBox.Show("Digite el valor 1", "Notificación");
                        this.txtvalor1.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(this.txtvalor2.Text))
                        {
                            MessageBox.Show("Digite el valor 2", "Notificación");
                            this.txtvalor2.Focus();
                        }
                        else
                        {
                            {
                                if (string.IsNullOrEmpty(this.txtvalor3.Text))
                                {
                                    MessageBox.Show("Digite el valor 3", "Notificación");
                                    this.txtvalor3.Focus();
                                }
                                else
                                {
                                    {
                                        if (string.IsNullOrEmpty(this.txtvalor4.Text))
                                        {
                                            MessageBox.Show("Digite el valor 4", "Notificación");
                                            this.txtvalor4.Focus();
                                        }
                                        else
                                        {
                                            this.txtResultado1.Text = (Convert.ToDecimal(this.txtvalor1.Text) + Convert.ToDecimal(this.txtvalor2.Text) + Convert.ToDecimal(this.txtvalor3.Text) + Convert.ToDecimal(this.txtvalor4.Text)).ToString();
                                            this.txtresultado2.Text = (Convert.ToDecimal(this.txtResultado1.Text) - Convert.ToDecimal(this.txtvalor4.Text)).ToString();
                                            MessageBox.Show("Los valores agregados son: " + ((this.txtvalor1.Text) , (this.txtvalor2.Text) , (this.txtvalor3.Text) , (this.txtvalor4.Text)));
                                            MessageBox.Show("Los resultados son: " + (this.txtResultado1.Text , txtresultado2.Text));
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
        }

        private void txtvalor3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.txtvalor1.Text = String.Empty;
            this.txtvalor2.Text = String.Empty;
            this.txtvalor3.Text = String.Empty;
            this.txtvalor4.Text = String.Empty;
            this.txtResultado1.Text = String.Empty;
            this.txtvalor1.Focus();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtvalor4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtvalor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtvalor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
