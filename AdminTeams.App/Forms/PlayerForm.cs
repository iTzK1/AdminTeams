using AdminTeams.App.Models;
using AdminTeams.Domain.Base;
using AdminTeams.Domain.Entities;
using AdminTeams.Service.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AdminTeams.App.Forms
{
    public partial class PlayerForm : Base.BaseForm
    {
        private readonly IBaseService<Player> _playerService;
        private readonly IBaseService<Team> _teamService;
        private readonly IBaseService<Position> _positionService;
        private List<PlayerViewModel>? players;

        public PlayerForm(IBaseService<Player> playerService,
                          IBaseService<Team> teamService,
                          IBaseService<Position> positionService)
        {
            _playerService = playerService;
            _teamService = teamService;
            _positionService = positionService;
            InitializeComponent();
            LoadCombos();
        }

        private void LoadCombos()
        {
            // Carrega os dados para os dropdowns
            var teams = _teamService.Get<TeamViewModel>().ToList();
            cmbTeam.DataSource = teams;
            cmbTeam.DisplayMember = "Name";
            cmbTeam.ValueMember = "Id";
            cmbTeam.SelectedIndex = -1;

            var positions = _positionService.Get<PositionViewModel>().ToList();
            cmbPosition.DataSource = positions;
            cmbPosition.DisplayMember = "Name";
            cmbPosition.ValueMember = "Id";
            cmbPosition.SelectedIndex = -1;
        }

        private void FormToObject(Player player)
        {
            player.Name = txtName.Text;
            player.BirthDate = dtBirth.Value;

            if (int.TryParse(txtShirt.Text, out int shirt))
                player.ShirtNumber = shirt;

            if (cmbTeam.SelectedValue != null)
                player.TeamId = (int)cmbTeam.SelectedValue;

            if (cmbPosition.SelectedValue != null)
                player.PositionId = (int)cmbPosition.SelectedValue;
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var player = _playerService.GetById<Player>(id);
                    FormToObject(player);
                    _playerService.Update<Player, Player, PlayerValidator>(player);
                }
                else
                {
                    var player = new Player();
                    FormToObject(player);
                    _playerService.Add<Player, Player, PlayerValidator>(player);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Admin Teams", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _playerService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Admin Teams", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            // Busca jogadores incluindo as entidades relacionadas para exibir o Nome do Time/Posição
            players = _playerService.Get<PlayerViewModel>(new List<string> { "Team", "Position" }).ToList();
            dataGridViewList.DataSource = players;
            dataGridViewList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            if (record == null) return;

            int id = int.Parse(record.Cells["Id"].Value.ToString());

            // Busca a entidade completa no banco para ter acesso aos IDs (TeamId, PositionId)
            // pois o Grid (ViewModel) só tem os nomes (Strings).
            var player = _playerService.GetById<Player>(id);

            txtId.Text = player.Id.ToString();
            txtName.Text = player.Name;
            txtShirt.Text = player.ShirtNumber.ToString();
            dtBirth.Value = player.BirthDate;

            cmbTeam.SelectedValue = player.TeamId;
            cmbPosition.SelectedValue = player.PositionId;
        }
    }
}