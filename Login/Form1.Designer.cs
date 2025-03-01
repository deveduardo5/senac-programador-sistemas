namespace Login
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
            label1 = new Label();
            label2 = new Label();
            Usuario = new TextBox();
            Senha = new TextBox();
            Login = new Button();
            Resultado = new Label();
            identificação = new Label();
            Segurança = new Label();
            email = new TextBox();
            senha2 = new TextBox();
            acesso = new Button();
            resultado2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleDescription = "";
            label1.AccessibleName = "";
            label1.AutoSize = true;
            label1.Location = new Point(96, 70);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 99);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // Usuario
            // 
            Usuario.Location = new Point(168, 67);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(306, 23);
            Usuario.TabIndex = 2;
            // 
            // Senha
            // 
            Senha.Location = new Point(168, 96);
            Senha.Name = "Senha";
            Senha.Size = new Size(306, 23);
            Senha.TabIndex = 3;
            // 
            // Login
            // 
            Login.BackColor = SystemColors.ActiveBorder;
            Login.Location = new Point(287, 125);
            Login.Name = "Login";
            Login.Size = new Size(75, 23);
            Login.TabIndex = 4;
            Login.Text = "Entrar";
            Login.UseVisualStyleBackColor = false;
            Login.Click += button1_Click;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Location = new Point(96, 202);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(41, 15);
            Resultado.TabIndex = 5;
            Resultado.Text = "label 1";
            // 
            // identificação
            // 
            identificação.AutoSize = true;
            identificação.Location = new Point(818, 278);
            identificação.Name = "identificação";
            identificação.Size = new Size(41, 15);
            identificação.TabIndex = 6;
            identificação.Text = "E-mail";
            // 
            // Segurança
            // 
            Segurança.AutoSize = true;
            Segurança.Location = new Point(818, 323);
            Segurança.Name = "Segurança";
            Segurança.Size = new Size(39, 15);
            Segurança.TabIndex = 7;
            Segurança.Text = "Digito";
            // 
            // email
            // 
            email.Location = new Point(890, 275);
            email.Name = "email";
            email.Size = new Size(234, 23);
            email.TabIndex = 8;
            // 
            // senha2
            // 
            senha2.Location = new Point(890, 315);
            senha2.Name = "senha2";
            senha2.Size = new Size(234, 23);
            senha2.TabIndex = 9;
            // 
            // acesso
            // 
            acesso.Location = new Point(973, 344);
            acesso.Name = "acesso";
            acesso.Size = new Size(75, 23);
            acesso.TabIndex = 10;
            acesso.Text = "Acesso";
            acesso.UseVisualStyleBackColor = true;
            acesso.Click += acesso_Click;
            // 
            // resultado2
            // 
            resultado2.AutoSize = true;
            resultado2.Location = new Point(818, 391);
            resultado2.Name = "resultado2";
            resultado2.Size = new Size(38, 15);
            resultado2.TabIndex = 11;
            resultado2.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 450);
            Controls.Add(resultado2);
            Controls.Add(acesso);
            Controls.Add(senha2);
            Controls.Add(email);
            Controls.Add(Segurança);
            Controls.Add(identificação);
            Controls.Add(Resultado);
            Controls.Add(Login);
            Controls.Add(Senha);
            Controls.Add(Usuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login :)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Usuario;
        private TextBox Senha;
        private Button Login;
        private Label Resultado;
        private Label identificação;
        private Label Segurança;
        private TextBox email;
        private TextBox senha2;
        private Button acesso;
        private Label resultado2;
    }
}
