namespace Lembretes
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.senhaLogin = new System.Windows.Forms.TextBox();
            this.mostrarSenha = new System.Windows.Forms.CheckBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.facaCadastro = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Faça Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(40, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-mail";
            // 
            // emailLogin
            // 
            this.emailLogin.Location = new System.Drawing.Point(41, 178);
            this.emailLogin.Name = "emailLogin";
            this.emailLogin.Size = new System.Drawing.Size(264, 23);
            this.emailLogin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(42, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // senhaLogin
            // 
            this.senhaLogin.Location = new System.Drawing.Point(44, 272);
            this.senhaLogin.Name = "senhaLogin";
            this.senhaLogin.Size = new System.Drawing.Size(264, 23);
            this.senhaLogin.TabIndex = 5;
            // 
            // mostrarSenha
            // 
            this.mostrarSenha.AutoSize = true;
            this.mostrarSenha.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mostrarSenha.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.mostrarSenha.Location = new System.Drawing.Point(47, 313);
            this.mostrarSenha.Name = "mostrarSenha";
            this.mostrarSenha.Size = new System.Drawing.Size(133, 25);
            this.mostrarSenha.TabIndex = 6;
            this.mostrarSenha.Text = "Mostrar senha";
            this.mostrarSenha.UseVisualStyleBackColor = true;
            this.mostrarSenha.CheckedChanged += new System.EventHandler(this.mostrarSenha_CheckedChanged);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEntrar.Location = new System.Drawing.Point(82, 380);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(172, 60);
            this.btnEntrar.TabIndex = 7;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(82, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Não é cadastrado?";
            // 
            // facaCadastro
            // 
            this.facaCadastro.ActiveLinkColor = System.Drawing.Color.White;
            this.facaCadastro.AutoSize = true;
            this.facaCadastro.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.facaCadastro.ForeColor = System.Drawing.Color.White;
            this.facaCadastro.LinkColor = System.Drawing.Color.White;
            this.facaCadastro.Location = new System.Drawing.Point(88, 499);
            this.facaCadastro.Name = "facaCadastro";
            this.facaCadastro.Size = new System.Drawing.Size(155, 30);
            this.facaCadastro.TabIndex = 10;
            this.facaCadastro.TabStop = true;
            this.facaCadastro.Text = "Fazer Cadastro";
            this.facaCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.facaCadastro_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(352, 571);
            this.Controls.Add(this.facaCadastro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.mostrarSenha);
            this.Controls.Add(this.senhaLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox emailLogin;
        private Label label3;
        private TextBox senhaLogin;
        private CheckBox mostrarSenha;
        private Button btnEntrar;
        private Label label4;
        private LinkLabel facaCadastro;
    }
}