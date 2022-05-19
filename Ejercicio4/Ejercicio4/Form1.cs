using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
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
                                            {
                                                if (string.IsNullOrEmpty(this.txtvalor5.Text))
                                                {
                                                    MessageBox.Show("Digite el valor 5", "Notificación");
                                                    this.txtvalor5.Focus();
                                                }
                                                else
                                                {
                                                    this.txtresultado1.Text = (Convert.ToDecimal(this.txtvalor1.Text) + Convert.ToDecimal(this.txtvalor2.Text) + Convert.ToDecimal(this.txtvalor3.Text) + Convert.ToDecimal(this.txtvalor4.Text) + Convert.ToDecimal(this.txtvalor5.Text)).ToString();
                                                    this.txtresultado2.Text = (Convert.ToDecimal(this.txtvalor1.Text) - Convert.ToDecimal(this.txtvalor2.Text) - Convert.ToDecimal(this.txtvalor3.Text)).ToString();
                                                    this.txtresultado3.Text = (Convert.ToDecimal(this.txtvalor4.Text) - Convert.ToDecimal(this.txtvalor5.Text)).ToString();
                                                    this.txtresultado4.Text = (Convert.ToDecimal(this.txtresultado2.Text) * Convert.ToDecimal(this.txtresultado3.Text)).ToString();
                                                    this.txtresultado5.Text = (Convert.ToDecimal(this.txtresultado1.Text) / Convert.ToDecimal(this.txtresultado4.Text)).ToString();
                                                    MessageBox.Show("Los valores agregados son: " + ((this.txtvalor1.Text), (this.txtvalor2.Text), (this.txtvalor3.Text), (this.txtvalor4.Text) , (this.txtvalor5.Text)));
                                                    MessageBox.Show("Los resultados son: " + (this.txtresultado1.Text, txtresultado2.Text, txtresultado3.Text, txtresultado4.Text, txtresultado5.Text));
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.txtvalor1.Text = String.Empty;
            this.txtvalor2.Text = String.Empty;
            this.txtvalor3.Text = String.Empty;
            this.txtvalor4.Text = String.Empty;
            this.txtvalor5.Text = String.Empty;
            this.txtresultado1.Text = String.Empty;
            this.txtresultado2.Text = String.Empty;
            this.txtresultado3.Text = String.Empty;
            this.txtresultado4.Text = String.Empty;
            this.txtresultado5.Text = String.Empty;
            this.txtvalor1.Focus();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
