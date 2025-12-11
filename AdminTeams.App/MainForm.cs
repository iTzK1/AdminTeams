using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Enum.Material;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System;
using System.Windows.Forms;

namespace AdminTeams.App
{
    public partial class MainForm : MaterialForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly MaterialSkinManager _materialSkinManager;

        public MainForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            // Chama o método criado no Designer para montar a tela
            InitializeComponent();

            // Configuração do Tema Material
            _materialSkinManager = MaterialSkinManager.Instance;
            _materialSkinManager.AddFormToManage(this);
            _materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            _materialSkinManager.ColorScheme = new MaterialColorScheme(
                MaterialPrimary.Indigo500, MaterialPrimary.Indigo700,
                MaterialPrimary.Indigo100, MaterialAccent.Pink200,
                MaterialTextShade.WHITE);
        }

        // Método genérico para abrir os forms
        private void OpenForm<T>() where T : Form
        {
            var form = _serviceProvider.GetRequiredService<T>();
            form.ShowDialog();
        }

        // Eventos de clique (vinculados no Designer)
        private void btnTeams_Click(object sender, EventArgs e)
        {
            OpenForm<AdminTeams.App.Forms.TeamForm>();
        }

        private void btnPositions_Click(object sender, EventArgs e)
        {
            OpenForm<AdminTeams.App.Forms.PositionForm>();
        }

        private void btnPlayers_Click(object sender, EventArgs e)
        {
            OpenForm<AdminTeams.App.Forms.PlayerForm>();
        }

        private void btnInjuries_Click(object sender, EventArgs e)
        {
            OpenForm<AdminTeams.App.Forms.InjuryForm>();
        }
    }
}