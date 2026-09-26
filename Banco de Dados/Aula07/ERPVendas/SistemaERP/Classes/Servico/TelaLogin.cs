using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaERP.Classes.Servico
{
    internal static class TelaLogin
    {
        static Login login;

        // Métodos
        public static void AbrirTela()
        {
            login = new Login();
            login.Show();
        }
    }
}
