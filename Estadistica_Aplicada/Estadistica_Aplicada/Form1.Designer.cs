namespace Estadistica_Aplicada
{
    partial class Form1
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
            this.txt_DatosIngresados = new System.Windows.Forms.TextBox();
            this.btn_AgregarDato = new System.Windows.Forms.Button();
            this.lbx_DatosAgregados = new System.Windows.Forms.ListBox();
            this.btn_Ordenar = new System.Windows.Forms.Button();
            this.btn_CantidaDatos = new System.Windows.Forms.Button();
            this.lbl_CantidadDatos = new System.Windows.Forms.Label();
            this.btn_Operar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Paso1 = new System.Windows.Forms.Label();
            this.lbl_AmplitudIntervalo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Inferior = new System.Windows.Forms.Label();
            this.lbl_Superior = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RangoMinimo = new System.Windows.Forms.ListBox();
            this.RangoMaximo = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PointMedio = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Frecuencia = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FrecuenciaR = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FrecuenciaPorcentual = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.FrecuenciaAcomulada = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.FrecuRelaAcomu = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.FrecPorcentuAcomulada = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_DatosIngresados
            // 
            this.txt_DatosIngresados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DatosIngresados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_DatosIngresados.Location = new System.Drawing.Point(40, 40);
            this.txt_DatosIngresados.Name = "txt_DatosIngresados";
            this.txt_DatosIngresados.Size = new System.Drawing.Size(142, 24);
            this.txt_DatosIngresados.TabIndex = 0;
            // 
            // btn_AgregarDato
            // 
            this.btn_AgregarDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarDato.Location = new System.Drawing.Point(203, 12);
            this.btn_AgregarDato.Name = "btn_AgregarDato";
            this.btn_AgregarDato.Size = new System.Drawing.Size(137, 24);
            this.btn_AgregarDato.TabIndex = 1;
            this.btn_AgregarDato.Text = "Agregar Dato";
            this.btn_AgregarDato.UseVisualStyleBackColor = true;
            this.btn_AgregarDato.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbx_DatosAgregados
            // 
            this.lbx_DatosAgregados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_DatosAgregados.FormattingEnabled = true;
            this.lbx_DatosAgregados.Location = new System.Drawing.Point(40, 76);
            this.lbx_DatosAgregados.Name = "lbx_DatosAgregados";
            this.lbx_DatosAgregados.Size = new System.Drawing.Size(142, 121);
            this.lbx_DatosAgregados.TabIndex = 2;
            // 
            // btn_Ordenar
            // 
            this.btn_Ordenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ordenar.Location = new System.Drawing.Point(203, 51);
            this.btn_Ordenar.Name = "btn_Ordenar";
            this.btn_Ordenar.Size = new System.Drawing.Size(137, 24);
            this.btn_Ordenar.TabIndex = 3;
            this.btn_Ordenar.Text = "Ordenar";
            this.btn_Ordenar.UseVisualStyleBackColor = true;
            this.btn_Ordenar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_CantidaDatos
            // 
            this.btn_CantidaDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CantidaDatos.Location = new System.Drawing.Point(203, 95);
            this.btn_CantidaDatos.Name = "btn_CantidaDatos";
            this.btn_CantidaDatos.Size = new System.Drawing.Size(137, 45);
            this.btn_CantidaDatos.TabIndex = 4;
            this.btn_CantidaDatos.Text = "Cantidad de datos";
            this.btn_CantidaDatos.UseVisualStyleBackColor = true;
            this.btn_CantidaDatos.Click += new System.EventHandler(this.Button3_Click);
            // 
            // lbl_CantidadDatos
            // 
            this.lbl_CantidadDatos.AutoSize = true;
            this.lbl_CantidadDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CantidadDatos.Location = new System.Drawing.Point(248, 154);
            this.lbl_CantidadDatos.Name = "lbl_CantidadDatos";
            this.lbl_CantidadDatos.Size = new System.Drawing.Size(49, 16);
            this.lbl_CantidadDatos.TabIndex = 5;
            this.lbl_CantidadDatos.Text = "Datos";
            // 
            // btn_Operar
            // 
            this.btn_Operar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Operar.Location = new System.Drawing.Point(406, 7);
            this.btn_Operar.Name = "btn_Operar";
            this.btn_Operar.Size = new System.Drawing.Size(134, 34);
            this.btn_Operar.TabIndex = 6;
            this.btn_Operar.Text = "Operar";
            this.btn_Operar.UseVisualStyleBackColor = true;
            this.btn_Operar.Click += new System.EventHandler(this.btn_Operar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total de Invertalos:";
            // 
            // lbl_Paso1
            // 
            this.lbl_Paso1.AutoSize = true;
            this.lbl_Paso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Paso1.Location = new System.Drawing.Point(551, 72);
            this.lbl_Paso1.Name = "lbl_Paso1";
            this.lbl_Paso1.Size = new System.Drawing.Size(19, 16);
            this.lbl_Paso1.TabIndex = 8;
            this.lbl_Paso1.Text = "N";
            // 
            // lbl_AmplitudIntervalo
            // 
            this.lbl_AmplitudIntervalo.AutoSize = true;
            this.lbl_AmplitudIntervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AmplitudIntervalo.Location = new System.Drawing.Point(563, 108);
            this.lbl_AmplitudIntervalo.Name = "lbl_AmplitudIntervalo";
            this.lbl_AmplitudIntervalo.Size = new System.Drawing.Size(19, 16);
            this.lbl_AmplitudIntervalo.TabIndex = 9;
            this.lbl_AmplitudIntervalo.Text = "N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Amplitud de Intervalo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Limite Inferior:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Limite Superior:";
            // 
            // lbl_Inferior
            // 
            this.lbl_Inferior.AutoSize = true;
            this.lbl_Inferior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inferior.Location = new System.Drawing.Point(514, 143);
            this.lbl_Inferior.Name = "lbl_Inferior";
            this.lbl_Inferior.Size = new System.Drawing.Size(19, 16);
            this.lbl_Inferior.TabIndex = 13;
            this.lbl_Inferior.Text = "N";
            // 
            // lbl_Superior
            // 
            this.lbl_Superior.AutoSize = true;
            this.lbl_Superior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Superior.Location = new System.Drawing.Point(526, 177);
            this.lbl_Superior.Name = "lbl_Superior";
            this.lbl_Superior.Size = new System.Drawing.Size(19, 16);
            this.lbl_Superior.TabIndex = 14;
            this.lbl_Superior.Text = "N";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Rango Minimo";
            // 
            // RangoMinimo
            // 
            this.RangoMinimo.FormattingEnabled = true;
            this.RangoMinimo.Location = new System.Drawing.Point(70, 247);
            this.RangoMinimo.Name = "RangoMinimo";
            this.RangoMinimo.Size = new System.Drawing.Size(75, 225);
            this.RangoMinimo.TabIndex = 17;
            // 
            // RangoMaximo
            // 
            this.RangoMaximo.FormattingEnabled = true;
            this.RangoMaximo.Location = new System.Drawing.Point(151, 247);
            this.RangoMaximo.Name = "RangoMaximo";
            this.RangoMaximo.Size = new System.Drawing.Size(75, 225);
            this.RangoMaximo.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Rango Maximo";
            // 
            // PointMedio
            // 
            this.PointMedio.FormattingEnabled = true;
            this.PointMedio.Location = new System.Drawing.Point(232, 247);
            this.PointMedio.Name = "PointMedio";
            this.PointMedio.Size = new System.Drawing.Size(75, 225);
            this.PointMedio.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Punto Medio";
            // 
            // Frecuencia
            // 
            this.Frecuencia.FormattingEnabled = true;
            this.Frecuencia.Location = new System.Drawing.Point(313, 247);
            this.Frecuencia.Name = "Frecuencia";
            this.Frecuencia.Size = new System.Drawing.Size(75, 225);
            this.Frecuencia.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "F";
            // 
            // FrecuenciaR
            // 
            this.FrecuenciaR.FormattingEnabled = true;
            this.FrecuenciaR.Location = new System.Drawing.Point(394, 247);
            this.FrecuenciaR.Name = "FrecuenciaR";
            this.FrecuenciaR.Size = new System.Drawing.Size(75, 225);
            this.FrecuenciaR.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(405, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "FR (F/N)";
            // 
            // FrecuenciaPorcentual
            // 
            this.FrecuenciaPorcentual.FormattingEnabled = true;
            this.FrecuenciaPorcentual.Location = new System.Drawing.Point(475, 247);
            this.FrecuenciaPorcentual.Name = "FrecuenciaPorcentual";
            this.FrecuenciaPorcentual.Size = new System.Drawing.Size(75, 225);
            this.FrecuenciaPorcentual.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(477, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "F% (FR * 100)";
            // 
            // FrecuenciaAcomulada
            // 
            this.FrecuenciaAcomulada.FormattingEnabled = true;
            this.FrecuenciaAcomulada.Location = new System.Drawing.Point(556, 247);
            this.FrecuenciaAcomulada.Name = "FrecuenciaAcomulada";
            this.FrecuenciaAcomulada.Size = new System.Drawing.Size(75, 225);
            this.FrecuenciaAcomulada.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(587, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "FA";
            // 
            // FrecuRelaAcomu
            // 
            this.FrecuRelaAcomu.FormattingEnabled = true;
            this.FrecuRelaAcomu.Location = new System.Drawing.Point(637, 247);
            this.FrecuRelaAcomu.Name = "FrecuRelaAcomu";
            this.FrecuRelaAcomu.Size = new System.Drawing.Size(75, 225);
            this.FrecuRelaAcomu.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(662, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "FRA";
            // 
            // FrecPorcentuAcomulada
            // 
            this.FrecPorcentuAcomulada.FormattingEnabled = true;
            this.FrecPorcentuAcomulada.Location = new System.Drawing.Point(718, 247);
            this.FrecPorcentuAcomulada.Name = "FrecPorcentuAcomulada";
            this.FrecPorcentuAcomulada.Size = new System.Drawing.Size(75, 225);
            this.FrecPorcentuAcomulada.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(738, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "F%A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 556);
            this.Controls.Add(this.FrecPorcentuAcomulada);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.FrecuRelaAcomu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.FrecuenciaAcomulada);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.FrecuenciaPorcentual);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FrecuenciaR);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Frecuencia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PointMedio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RangoMaximo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RangoMinimo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Superior);
            this.Controls.Add(this.lbl_Inferior);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_AmplitudIntervalo);
            this.Controls.Add(this.lbl_Paso1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Operar);
            this.Controls.Add(this.lbl_CantidadDatos);
            this.Controls.Add(this.btn_CantidaDatos);
            this.Controls.Add(this.btn_Ordenar);
            this.Controls.Add(this.lbx_DatosAgregados);
            this.Controls.Add(this.btn_AgregarDato);
            this.Controls.Add(this.txt_DatosIngresados);
            this.Name = "Form1";
            this.Text = "Estadistica Aplicada";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_DatosIngresados;
        private System.Windows.Forms.Button btn_AgregarDato;
        private System.Windows.Forms.ListBox lbx_DatosAgregados;
        private System.Windows.Forms.Button btn_Ordenar;
        private System.Windows.Forms.Button btn_CantidaDatos;
        private System.Windows.Forms.Label lbl_CantidadDatos;
        private System.Windows.Forms.Button btn_Operar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Paso1;
        private System.Windows.Forms.Label lbl_AmplitudIntervalo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Inferior;
        private System.Windows.Forms.Label lbl_Superior;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntoMedio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox RangoMinimo;
        private System.Windows.Forms.ListBox RangoMaximo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox PointMedio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox Frecuencia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox FrecuenciaR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox FrecuenciaPorcentual;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox FrecuenciaAcomulada;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox FrecuRelaAcomu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox FrecPorcentuAcomulada;
        private System.Windows.Forms.Label label13;
    }
}

