
using System.Text;

namespace Pedido.Classes.Entidades
{
    // Objeto que pode existir de forma independente
    internal class Funcionario
    {
        // 1° - Campos
        private string nome;


        // 2° - Prpriedades 
        public string Nome
        {
            get { return Nome; }
            set { Nome = value; }
        }

        // 3° - Construtor
        public Funcionario(string nome)
        {
            Nome = nome;
        }



    }
}
