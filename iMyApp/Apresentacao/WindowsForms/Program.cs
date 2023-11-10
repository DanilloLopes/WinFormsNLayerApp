using WindowsForms.Telas.Cargos;
using WindowsForms.Telas.Clientes;
using WindowsForms.Telas.Clientes.Usuarios;

namespace WindowsForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                
                
                ApplicationConfiguration.Initialize();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmUsuarios());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
         }
    }
}