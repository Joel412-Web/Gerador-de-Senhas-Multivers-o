namespace gerardor_de_Senhas_V4
{
    partial class frCapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCapa));
            this.BtnVersão1 = new System.Windows.Forms.Button();
            this.BtnVersão2 = new System.Windows.Forms.Button();
            this.BtnAutor = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVersão1
            // 
            this.BtnVersão1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnVersão1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVersão1.Location = new System.Drawing.Point(11, 7);
            this.BtnVersão1.Name = "BtnVersão1";
            this.BtnVersão1.Size = new System.Drawing.Size(319, 60);
            this.BtnVersão1.TabIndex = 0;
            this.BtnVersão1.Text = "Versao 1";
            this.BtnVersão1.UseVisualStyleBackColor = false;
            this.BtnVersão1.Click += new System.EventHandler(this.BtnVersão1_Click);
            // 
            // BtnVersão2
            // 
            this.BtnVersão2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnVersão2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVersão2.Location = new System.Drawing.Point(11, 77);
            this.BtnVersão2.Name = "BtnVersão2";
            this.BtnVersão2.Size = new System.Drawing.Size(319, 69);
            this.BtnVersão2.TabIndex = 1;
            this.BtnVersão2.Text = "Versao 2";
            this.BtnVersão2.UseVisualStyleBackColor = false;
            this.BtnVersão2.Click += new System.EventHandler(this.BtnVersão2_Click);
            // 
            // BtnAutor
            // 
            this.BtnAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnAutor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAutor.Location = new System.Drawing.Point(13, 158);
            this.BtnAutor.Name = "BtnAutor";
            this.BtnAutor.Size = new System.Drawing.Size(318, 70);
            this.BtnAutor.TabIndex = 2;
            this.BtnAutor.Text = "Autor";
            this.BtnAutor.UseVisualStyleBackColor = false;
            this.BtnAutor.Click += new System.EventHandler(this.BtnAutor_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSair.Location = new System.Drawing.Point(14, 242);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(317, 71);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // frCapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 329);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnAutor);
            this.Controls.Add(this.BtnVersão2);
            this.Controls.Add(this.BtnVersão1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frCapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capa Gerador de senhas © Dev Joel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVersão1;
        private System.Windows.Forms.Button BtnVersão2;
        private System.Windows.Forms.Button BtnAutor;
        private System.Windows.Forms.Button BtnSair;
    }
}

