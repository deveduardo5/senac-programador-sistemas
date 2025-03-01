using Microsoft.VisualBasic.ApplicationServices;

namespace Login
{
    public partial class Form1 : Form
    {
        List<string> listaUsuarios = new List<string>() { "neymar.jr", "pablo.vitar", "sukuna.silva" };
        // ney posição 0; pablo posição 1; sukuna posição 2.
        List<string> listaSenhas = new List<string>() { "bruna", "12345", "777" };



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
                Resultado.Text = "Usuário é obrigatório!";
                Resultado.ForeColor = Color.Red;
                return;
            }

            if (novaSenha == null || novaSenha == "")
            {
                Resultado.Text = "Senha é obrigatória!";
                Resultado.ForeColor = Color.Red;
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
                listaSenhas.Add(novoUsuario);
                resultado2.Text = "Criado";
            }
            else 
            {
                resultado2.Text = "Já existe";
            }

        }
    }
}
