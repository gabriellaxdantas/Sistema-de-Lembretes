namespace Lembretes
{
    partial class Cadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.TextBox();
            this.mostrarSenha = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.facaLogin = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faça seu cadastro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(40, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(41, 178);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(264, 23);
            this.email.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(41, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha";
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(44, 272);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(264, 23);
            this.senha.TabIndex = 4;
            // 
            // mostrarSenha
            // 
            this.mostrarSenha.AutoSize = true;
            this.mostrarSenha.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mostrarSenha.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.mostrarSenha.Location = new System.Drawing.Point(47, 313);
            this.mostrarSenha.Name = "mostrarSenha";
            this.mostrarSenha.Size = new System.Drawing.Size(133, 25);
            this.mostrarSenha.TabIndex = 5;
            this.mostrarSenha.Text = "Mostrar senha";
            this.mostrarSenha.UseVisualStyleBackColor = true;
            this.mostrarSenha.CheckedChanged += new System.EventHandler(this.mostrarSenha_CheckedChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(82, 380);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(172, 60);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // facaLogin
            // 
            this.facaLogin.ActiveLinkColor = System.Drawing.Color.White;
            this.facaLogin.AutoSize = true;
            this.facaLogin.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.facaLogin.ForeColor = System.Drawing.Color.White;
            this.facaLogin.LinkColor = System.Drawing.Color.White;
            this.facaLogin.Location = new System.Drawing.Point(103, 493);
            this.facaLogin.Name = "facaLogin";
            this.facaLogin.Size = new System.Drawing.Size(122, 30);
            this.facaLogin.TabIndex = 7;
            this.facaLogin.TabStop = true;
            this.facaLogin.Text = "Fazer Login";
            this.facaLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.facaLogin_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(92, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Já é cadastrado?";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(352, 571);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.facaLogin);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.mostrarSenha);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox email;
        private Label label3;
        private TextBox senha;
        private CheckBox mostrarSenha;
        private Button btnCadastrar;
        private LinkLabel facaLogin;
        private Label label4;
    }
}