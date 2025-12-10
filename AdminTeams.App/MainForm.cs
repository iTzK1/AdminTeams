using IFSPStore.App.Base;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Material;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System;
using System.Windows.Forms;

namespace AdminTeams.App
{
    public partial class MainForm : BaseForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly MaterialSkinManager _materialSkinManager;

        public MainForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            // Configuração do Tema Material
            _materialSkinManager = MaterialSkinManager.Instance;
            _materialSkinManager.AddFormToManage(this);
            _materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            _materialSkinManager.ColorScheme = new MaterialColorScheme(
                MaterialPrimary.Indigo500, MaterialPrimary.Indigo700,
                MaterialPrimary.Indigo100, MaterialAccent.Pink200,
                MaterialTextShade.WHITE);

            InitializeUI();
        }

        private void InitializeUI()
        {
            this.Text = "Sistema de Gestão de Times - AdminTeams";
            this.Size = new System.Drawing.Size(800, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Botão Times
            var btnTeams = new MaterialButton()
            {
                Text = "Gerenciar Times",
                Size = new System.Drawing.Size(200, 50),
                Location = new System.Drawing.Point(50, 100),
                IconType = MaterialButton.MaterialIconType.Default
            };
            btnTeams.Click += (s, e) => OpenForm<AdminTeams.App.Forms.TeamForm>();
            this.Controls.Add(btnTeams);

            // Botão Posições
            var btnPositions = new MaterialButton()
            {
                Text = "Gerenciar Posições",
                Size = new System.Drawing.Size(200, 50),
                Location = new System.Drawing.Point(280, 100),
            };
            btnPositions.Click += (s, e) => OpenForm<AdminTeams.App.Forms.PositionForm>();
            this.Controls.Add(btnPositions);

            // Botão Jogadores
            var btnPlayers = new MaterialButton()
            {
                Text = "Gerenciar Jogadores",
                Size = new System.Drawing.Size(200, 50),
                Location = new System.Drawing.Point(510, 100),
            };
            btnPlayers.Click += (s, e) => OpenForm<AdminTeams.App.Forms.PlayerForm>();
            this.Controls.Add(btnPlayers);

        }

        private void OpenForm<T>() where T : Form
        {
            var form = _serviceProvider.GetRequiredService<T>();
            form.ShowDialog(); // Abre como modal
        }
    }
}