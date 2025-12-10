using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AdminTeams.App.Models;
using AdminTeams.Domain.Base;
using AdminTeams.Domain.Entities;
using AdminTeams.Service.Validators;
using IFSPStore.App.Base;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace AdminTeams.App.Forms
{
    public partial class PlayerForm : BaseForm
    {
        private readonly IBaseService<Player> _playerService;
        private readonly IBaseService<Team> _teamService;
        private readonly IBaseService<Position> _positionService;
        private readonly MaterialSkinManager _materialSkinManager;

        private MaterialTextBoxEdit txtName;
        private MaterialTextBoxEdit txtShirt;
        private DateTimePicker dtBirth; // ReaLTaiizor não tem um DatePicker nativo fácil, usaremos o padrão
        private MaterialComboBox cmbTeam;
        private MaterialComboBox cmbPosition;
        private DataGridView grid;
        private int? _selectedId = null;

        public PlayerForm(IBaseService<Player> playerService, IBaseService<Team> teamService, IBaseService<Position> positionService)
        {
            _playerService = playerService;
            _teamService = teamService;
            _positionService = positionService;

            _materialSkinManager = MaterialSkinManager.Instance;
            _materialSkinManager.AddFormToManage(this);

            InitializeUI();
            LoadCombos();
            LoadData();
        }

        private void InitializeUI()
        {
            this.Text = "Gestão de Jogadores";
            this.Size = new System.Drawing.Size(900, 700);
            this.StartPosition = FormStartPosition.CenterParent;

            // Linha 1
            txtName = new MaterialTextBoxEdit() { Hint = "Nome do Jogador", Location = new System.Drawing.Point(20, 80), Size = new System.Drawing.Size(400, 50) };
            this.Controls.Add(txtName);

            txtShirt = new MaterialTextBoxEdit() { Hint = "Nº Camisa", Location = new System.Drawing.Point(440, 80), Size = new System.Drawing.Size(100, 50) };
            this.Controls.Add(txtShirt);

            // Linha 2
            var lblDate = new MaterialLabel() { Text = "Data Nasc.:", Location = new System.Drawing.Point(20, 145) };
            this.Controls.Add(lblDate);

            dtBirth = new DateTimePicker() { Location = new System.Drawing.Point(120, 140), Format = DateTimePickerFormat.Short, Size = new System.Drawing.Size(150, 30) };
            this.Controls.Add(dtBirth);

            // Combos
            cmbTeam = new MaterialComboBox() { Hint = "Time", Location = new System.Drawing.Point(300, 140), Size = new System.Drawing.Size(250, 50) };
            this.Controls.Add(cmbTeam);

            cmbPosition = new MaterialComboBox() { Hint = "Posição", Location = new System.Drawing.Point(570, 140), Size = new System.Drawing.Size(200, 50) };
            this.Controls.Add(cmbPosition);

            // Botões
            var btnSave = new MaterialButton() { Text = "Salvar", Location = new System.Drawing.Point(780, 85), Size = new System.Drawing.Size(100, 40) };
            btnSave.Click += BtnSave_Click;
            this.Controls.Add(btnSave);

            var btnClear = new MaterialButton() { Text = "Novo", Location = new System.Drawing.Point(780, 135), Size = new System.Drawing.Size(100, 40), Type = MaterialButton.MaterialButtonType.Outlined };
            btnClear.Click += (s, e) => ClearFields();
            this.Controls.Add(btnClear);

            var btnDelete = new MaterialButton() { Text = "Excluir", Location = new System.Drawing.Point(20, 640), Type = MaterialButton.MaterialButtonType.Text };
            btnDelete.Click += BtnDelete_Click;
            this.Controls.Add(btnDelete);

            // Grid
            grid = new DataGridView();
            grid.Location = new System.Drawing.Point(20, 210);
            grid.Size = new System.Drawing.Size(840, 420);
            grid.BackgroundColor = System.Drawing.Color.White;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.ReadOnly = true;
            grid.DoubleClick += Grid_DoubleClick;
            this.Controls.Add(grid);
        }

        private void LoadCombos()
        {
            var teams = _teamService.Get<TeamViewModel>();
            cmbTeam.DataSource = new List<TeamViewModel>(teams);
            cmbTeam.DisplayMember = "Name";
            cmbTeam.ValueMember = "Id";

            var positions = _positionService.Get<PositionViewModel>();
            cmbPosition.DataSource = new List<PositionViewModel>(positions);
            cmbPosition.DisplayMember = "Name";
            cmbPosition.ValueMember = "Id";
        }

        private void LoadData()
        {
            // Inclui as tabelas relacionadas para exibir os nomes no Grid
            var players = _playerService.Get<PlayerViewModel>(new List<string> { "Team", "Position" });
            grid.DataSource = new List<PlayerViewModel>(players);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTeam.SelectedValue == null || cmbPosition.SelectedValue == null)
                {
                    MessageBox.Show("Selecione Time e Posição.");
                    return;
                }

                var model = new PlayerInputModel
                {
                    Id = _selectedId ?? 0,
                    Name = txtName.Text,
                    BirthDate = dtBirth.Value,
                    ShirtNumber = int.TryParse(txtShirt.Text, out int n) ? n : 0,
                    TeamId = (int)cmbTeam.SelectedValue,
                    PositionId = (int)cmbPosition.SelectedValue
                };

                if (_selectedId == null)
                    _playerService.Add<PlayerInputModel, PlayerViewModel, PlayerValidator>(model);
                else
                    _playerService.Update<PlayerInputModel, PlayerViewModel, PlayerValidator>(model);

                MessageBox.Show("Jogador Salvo!");
                ClearFields();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedId != null && MessageBox.Show("Excluir Jogador?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _playerService.Delete(_selectedId.Value);
                ClearFields();
                LoadData();
            }
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                var item = (PlayerViewModel)grid.SelectedRows[0].DataBoundItem;

                // Para carregar os IDs corretos para edição, o ideal seria buscar o InputModel pelo ID
                // Mas podemos deduzir ou buscar a entidade novamente. Vamos buscar a entidade completa.
                var entity = _playerService.GetById<PlayerInputModel>(item.Id);

                _selectedId = entity.Id;
                txtName.Text = entity.Name;
                dtBirth.Value = entity.BirthDate;
                txtShirt.Text = entity.ShirtNumber.ToString();
                cmbTeam.SelectedValue = entity.TeamId;
                cmbPosition.SelectedValue = entity.PositionId;
            }
        }

        private void ClearFields()
        {
            _selectedId = null;
            txtName.Text = "";
            txtShirt.Text = "";
            dtBirth.Value = DateTime.Now;
            if (cmbTeam.Items.Count > 0) cmbTeam.SelectedIndex = 0;
            if (cmbPosition.Items.Count > 0) cmbPosition.SelectedIndex = 0;
        }
    }
}