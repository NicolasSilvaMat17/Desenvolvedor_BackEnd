using Microsoft.IdentityModel.Tokens;
using Vendas.Classes.Contextos;

namespace Vendas
{
    public partial class Form1 : Form
    {
        // Campos
        VendasContexto vendasContexto = new VendasContexto();

        // Construtor
        public Form1()
        {

            InitializeComponent();
        }

        // Métodos
        void CarregarDados(string filtro = "")
        {
            var listaDeVendas = vendasContexto.vendas.ToList();
            dataGridView1.DataSource = listaDeVendas;
            switch (filtro)
            {
                case "Id":
                    // Pesquisar por Id
                    MessageBox.Show("Pesquisa feita por Id");
                    dataGridView1.DataSource = listaDeVendas
                        .Where(v => v.Id == int.Parse(textBox1.Text))
                        .ToList();
                    break;
                case "DataCompra":
                    // Pesquisar por data de compra
                    MessageBox.Show("Pesquisa feita por Data de Compra");
                    dataGridView1.DataSource = listaDeVendas
                        .Where(v => v.DataCompra.ToString().Contains(textBox1.Text))
                        .ToList();
                    break;
                case "Tipo":
                    // Pesquisar por Tipo
                    MessageBox.Show("Pesquisa feita por Tipo");
                    dataGridView1.DataSource = listaDeVendas
                        .Where(v => v.Tipo.Contains(textBox1.Text))
                        .ToList();
                    break;
                case "Marca":
                    // Pesquisar por Marca
                    dataGridView1.DataSource = listaDeVendas
                        .Where(v => v.Marca.Contains(textBox1.Text))
                        .ToList();
                    break;
                default:
                    dataGridView1.DataSource = listaDeVendas;
                    break;
            }
        }

        // Eventos
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IsNullOrEmpty())
            {
                CarregarDados();
            }
            else if (radioButton1.Checked)
            {
                CarregarDados("Id");
            }
            else if (radioButton2.Checked)
            {
                CarregarDados("DataCompra");
            }
            else if (radioButton3.Checked)
            {
                CarregarDados("Tipo");
            }
            else if (radioButton4.Checked)
            {
                CarregarDados("Marca");
            }
            else
            {
                MessageBox.Show("Selecione um filtro de pesquisa.");
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            textBox2.Text = linhaSelecionada.Cells["Id"].Value.ToString();
            textBox3.Text = linhaSelecionada.Cells["DataCompra"].Value.ToString();
            textBox4.Text = linhaSelecionada.Cells["Tipo"].Value.ToString();
            textBox5.Text = linhaSelecionada.Cells["Marca"].Value.ToString();
            textBox6.Text = linhaSelecionada.Cells["Faturamento"].Value.ToString();
            textBox7.Text = linhaSelecionada.Cells["Lucro"].Value.ToString();
            tabControl1.SelectedTab = tabPage2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox6.ReadOnly = false; 
            textBox7.ReadOnly = false;
        }
    }
}