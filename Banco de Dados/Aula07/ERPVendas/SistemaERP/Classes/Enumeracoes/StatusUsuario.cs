

using System.ComponentModel;

namespace SistemaERP.Classes.Enumeracoes
{
    internal enum StatusUsuario
    {
        [Description("Aguardando Aprovação")]
        Aguardando,
        [Description("Aprovado")]
        Aprovado,
        [Description("Reprovado")]
        Reprovado
    }
}
