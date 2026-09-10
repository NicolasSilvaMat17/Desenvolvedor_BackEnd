using Vendas.Classes.Contextos;


namespace Vendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarDados();
        }

        void CarregarDados()
        {
            try
            {
                VendasContexto vendasContexto = new VendasContexto();
                var listaVendas = vendasContexto.vendas.ToList();
                dataGridView1.DataSource = listaVendas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}");
            }
        }
    }
}
