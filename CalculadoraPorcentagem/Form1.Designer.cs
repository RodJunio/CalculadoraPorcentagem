﻿namespace CalculadoraPorcentagem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txbPorcento = new System.Windows.Forms.TextBox();
            this.lbQuanto = new System.Windows.Forms.Label();
            this.lbDe = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtOValor = new System.Windows.Forms.Label();
            this.txtQual = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtNumero3 = new System.Windows.Forms.TextBox();
            this.txtResultadoPorcento = new System.Windows.Forms.TextBox();
            this.btnCalcular2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(80, 115);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // txbPorcento
            // 
            this.txbPorcento.Location = new System.Drawing.Point(142, 86);
            this.txbPorcento.Name = "txbPorcento";
            this.txbPorcento.Size = new System.Drawing.Size(100, 23);
            this.txbPorcento.TabIndex = 1;
            // 
            // lbQuanto
            // 
            this.lbQuanto.AutoSize = true;
            this.lbQuanto.Location = new System.Drawing.Point(80, 94);
            this.lbQuanto.Name = "lbQuanto";
            this.lbQuanto.Size = new System.Drawing.Size(56, 15);
            this.lbQuanto.TabIndex = 2;
            this.lbQuanto.Text = "Quanto é";
            this.lbQuanto.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbDe
            // 
            this.lbDe.AutoSize = true;
            this.lbDe.Location = new System.Drawing.Point(248, 91);
            this.lbDe.Name = "lbDe";
            this.lbDe.Size = new System.Drawing.Size(20, 15);
            this.lbDe.TabIndex = 3;
            this.lbDe.Text = "de";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(274, 86);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 23);
            this.txbNumero.TabIndex = 4;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(168, 116);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 23);
            this.txtResultado.TabIndex = 5;
            // 
            // txtOValor
            // 
            this.txtOValor.AutoSize = true;
            this.txtOValor.Location = new System.Drawing.Point(70, 209);
            this.txtOValor.Name = "txtOValor";
            this.txtOValor.Size = new System.Drawing.Size(45, 15);
            this.txtOValor.TabIndex = 6;
            this.txtOValor.Text = "O valor";
            // 
            // txtQual
            // 
            this.txtQual.AutoSize = true;
            this.txtQual.Location = new System.Drawing.Point(227, 209);
            this.txtQual.Name = "txtQual";
            this.txtQual.Size = new System.Drawing.Size(129, 15);
            this.txtQual.TabIndex = 7;
            this.txtQual.Text = "é qual porcentagem de";
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(121, 206);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 23);
            this.txtNumero2.TabIndex = 8;
            // 
            // txtNumero3
            // 
            this.txtNumero3.Location = new System.Drawing.Point(362, 206);
            this.txtNumero3.Name = "txtNumero3";
            this.txtNumero3.Size = new System.Drawing.Size(100, 23);
            this.txtNumero3.TabIndex = 9;
            // 
            // txtResultadoPorcento
            // 
            this.txtResultadoPorcento.Location = new System.Drawing.Point(168, 235);
            this.txtResultadoPorcento.Name = "txtResultadoPorcento";
            this.txtResultadoPorcento.Size = new System.Drawing.Size(100, 23);
            this.txtResultadoPorcento.TabIndex = 10;
            // 
            // btnCalcular2
            // 
            this.btnCalcular2.Location = new System.Drawing.Point(80, 235);
            this.btnCalcular2.Name = "btnCalcular2";
            this.btnCalcular2.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular2.TabIndex = 11;
            this.btnCalcular2.Text = "Calcular";
            this.btnCalcular2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular2);
            this.Controls.Add(this.txtResultadoPorcento);
            this.Controls.Add(this.txtNumero3);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtQual);
            this.Controls.Add(this.txtOValor);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.lbDe);
            this.Controls.Add(this.lbQuanto);
            this.Controls.Add(this.txbPorcento);
            this.Controls.Add(this.btnCalcular);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalcular;
        private TextBox txbPorcento;
        private Label lbQuanto;
        private Label lbDe;
        private TextBox txbNumero;
        private TextBox txtResultado;
        private Label txtOValor;
        private Label txtQual;
        private TextBox txtNumero2;
        private TextBox txtNumero3;
        private TextBox txtResultadoPorcento;
        private Button btnCalcular2;
        private Label label1;
        private Label label2;
    }
}