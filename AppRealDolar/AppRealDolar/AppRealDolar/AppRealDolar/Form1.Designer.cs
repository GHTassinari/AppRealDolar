namespace AppRealDolar
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCotacaoDolar = new System.Windows.Forms.TextBox();
            this.lblCotacaoDollar = new System.Windows.Forms.Label();
            this.lblValoremReal = new System.Windows.Forms.Label();
            this.txtValoremReal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblValorDollar = new System.Windows.Forms.Label();
            this.btnConvertToDollar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCotacaoDolar
            // 
            this.txtCotacaoDolar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCotacaoDolar.Location = new System.Drawing.Point(319, 103);
            this.txtCotacaoDolar.Name = "txtCotacaoDolar";
            this.txtCotacaoDolar.Size = new System.Drawing.Size(170, 20);
            this.txtCotacaoDolar.TabIndex = 0;
            this.txtCotacaoDolar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCotacaoDollar
            // 
            this.lblCotacaoDollar.AutoSize = true;
            this.lblCotacaoDollar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotacaoDollar.Location = new System.Drawing.Point(314, 53);
            this.lblCotacaoDollar.Name = "lblCotacaoDollar";
            this.lblCotacaoDollar.Size = new System.Drawing.Size(175, 30);
            this.lblCotacaoDollar.TabIndex = 1;
            this.lblCotacaoDollar.Text = "Cotação do Dólar";
            this.lblCotacaoDollar.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblValoremReal
            // 
            this.lblValoremReal.AutoSize = true;
            this.lblValoremReal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValoremReal.Location = new System.Drawing.Point(336, 147);
            this.lblValoremReal.Name = "lblValoremReal";
            this.lblValoremReal.Size = new System.Drawing.Size(139, 30);
            this.lblValoremReal.TabIndex = 2;
            this.lblValoremReal.Text = "Valor em Real";
            this.lblValoremReal.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtValoremReal
            // 
            this.txtValoremReal.Location = new System.Drawing.Point(319, 180);
            this.txtValoremReal.Name = "txtValoremReal";
            this.txtValoremReal.Size = new System.Drawing.Size(170, 20);
            this.txtValoremReal.TabIndex = 1;
            this.txtValoremReal.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 450);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(579, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 450);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblValorDollar
            // 
            this.lblValorDollar.AutoSize = true;
            this.lblValorDollar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDollar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblValorDollar.Location = new System.Drawing.Point(314, 281);
            this.lblValorDollar.Name = "lblValorDollar";
            this.lblValorDollar.Size = new System.Drawing.Size(130, 30);
            this.lblValorDollar.TabIndex = 8;
            this.lblValorDollar.Text = "Valor em U$:";
            this.lblValorDollar.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnConvertToDollar
            // 
            this.btnConvertToDollar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnConvertToDollar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertToDollar.Image = global::AppRealDolar.Properties.Resources.money4;
            this.btnConvertToDollar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertToDollar.Location = new System.Drawing.Point(335, 223);
            this.btnConvertToDollar.Name = "btnConvertToDollar";
            this.btnConvertToDollar.Size = new System.Drawing.Size(140, 30);
            this.btnConvertToDollar.TabIndex = 2;
            this.btnConvertToDollar.Text = "Converter para dólar";
            this.btnConvertToDollar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConvertToDollar.UseVisualStyleBackColor = true;
            this.btnConvertToDollar.Click += new System.EventHandler(this.btnConvertToDollar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblValorDollar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConvertToDollar);
            this.Controls.Add(this.txtValoremReal);
            this.Controls.Add(this.lblValoremReal);
            this.Controls.Add(this.lblCotacaoDollar);
            this.Controls.Add(this.txtCotacaoDolar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCotacaoDolar;
        private System.Windows.Forms.Label lblCotacaoDollar;
        private System.Windows.Forms.Label lblValoremReal;
        private System.Windows.Forms.TextBox txtValoremReal;
        private System.Windows.Forms.Button btnConvertToDollar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblValorDollar;
    }
}

