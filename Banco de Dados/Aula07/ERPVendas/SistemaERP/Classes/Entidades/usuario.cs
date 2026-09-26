namespace SistemaERP.Classes.Entidades
{
    internal class usuario
    {
        // Propriedades
        public int Id { get; set; }
        public string NomeDoUsuario { get; set; }
        public string SenhaDoUsuario { get; set; }
        public int Regra { get; set; }

        // Construtor
        public usuario(string nomeDoUsuario, string senhaDoUsuario, int regra)
        {
            NomeDoUsuario = nomeDoUsuario;
            SenhaDoUsuario = senhaDoUsuario;
            Regra = regra;
        }

        protected usuario(string nomeDoUsuario)
        {
            NomeDoUsuario = nomeDoUsuario;
        }
    }
}
