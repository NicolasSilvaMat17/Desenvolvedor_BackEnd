

using System.ComponentModel;

namespace SistemaERP.Classes.Enumeracoes
{
    internal enum StatusUsuario
    {
        [Description("Aguardando Aprovação")]
        Aguardando = 0,
        [Description("Aprovado")]
        Aprovado = 1,
        [Description("Reprovado")]
        Reprovado = 2
    }
}
