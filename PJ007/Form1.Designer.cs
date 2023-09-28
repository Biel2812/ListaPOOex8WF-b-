namespace PJ007
{
    partial class frmValores
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblx = new System.Windows.Forms.Label();
            this.lbly = new System.Windows.Forms.Label();
            this.txtValorx = new System.Windows.Forms.TextBox();
            this.txtValory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(589, 166);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.Calcular);
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Location = new System.Drawing.Point(512, 66);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(39, 13);
            this.lblx.TabIndex = 1;
            this.lblx.Text = "Valor x";
            // 
            // lbly
            // 
            this.lbly.AutoSize = true;
            this.lbly.Location = new System.Drawing.Point(512, 120);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(39, 13);
            this.lbly.TabIndex = 2;
            this.lbly.Text = "Valor y";
            // 
            // txtValorx
            // 
            this.txtValorx.Location = new System.Drawing.Point(575, 66);
            this.txtValorx.Name = "txtValorx";
            this.txtValorx.Size = new System.Drawing.Size(100, 20);
            this.txtValorx.TabIndex = 3;
            // 
            // txtValory
            // 
            this.txtValory.Location = new System.Drawing.Point(575, 120);
            this.txtValory.Name = "txtValory";
            this.txtValory.Size = new System.Drawing.Size(100, 20);
            this.txtValory.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Maior Valor (Resultado) = ";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(629, 230);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "0";
            // 
            // frmValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValory);
            this.Controls.Add(this.txtValorx);
            this.Controls.Add(this.lbly);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frmValores";
            this.Text = "Valores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Label lbly;
        private System.Windows.Forms.TextBox txtValorx;
        private System.Windows.Forms.TextBox txtValory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultado;
    }
}

