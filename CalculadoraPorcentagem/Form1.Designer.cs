namespace CalculadoraPorcentagem
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
            this.txtResultadoPorcento = new System.Windows.Forms.TextBox();
            this.btnCalcular2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txbPorcento
            // 
            this.txbPorcento.Location = new System.Drawing.Point(142, 86);
            this.txbPorcento.Name = "txbPorcento";
            this.txbPorcento.Size = new System.Drawing.Size(100, 23);
            this.txbPorcento.TabIndex = 1;
            this.txbPorcento.TextChanged += new System.EventHandler(this.txbPorcento_TextChanged);
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
            this.lbDe.Location = new System.Drawing.Point(271, 89);
            this.lbDe.Name = "lbDe";
            this.lbDe.Size = new System.Drawing.Size(20, 15);
            this.lbDe.TabIndex = 3;
            this.lbDe.Text = "de";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(297, 86);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 23);
            this.txbNumero.TabIndex = 4;
            this.txbNumero.TextChanged += new System.EventHandler(this.txbNumero_TextChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(161, 115);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 23);
            this.txtResultado.TabIndex = 5;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // txtOValor
            // 
            this.txtOValor.AutoSize = true;
            this.txtOValor.Location = new System.Drawing.Point(80, 209);
            this.txtOValor.Name = "txtOValor";
            this.txtOValor.Size = new System.Drawing.Size(45, 15);
            this.txtOValor.TabIndex = 6;
            this.txtOValor.Text = "O valor";
            // 
            // txtQual
            // 
            this.txtQual.AutoSize = true;
            this.txtQual.Location = new System.Drawing.Point(237, 209);
            this.txtQual.Name = "txtQual";
            this.txtQual.Size = new System.Drawing.Size(129, 15);
            this.txtQual.TabIndex = 7;
            this.txtQual.Text = "é qual porcentagem de";
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(131, 206);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 23);
            this.txtNumero2.TabIndex = 8;
            this.txtNumero2.TextChanged += new System.EventHandler(this.txtNumero2_TextChanged);
            // 
            // txtResultadoPorcento
            // 
            this.txtResultadoPorcento.Location = new System.Drawing.Point(161, 238);
            this.txtResultadoPorcento.Name = "txtResultadoPorcento";
            this.txtResultadoPorcento.Size = new System.Drawing.Size(100, 23);
            this.txtResultadoPorcento.TabIndex = 10;
            this.txtResultadoPorcento.TextChanged += new System.EventHandler(this.txtResultadoPorcento_TextChanged);
            // 
            // btnCalcular2
            // 
            this.btnCalcular2.Location = new System.Drawing.Point(83, 237);
            this.btnCalcular2.Name = "btnCalcular2";
            this.btnCalcular2.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular2.TabIndex = 11;
            this.btnCalcular2.Text = "Calcular";
            this.btnCalcular2.UseVisualStyleBackColor = true;
            this.btnCalcular2.Click += new System.EventHandler(this.btnCalcular2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "%";
            // 
            // txtNumero3
            // 
            this.txtNumero3.Location = new System.Drawing.Point(372, 206);
            this.txtNumero3.Name = "txtNumero3";
            this.txtNumero3.Size = new System.Drawing.Size(100, 23);
            this.txtNumero3.TabIndex = 9;
            this.txtNumero3.TextChanged += new System.EventHandler(this.txtNumero3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Calculadora de Porcentagem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private TextBox txtResultadoPorcento;
        private Button btnCalcular2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumero3;
        private Label label4;
        private Label label5;
    }
}