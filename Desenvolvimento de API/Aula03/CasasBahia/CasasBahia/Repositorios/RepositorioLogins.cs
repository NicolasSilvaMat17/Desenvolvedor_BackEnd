using CasasBahia.Classes.Models.Contextos;
using CasasBahia.Classes.Models.Entidades;

namespace CasasBahia.Repositorios
{
    public class RepositorioLogins
    {
        // Campo
        private ContextoLogin contexto = new ContextoLogin();

        // Método
        public List<Logins> ListarUsuarios()
        {
            var lista = contexto.Logins.ToList();
            return lista;
        }

        public Logins PesquisarUsuárioId(int id)
        {
            var pesquisar = contexto.Logins.FirstOrDefault(u => u.Id == id);
            return pesquisar;
        }

        public void CriarUsuario(Logins user)
        {
            contexto.Logins.Add(user);
            contexto.SaveChanges();
        }

        public bool EditarConta(Logins user)
        {
            var existeUser = PesquisarUsuárioId(user.Id);
            if (existeUser == null)
            {
                return false;
            }
            existeUser.Usuario = user.Usuario;
            existeUser.Senha = user.Senha;
            existeUser.Regra = user.Regra;
            contexto.SaveChanges();
            return true;
        }

        public bool DeletarUsuario(int id)
        {
            var existe = PesquisarUsuárioId(id);
            if (existe == null)
            {
                return false;
            }
            else
            {
                contexto.Remove(existe);
                contexto.SaveChanges();
                return true;
            }
        }
    }
}
