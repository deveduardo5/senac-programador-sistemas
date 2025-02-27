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
            label1.Click += label1_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 450);
            Controls.Add(Resultado);
            Controls.Add(Login);
            Controls.Add(Senha);
            Controls.Add(Usuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login :)";
            Load += Form1_Load;
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
    }
}
