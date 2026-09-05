using CasasBahia2.Classes.Contextos;


namespace CasasBahia2
{
    public partial class Form1 : Form
    {
        // Campos
        Form2 janela1;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var contexto = new LoginContexto();

            var usuario = contexto.Login.FirstOrDefault(u => u.Usuario == textBox1.Text);
            var senha = contexto.Logins.FirstOrDefault(s => s.Senha == textBox2.Text);

            bool login = (usuario != null) & (senha != null);
            if (login)
            {
                // Abre a segunda tela (Form2) e fecha a primeira tela (Form1)
                MessageBox.Show("Login bem-sucedido!");
                janela1 = new Form2();
                Hide(); 
                janela1.Show();
            }
            else
            {
                MessageBox.Show(@"Usuário/senha incorretos, tente novamente!");
            }
        }
    }
}
