using AdminTeams.App.Infra;
using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AdminTeams.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Configure Dependency Injection first
            ConfigureDI.ConfigureServices();

            ApplicationConfiguration.Initialize();
            // We resolve the MainForm from the ServiceProvider
            var mainForm = Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetService<MainForm>(ConfigureDI.ServicesProvider);
            Application.Run(mainForm);
        }
    }
}