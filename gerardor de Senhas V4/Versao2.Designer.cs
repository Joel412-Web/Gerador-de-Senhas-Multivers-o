namespace gerardor_de_Senhas_V4
{
    partial class Versao2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Versao2));
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.chkMaiusculas = new System.Windows.Forms.CheckBox();
            this.chkMinusculas = new System.Windows.Forms.CheckBox();
            this.ChkNumeros = new System.Windows.Forms.CheckBox();
            this.chkSimbolos = new System.Windows.Forms.CheckBox();
            this.Nchars = new System.Windows.Forms.NumericUpDown();
            this.BtnGerar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.BtnCopiar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.Senhas = new System.Windows.Forms.ListBox();
            this.BtnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Nchars)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(13, 13);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(649, 39);
            this.txtSenha.TabIndex = 0;
            // 
            // chkMaiusculas
            // 
            this.chkMaiusculas.AutoSize = true;
            this.chkMaiusculas.Location = new System.Drawing.Point(13, 69);
            this.chkMaiusculas.Name = "chkMaiusculas";
            this.chkMaiusculas.Size = new System.Drawing.Size(97, 20);
            this.chkMaiusculas.TabIndex = 1;
            this.chkMaiusculas.Text = "Maiusculas";
            this.chkMaiusculas.UseVisualStyleBackColor = true;
            // 
            // chkMinusculas
            // 
            this.chkMinusculas.AutoSize = true;
            this.chkMinusculas.Location = new System.Drawing.Point(135, 67);
            this.chkMinusculas.Name = "chkMinusculas";
            this.chkMinusculas.Size = new System.Drawing.Size(96, 20);
            this.chkMinusculas.TabIndex = 2;
            this.chkMinusculas.Text = "Minusculas";
            this.chkMinusculas.UseVisualStyleBackColor = true;
            // 
            // ChkNumeros
            // 
            this.ChkNumeros.AutoSize = true;
            this.ChkNumeros.Location = new System.Drawing.Point(271, 67);
            this.ChkNumeros.Name = "ChkNumeros";
            this.ChkNumeros.Size = new System.Drawing.Size(84, 20);
            this.ChkNumeros.TabIndex = 3;
            this.ChkNumeros.Text = "Numeros";
            this.ChkNumeros.UseVisualStyleBackColor = true;
            // 
            // chkSimbolos
            // 
            this.chkSimbolos.AutoSize = true;
            this.chkSimbolos.Location = new System.Drawing.Point(397, 67);
            this.chkSimbolos.Name = "chkSimbolos";
            this.chkSimbolos.Size = new System.Drawing.Size(86, 20);
            this.chkSimbolos.TabIndex = 4;
            this.chkSimbolos.Text = "Simbolos";
            this.chkSimbolos.UseVisualStyleBackColor = true;
            // 
            // Nchars
            // 
            this.Nchars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nchars.Location = new System.Drawing.Point(604, 59);
            this.Nchars.Name = "Nchars";
            this.Nchars.Size = new System.Drawing.Size(58, 30);
            this.Nchars.TabIndex = 5;
            // 
            // BtnGerar
            // 
            this.BtnGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGerar.Location = new System.Drawing.Point(13, 101);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(113, 38);
            this.BtnGerar.TabIndex = 6;
            this.BtnGerar.Text = "Gerar";
            this.BtnGerar.UseVisualStyleBackColor = false;
            this.BtnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCarregar.Location = new System.Drawing.Point(135, 101);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(110, 38);
            this.btnCarregar.TabIndex = 7;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = false;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // BtnCopiar
            // 
            this.BtnCopiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCopiar.Location = new System.Drawing.Point(252, 101);
            this.BtnCopiar.Name = "BtnCopiar";
            this.BtnCopiar.Size = new System.Drawing.Size(103, 38);
            this.BtnCopiar.TabIndex = 8;
            this.BtnCopiar.Text = "Copiar";
            this.BtnCopiar.UseVisualStyleBackColor = false;
            this.BtnCopiar.Click += new System.EventHandler(this.BtnCopiar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpar.Location = new System.Drawing.Point(362, 101);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(97, 38);
            this.BtnLimpar.TabIndex = 9;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // Senhas
            // 
            this.Senhas.FormattingEnabled = true;
            this.Senhas.ItemHeight = 16;
            this.Senhas.Location = new System.Drawing.Point(13, 154);
            this.Senhas.Name = "Senhas";
            this.Senhas.ScrollAlwaysVisible = true;
            this.Senhas.Size = new System.Drawing.Size(649, 116);
            this.Senhas.TabIndex = 10;
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSair.Location = new System.Drawing.Point(466, 101);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(117, 38);
            this.BtnSair.TabIndex = 11;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Versao2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 280);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.Senhas);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnCopiar);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.BtnGerar);
            this.Controls.Add(this.Nchars);
            this.Controls.Add(this.chkSimbolos);
            this.Controls.Add(this.ChkNumeros);
            this.Controls.Add(this.chkMinusculas);
            this.Controls.Add(this.chkMaiusculas);
            this.Controls.Add(this.txtSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Versao2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Versao2 © Dev Joel ";
            ((System.ComponentModel.ISupportInitialize)(this.Nchars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.CheckBox chkMaiusculas;
        private System.Windows.Forms.CheckBox chkMinusculas;
        private System.Windows.Forms.CheckBox ChkNumeros;
        private System.Windows.Forms.CheckBox chkSimbolos;
        private System.Windows.Forms.NumericUpDown Nchars;
        private System.Windows.Forms.Button BtnGerar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button BtnCopiar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.ListBox Senhas;
        private System.Windows.Forms.Button BtnSair;
    }
}