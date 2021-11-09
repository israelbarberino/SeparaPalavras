
namespace SeparaPalavras
{
    partial class FormPrincipal
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
            this.label = new System.Windows.Forms.Label();
            this.txbFrase = new System.Windows.Forms.TextBox();
            this.ltbPalavras = new System.Windows.Forms.ListBox();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(43, 37);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(258, 22);
            this.label.TabIndex = 0;
            this.label.Text = "Digite a frase a ser separada:";
            // 
            // txbFrase
            // 
            this.txbFrase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFrase.Location = new System.Drawing.Point(47, 71);
            this.txbFrase.Name = "txbFrase";
            this.txbFrase.Size = new System.Drawing.Size(691, 26);
            this.txbFrase.TabIndex = 1;
            this.txbFrase.TextChanged += new System.EventHandler(this.txbFrase_TextChanged);
            // 
            // ltbPalavras
            // 
            this.ltbPalavras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbPalavras.FormattingEnabled = true;
            this.ltbPalavras.ItemHeight = 18;
            this.ltbPalavras.Location = new System.Drawing.Point(47, 121);
            this.ltbPalavras.Name = "ltbPalavras";
            this.ltbPalavras.Size = new System.Drawing.Size(419, 382);
            this.ltbPalavras.TabIndex = 2;
            // 
            // btnProcessar
            // 
            this.btnProcessar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProcessar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnProcessar.Location = new System.Drawing.Point(588, 136);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(150, 50);
            this.btnProcessar.TabIndex = 3;
            this.btnProcessar.Text = "&Processar";
            this.btnProcessar.UseVisualStyleBackColor = false;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(588, 192);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(150, 50);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEncerrar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.Location = new System.Drawing.Point(588, 467);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(150, 50);
            this.btnEncerrar.TabIndex = 5;
            this.btnEncerrar.Text = "&Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.ltbPalavras);
            this.Controls.Add(this.txbFrase);
            this.Controls.Add(this.label);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Separador de Palavras";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txbFrase;
        private System.Windows.Forms.ListBox ltbPalavras;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEncerrar;
    }
}

