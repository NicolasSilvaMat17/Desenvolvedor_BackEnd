using System.Net.Http.Json;
using TelaBanco.Classes.DTO;

namespace TelaBanco
{
    public partial class Form1 : Form
    {
        // Campo
        private readonly HttpClient http = new()
        {
            BaseAddress = new Uri("http://localhost:5268")
        };
        // Rotas de requisição
        string rota1 = "/api/contas";

        
        public Form1()
        {
            InitializeComponent();
            CarregarDados();
        }

        // Método para carregar dados no dataGridView
        private async Task CarregarDados()
        {
            try
            {
                var contas = await http.GetFromJsonAsync<List<ContaBancariaDTO>>(rota1);
                dataGridView1.DataSource = contas;
                dataGridView2.DataSource = contas;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao carregar dados da API, erro -> {e.Message}");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = radioButton1.Checked;

            textBox2.Visible = radioButton1.Checked;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string titular = textBox1.Text;
                decimal saldo;

                if (textBox2.Text.IsWhiteSpace() | textBox2.Text == null)
                {
                    saldo = 0;
                }
                else
                {
                    saldo = decimal.Parse(textBox2.Text);
                }

                ContaBancariaDTO conta = new ContaBancariaDTO(titular, saldo);

                var resposta = await http.PostAsJsonAsync(rota1, conta);

                if (resposta.IsSuccessStatusCode)
                {
                    MessageBox.Show("Conta criada com sucesso!");

                }
                else
                {
                    MessageBox.Show($"Erro ao adicionar a conta: {resposta.StatusCode}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erroao criar a conta -> Erro: " + ex.Message);
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await CarregarDados();
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            await CarregarDados();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var linha = dataGridView2.SelectedRows[0];
                DataGridViewRow linhaSelecionada = linha;
                var mensagem = MessageBox.Show("Tem certeza que deseja excluir a conta selecionada?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                if (mensagem)
                {
                    decimal numero = Convert.ToDecimal(linhaSelecionada.Cells["NumeroConta"].Value);
                    await http.DeleteAsync($"{rota1}/{numero}");
                }
                await CarregarDados();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar o dado -> " + ex.Message);
            }
        }
    }
}
