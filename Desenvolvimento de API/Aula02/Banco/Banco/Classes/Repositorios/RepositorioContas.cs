using Banco.Classes.Models.Contextos;
using Banco.Classes.Models.Entidades;
using Microsoft.Extensions.Options;

namespace Banco.Classes.Repositorios
{
    public class RepositorioContas
    {
        // Campos
        private ContextoConta contexto = new ContextoConta();

        // Propriedades
        public ContextoConta Contexto
        {
            get { return contexto; }
            set { contexto = value; }
        }

        // Métodos
        public List<ContaBancariacs> ListarContas()
        {
            var lista = contexto.contasBancarias.ToList();
            return lista;
        }

        public void CriarConta(ContaBancariacs conta)
        {
            contexto.contasBancarias.Add(conta);
            contexto.SaveChanges();
        }

        public ContaBancariacs PesquisarContasID(int numero)
        {
            var pesquisar = contexto.contasBancarias.FirstOrDefault(c => c.NumeroConta == numero);
            return pesquisar;
        }

        public bool EditarConta(ContaBancariacs conta)
        {
            var existe = PesquisarContasID(conta.NumeroConta);
            if (existe == null)
            {
                return false;
            }
            else
            {
                existe.TitularConta = conta.TitularConta;
                contexto.SaveChanges();
                return true;
            }
        }
        public bool DeletarConta(int numero)
        {
            var conta = PesquisarContasID(numero);
            if (conta == null)
            {
                return false;
            }
            else
            {
                contexto.Remove(conta);
                contexto.SaveChanges();
                return true;
            }
        }
    }
}
