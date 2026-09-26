using SistemaERP.Classes.Servico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaERP.Telas
{
    public partial class Senhacs : Form
    {
        public Senhacs()
        {
            InitializeComponent();
        }

        private void Senhacs_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Botão de fechar da tela
            TelaLogin.AbrirTela();
        }
    }
}
