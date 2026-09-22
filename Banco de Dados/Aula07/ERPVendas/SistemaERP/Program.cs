using SistemaERP.Classes.Contexto;

namespace SistemaERP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ContextoUsuario contexto = new ContextoUsuario();
            
            if (TestarConexaoBanco())
            {
                Application.Run(new Login());
                contexto.Database.EnsureCreated();
                MessageBox.Show("Conexão bem sucedida");
            }
            else
            {
                MessageBox.Show("Falha ao conectar");
            }
            
        }

        private static bool TestarConexaoBanco()
        {
            try
            {
                ContextoUsuario contexto = new ContextoUsuario();
                return contexto.Database.CanConnect();
            }
            catch (Exception e)
            {

                MessageBox.Show($"Erro ao conectar ao banco de dados: {e.Message}");
                return false;
            }
        }
    }
}