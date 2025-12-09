using System;
using System.Windows.Forms;
using AdminTeams.App.Infra;

namespace AdminTeams.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Configura DI (ConfigureDI deve popular ServicesProvider)
            ConfigureDI.ConfigureServices();

            var provider = ConfigureDI.ServicesProvider 
                ?? throw new InvalidOperationException("DI não foi configurado.");

            // Usa IServiceProvider.GetService para evitar depender de métodos de extensão ausentes
            var mainForm = provider.GetService(typeof(MainForm)) as MainForm
                ?? throw new InvalidOperationException("MainForm não registrado no container.");

            Application.Run(mainForm);
        }
    }
}