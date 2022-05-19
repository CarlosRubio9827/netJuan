namespace Ejercicio3
{
    partial class Ejercicio3
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResultado1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtvalor3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtvalor2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvalor1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtvalor4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtresultado2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.Location = new System.Drawing.Point(269, 258);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrar.TabIndex = 23;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(168, 258);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 22;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.Location = new System.Drawing.Point(73, 258);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 21;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Operacion Matematica";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtResultado1
            // 
            this.txtResultado1.Location = new System.Drawing.Point(76, 196);
            this.txtResultado1.Name = "txtResultado1";
            this.txtResultado1.ReadOnly = true;
            this.txtResultado1.Size = new System.Drawing.Size(100, 20);
            this.txtResultado1.TabIndex = 19;
            this.txtResultado1.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Resultados";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtvalor3
            // 
            this.txtvalor3.Location = new System.Drawing.Point(91, 116);
            this.txtvalor3.Name = "txtvalor3";
            this.txtvalor3.Size = new System.Drawing.Size(100, 20);
            this.txtvalor3.TabIndex = 17;
            this.txtvalor3.TextChanged += new System.EventHandler(this.txtvalor3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Valor 3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtvalor2
            // 
            this.txtvalor2.Location = new System.Drawing.Point(223, 76);
            this.txtvalor2.Name = "txtvalor2";
            this.txtvalor2.Size = new System.Drawing.Size(100, 20);
            this.txtvalor2.TabIndex = 15;
            this.txtvalor2.TextChanged += new System.EventHandler(this.txtvalor2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Valor 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtvalor1
            // 
            this.txtvalor1.Location = new System.Drawing.Point(91, 76);
            this.txtvalor1.Name = "txtvalor1";
            this.txtvalor1.Size = new System.Drawing.Size(100, 20);
            this.txtvalor1.TabIndex = 13;
            this.txtvalor1.TextChanged += new System.EventHandler(this.txtvalor1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Valor 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtvalor4
            // 
            this.txtvalor4.Location = new System.Drawing.Point(223, 116);
            this.txtvalor4.Name = "txtvalor4";
            this.txtvalor4.Size = new System.Drawing.Size(100, 20);
            this.txtvalor4.TabIndex = 25;
            this.txtvalor4.TextChanged += new System.EventHandler(this.txtvalor4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(220, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Valor 4";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Suma de los 4 valores ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(220, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Suma menos ultimo valor";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtresultado2
            // 
            this.txtresultado2.Location = new System.Drawing.Point(219, 196);
            this.txtresultado2.Name = "txtresultado2";
            this.txtresultado2.ReadOnly = true;
            this.txtresultado2.Size = new System.Drawing.Size(100, 20);
            this.txtresultado2.TabIndex = 27;
            this.txtresultado2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(424, 320);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtresultado2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtvalor4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResultado1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtvalor3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtvalor2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtvalor1);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResultado1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtvalor3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtvalor2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvalor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtvalor4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtresultado2;
    }
}

