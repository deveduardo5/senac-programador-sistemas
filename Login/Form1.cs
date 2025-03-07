using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing.Text;

namespace Login
{
    public partial class Form1 : Form
    {
        List<string> listaUsuarios = new List<string>() { "neymar.jr", "pablo.vitar", "sukuna.silva" };
        // ney posição 0; pablo posição 1; sukuna posição 2.
        List<string> listaSenhas = new List<string>() { "Bruna@123", "12345Abc!", "Sete7sete!" };
        List<string> listaSenhasValidas = new List<string>(); // Lista para armazenar senhas válidas



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = Usuario.Text;
            string senha = Senha.Text;

            if (string.IsNullOrWhiteSpace(user))
            {
                Resultado.Text = "Usuário é obrigatório!";
                Resultado.ForeColor = Color.Red;
                return;
            }

            if (senha == null || senha == "")
            {
                Resultado.Text = "Senha é obrigatória!";
                Resultado.ForeColor = Color.Red;
                return;
            }

            int posicaoUsuarioEncontrado = -1;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (user == listaUsuarios[i])
                {
                    posicaoUsuarioEncontrado = i;
                }
            }

            if (posicaoUsuarioEncontrado > -1 && senha == listaSenhas[posicaoUsuarioEncontrado])
            {
                Resultado.Text = "Autenticado com sucesso!";
                Resultado.ForeColor = Color.Green;
            }

            else
            {
                Resultado.Text = "Usuario ou Senha incorretos...";
                Resultado.ForeColor = Color.Red;
            }

        }

        private void acesso_Click(object sender, EventArgs e)
        {
            string novoUsuario = email.Text;
            string novaSenha = senha2.Text;
            bool posicaoUsuarioEncontrado = false;

            if (string.IsNullOrWhiteSpace(novoUsuario))
            {
                resultado2.Text = "Usuário é obrigatório!";
                resultado2.ForeColor = Color.Red;
                return;
            }

            if (novaSenha == null || novaSenha == "")
            {
                resultado2.Text = "Senha é obrigatória!";
                resultado2.ForeColor = Color.Red;
                return;
            }

            // Validação de Senha
            if (!VerificarSenha(novaSenha))
            {
                resultado2.Text = "Senha inválida! Verifique os requisitos.";
                resultado2.ForeColor = Color.Red;
                return;
            }

            for (int i = 0; i < listaUsuarios.Count; i++)
            { 
                if (novoUsuario == listaUsuarios  [i])
                {
                    posicaoUsuarioEncontrado = true;
                }
            }

            if (posicaoUsuarioEncontrado == false)
            {
                listaUsuarios.Add(novoUsuario);
                listaSenhas.Add(novaSenha); // Adiciona a senha validada
                listaSenhasValidas.Add(novaSenha); // Adiciona a senha válida na nova lista
                resultado2.Text = "Usuário criado com sucesso!";
                resultado2.ForeColor = Color.Green;
            }
            else
            {
                resultado2.Text = "Usuário já existe!";
                resultado2.ForeColor = Color.Red;
            }

            // Validação de Senha

            // Exigências

            // - 8 chars min
            // - 1 cher espec min *
            // - 1 cher maiusculo min
            // - 1 cher minusculo min
            // - Sem espaço
            // - 1 número min

            bool VerificarSenha(string senha)
            {
                // Verifica se a senha tem pelo menos 8 caracteres
                if (senha.Length < 8)
                {
                    return false; // Se a senha for menor que 8 caracteres, retorna falso
                }

                bool temMaiuscula = false;
                bool temMinuscula = false;
                bool temNumero = false;
                bool temCaractereEspecial = false;

                // Verifica cada caractere da senha usando o laço for
                for (int i = 0; i < senha.Length; i++) // Itera cada caractere da senha
                {
                    char c = senha[i];

                    if (char.IsUpper(c)) // Se for letra maiúscula
                    {
                        temMaiuscula = true;
                        continue;
                    }
                    else if (char.IsLower(c)) // Se for letra minúscula
                    {
                        temMinuscula = true;
                        continue;
                    }
                    else if (char.IsDigit(c)) // Se for número
                    {
                        temNumero = true;
                        continue;
                    }
                    else if (!char.IsWhiteSpace(c)) // Se for caractere especial (não espaço)
                    {
                        temCaractereEspecial = true;
                        continue;
                    }
                }

                // Verifica se todos os requisitos foram atendidos
                if (temMaiuscula && temMinuscula && temNumero && temCaractereEspecial && !senha.Contains(" "))
                {
                    return true; // Se todos os requisitos estiverem atendidos, retorna verdadeiro
                }

                return false; // Caso contrário, retorna falso
            }

        }
    }
}
