using Cars.Classes.Animation;
using Cars.Classes.Contextos;
using Cars.Classes.Entidades;
using Cars.Classes.Services;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.ApplicationServices;
using System.Numerics;

namespace Cars;

public partial class Principal : Form
{
    // Controlador que concentra toda a lógica de animação do panel1.
    private readonly AnimationPanel animacaoPainel;
    EstoqueContexto contexto = new EstoqueContexto();

    public Principal()
    {
        // Inicializa os controles criados pelo Windows Forms Designer.
        InitializeComponent();

        // Cria o controlador e informa qual painel deverá ser animado.
        animacaoPainel = new AnimationPanel(panel1);

        // Associa os botões de navegação ao método que fecha o painel.
        button3.Click += FecharPanel_Click;
        button4.Click += FecharPanel_Click;
        button5.Click += FecharPanel_Click;
    }
    // Botão de comprar
    private void button2_Click(object? sender, EventArgs e)
    {

        try
        {
            DataGridViewRow linhaSelecionada = dataGridView1.SelectedRows[0];




            textBox2.Text = linhaSelecionada.Cells["Modelo"].Value.ToString();
            textBox3.Text = linhaSelecionada.Cells["Tipo"].Value.ToString();
            textBox4.Text = linhaSelecionada.Cells["Valor"].Value.ToString();
            textBox5.Text = linhaSelecionada.Cells["Quantidade"].Value.ToString();
            pictureBox1.ImageLocation = contexto.Estoque.FirstOrDefault(m => m.Modelo.Equals(linhaSelecionada.Cells["Modelo"].Value.ToString())).Foto;
            // Solicita à classe de animação que abra o painel ao clicar em Comprar.
            animacaoPainel.Abrir();

        }
        catch (Exception)
        {
            MessageBox.Show("Selecione uma linha da tabela");
        }
    }

    private void FecharPanel_Click(object? sender, EventArgs e)
    {
        // Solicita à classe de animação que feche o painel.
        animacaoPainel.Fechar();
    }


    private void button1_Click(object sender, EventArgs e)
    {

        Dados();
    }

    // Fechar compra
    private void button3_Click_1(object sender, EventArgs e)
    {
        int quantidade = int.Parse(textBox5.Text);
        int comprar = int.Parse(numericUpDown1.Text);
        decimal valor = decimal.Parse(textBox4.Text.Trim("R$"));
        decimal total = valor * comprar;
        MessageBox.Show($"Total da venda: {total:C}, " +
            $"quantidade adiquirida: {comprar}");



        var item = contexto.Estoque.FirstOrDefault(i => i.Modelo == textBox2.Text);
        item.RequisicaoEstoque(comprar);
        contexto.SaveChanges();
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            Dados();
            textBox1.Text = "";
        }
    }
    /// <summary>
    /// Inserir dados na datagridview conforme o filtro selecionado
    /// </summary>
    private void Dados()
    {
        bool moto = checkBox1.Checked;
        bool carro = checkBox2.Checked;
        string texto = textBox1.Text;
        string filtro = comboBox1.Text;

        Pesquisa.Pesquisas(moto, carro, texto, dataGridView1, filtro);

    }
}