namespace gerardor_de_Senhas_V4
{
    partial class Versao1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Versao1));
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.chkMaiusculas = new System.Windows.Forms.CheckBox();
            this.chkMinusculas = new System.Windows.Forms.CheckBox();
            this.chkNumeros = new System.Windows.Forms.CheckBox();
            this.chkSimbolos = new System.Windows.Forms.CheckBox();
            this.NChars = new System.Windows.Forms.NumericUpDown();
            this.BtnGerar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnCopiar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NChars)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(15, 14);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(902, 46);
            this.txtSenha.TabIndex = 0;
            // 
            // chkMaiusculas
            // 
            this.chkMaiusculas.AutoSize = true;
            this.chkMaiusculas.Location = new System.Drawing.Point(22, 87);
            this.chkMaiusculas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkMaiusculas.Name = "chkMaiusculas";
            this.chkMaiusculas.Size = new System.Drawing.Size(116, 24);
            this.chkMaiusculas.TabIndex = 1;
            this.chkMaiusculas.Text = "Maiusculas";
            this.chkMaiusculas.UseVisualStyleBackColor = true;
            // 
            // chkMinusculas
            // 
            this.chkMinusculas.AutoSize = true;
            this.chkMinusculas.Location = new System.Drawing.Point(183, 87);
            this.chkMinusculas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkMinusculas.Name = "chkMinusculas";
            this.chkMinusculas.Size = new System.Drawing.Size(116, 24);
            this.chkMinusculas.TabIndex = 2;
            this.chkMinusculas.Text = "Minusculas";
            this.chkMinusculas.UseVisualStyleBackColor = true;
            // 
            // chkNumeros
            // 
            this.chkNumeros.AutoSize = true;
            this.chkNumeros.Location = new System.Drawing.Point(355, 87);
            this.chkNumeros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkNumeros.Name = "chkNumeros";
            this.chkNumeros.Size = new System.Drawing.Size(99, 24);
            this.chkNumeros.TabIndex = 3;
            this.chkNumeros.Text = "Numeros";
            this.chkNumeros.UseVisualStyleBackColor = true;
            // 
            // chkSimbolos
            // 
            this.chkSimbolos.AutoSize = true;
            this.chkSimbolos.Location = new System.Drawing.Point(522, 87);
            this.chkSimbolos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkSimbolos.Name = "chkSimbolos";
            this.chkSimbolos.Size = new System.Drawing.Size(100, 24);
            this.chkSimbolos.TabIndex = 4;
            this.chkSimbolos.Text = "Simbolos";
            this.chkSimbolos.UseVisualStyleBackColor = true;
            // 
            // NChars
            // 
            this.NChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NChars.Location = new System.Drawing.Point(767, 78);
            this.NChars.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NChars.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NChars.Name = "NChars";
            this.NChars.Size = new System.Drawing.Size(75, 30);
            this.NChars.TabIndex = 5;
            // 
            // BtnGerar
            // 
            this.BtnGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGerar.Location = new System.Drawing.Point(15, 138);
            this.BtnGerar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(142, 49);
            this.BtnGerar.TabIndex = 6;
            this.BtnGerar.Text = "Gerar";
            this.BtnGerar.UseVisualStyleBackColor = false;
            this.BtnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpar.Location = new System.Drawing.Point(312, 138);
            this.BtnLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(133, 49);
            this.BtnLimpar.TabIndex = 7;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnCopiar
            // 
            this.BtnCopiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCopiar.Location = new System.Drawing.Point(170, 138);
            this.BtnCopiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCopiar.Name = "BtnCopiar";
            this.BtnCopiar.Size = new System.Drawing.Size(133, 49);
            this.BtnCopiar.TabIndex = 10;
            this.BtnCopiar.Text = "Copiar";
            this.BtnCopiar.UseVisualStyleBackColor = false;
            this.BtnCopiar.Click += new System.EventHandler(this.BtnCopiar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSair.Location = new System.Drawing.Point(467, 138);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(128, 49);
            this.BtnSair.TabIndex = 11;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click_1);
            // 
            // Versao1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 206);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnCopiar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnGerar);
            this.Controls.Add(this.NChars);
            this.Controls.Add(this.chkSimbolos);
            this.Controls.Add(this.chkNumeros);
            this.Controls.Add(this.chkMinusculas);
            this.Controls.Add(this.chkMaiusculas);
            this.Controls.Add(this.txtSenha);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Versao1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Versao1 © Dev Joel 2024 ";
            ((System.ComponentModel.ISupportInitialize)(this.NChars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.CheckBox chkMaiusculas;
        private System.Windows.Forms.CheckBox chkMinusculas;
        private System.Windows.Forms.CheckBox chkNumeros;
        private System.Windows.Forms.CheckBox chkSimbolos;
        private System.Windows.Forms.NumericUpDown NChars;
        private System.Windows.Forms.Button BtnGerar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnCopiar;
        private System.Windows.Forms.Button BtnSair;
    }
}