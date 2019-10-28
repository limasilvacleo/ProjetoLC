namespace UI_ProjetoLC
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
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnAcessarLogin = new System.Windows.Forms.Button();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.txtUserLogin = new System.Windows.Forms.TextBox();
            this.lblSenhaLogin = new System.Windows.Forms.Label();
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.lblSaudacaoLogin = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbLogin.Controls.Add(this.btnAcessarLogin);
            this.gbLogin.Controls.Add(this.txtSenhaLogin);
            this.gbLogin.Controls.Add(this.txtUserLogin);
            this.gbLogin.Controls.Add(this.lblSenhaLogin);
            this.gbLogin.Controls.Add(this.lblUserLogin);
            this.gbLogin.Location = new System.Drawing.Point(23, 89);
            this.gbLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbLogin.Size = new System.Drawing.Size(486, 259);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            // 
            // btnAcessarLogin
            // 
            this.btnAcessarLogin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAcessarLogin.Location = new System.Drawing.Point(177, 193);
            this.btnAcessarLogin.Name = "btnAcessarLogin";
            this.btnAcessarLogin.Size = new System.Drawing.Size(171, 42);
            this.btnAcessarLogin.TabIndex = 4;
            this.btnAcessarLogin.Text = "ACESSAR";
            this.btnAcessarLogin.UseVisualStyleBackColor = false;
            this.btnAcessarLogin.Click += new System.EventHandler(this.btnAcessarLogin_Click);
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtSenhaLogin.Location = new System.Drawing.Point(211, 106);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.PasswordChar = '*';
            this.txtSenhaLogin.Size = new System.Drawing.Size(183, 26);
            this.txtSenhaLogin.TabIndex = 3;
            this.txtSenhaLogin.TextChanged += new System.EventHandler(this.txtSenhaLogin_TextChanged);
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtUserLogin.Location = new System.Drawing.Point(211, 42);
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(183, 26);
            this.txtUserLogin.TabIndex = 2;
            // 
            // lblSenhaLogin
            // 
            this.lblSenhaLogin.AutoSize = true;
            this.lblSenhaLogin.Location = new System.Drawing.Point(107, 109);
            this.lblSenhaLogin.Name = "lblSenhaLogin";
            this.lblSenhaLogin.Size = new System.Drawing.Size(54, 20);
            this.lblSenhaLogin.TabIndex = 1;
            this.lblSenhaLogin.Text = "SENHA";
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.Location = new System.Drawing.Point(107, 42);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(74, 23);
            this.lblUserLogin.TabIndex = 0;
            this.lblUserLogin.Text = "USUÁRIO";
            // 
            // lblSaudacaoLogin
            // 
            this.lblSaudacaoLogin.AutoSize = true;
            this.lblSaudacaoLogin.Location = new System.Drawing.Point(96, 38);
            this.lblSaudacaoLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaudacaoLogin.Name = "lblSaudacaoLogin";
            this.lblSaudacaoLogin.Size = new System.Drawing.Size(285, 20);
            this.lblSaudacaoLogin.TabIndex = 1;
            this.lblSaudacaoLogin.Text = "SEJA BEM VINDO(A) À LIMA CONSULTORIA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(533, 362);
            this.Controls.Add(this.lblSaudacaoLogin);
            this.Controls.Add(this.gbLogin);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "LIMA CONSULTORIA - LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label lblSaudacaoLogin;
        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.TextBox txtUserLogin;
        private System.Windows.Forms.Label lblSenhaLogin;
        private System.Windows.Forms.Button btnAcessarLogin;
    }
}

