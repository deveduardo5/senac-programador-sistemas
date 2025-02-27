namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = Usuario.Text;
            string senha = Senha.Text;

            //if (user == null || user == "")
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

            if (user == "eduardo.souza" && senha == "12345")
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
