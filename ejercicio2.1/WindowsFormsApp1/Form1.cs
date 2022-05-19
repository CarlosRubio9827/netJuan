﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
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
                                this.txtResultado.Text = (Convert.ToDecimal(this.txtvalor1.Text) + (Convert.ToDecimal(this.txtvalor2.Text) + Convert.ToDecimal(this.txtvalor3.Text))).ToString();
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
            this.txtResultado.Text = String.Empty;
            this.txtvalor1.Focus();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtvalor3_TextChanged(object sender, EventArgs e)
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
