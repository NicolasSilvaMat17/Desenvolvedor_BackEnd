using System.Net.Http.Json;

namespace ProdutosSENAI
{
    public partial class Form1 : Form
    {
        // Campo para armazenar a URL da API
        private readonly HttpClient clienteHttp = new() 
        {
            BaseAddress = new Uri("http://localhost:5142")
        };

        public Form1()
        {
            InitializeComponent();
        }

        // Botão Criar
        private void button1_Click(object sender, EventArgs e)
        {
            string mensagem;
            mensagem = clienteHttp.GetStringAsync("Produto").Result;
            MessageBox.Show(mensagem);
        }
    }
}
