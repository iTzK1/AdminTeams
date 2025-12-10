using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AdminTeams.App.Models;
using AdminTeams.Domain.Base;
using AdminTeams.Domain.Entities;
using AdminTeams.Service.Validators; // corrigido de AdminTimes para AdminTeams
using IFSPStore.App.Base;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace AdminTeams.App.Forms
{
    public partial class TeamForm : BaseForm
    {
        private readonly IBaseService<Team> _teamService;
        private readonly MaterialSkinManager _materialSkinManager;

        // Controles
        private MaterialTextBoxEdit txtName;
        private MaterialTextBoxEdit txtCategory;
        private DataGridView gridTeams; // Usando DataGridView padrão para facilidade de binding
        private int? _selectedId = null;

        public TeamForm(IBaseService<Team> teamService)
        {
            _teamService = teamService;

            _materialSkinManager = MaterialSkinManager.Instance;
            _materialSkinManager.AddFormToManage(this);

            InitializeUI();
            LoadData();
        }

        private void InitializeUI()
        {
            this.Text = "Cadastro de Times";
            this.Size = new System.Drawing.Size(800, 600);
            this.StartPosition = FormStartPosition.CenterParent;

            // Inputs
            txtName = new MaterialTextBoxEdit() { Hint = "Nome do Time", Location = new System.Drawing.Point(20, 80), Size = new System.Drawing.Size(300, 50) };
            txtCategory = new MaterialTextBoxEdit() { Hint = "Categoria (ex: Profissional)", Location = new System.Drawing.Point(340, 80), Size = new System.Drawing.Size(300, 50) };

            this.Controls.Add(txtName);
            this.Controls.Add(txtCategory);

            // Botões
            var btnSave = new MaterialButton() { Text = "Salvar", Location = new System.Drawing.Point(660, 85), Size = new System.Drawing.Size(100, 40) };
            btnSave.Click += BtnSave_Click;
            this.Controls.Add(btnSave);

            var btnClear = new MaterialButton() { Text = "Novo", Location = new System.Drawing.Point(660, 135), Size = new System.Drawing.Size(100, 40), Type = MaterialButton.MaterialButtonType.Outlined };
            btnClear.Click += (s, e) => ClearFields();
            this.Controls.Add(btnClear);

            var btnDelete = new MaterialButton() { Text = "Excluir", Location = new System.Drawing.Point(20, 540), Type = MaterialButton.MaterialButtonType.Text };
            btnDelete.Click += BtnDelete_Click;
            this.Controls.Add(btnDelete);

            // Grid
            gridTeams = new DataGridView();
            gridTeams.Location = new System.Drawing.Point(20, 150);
            gridTeams.Size = new System.Drawing.Size(740, 380);
            gridTeams.BackgroundColor = System.Drawing.Color.White;
            gridTeams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridTeams.MultiSelect = false;
            gridTeams.ReadOnly = true;
            gridTeams.DoubleClick += GridTeams_DoubleClick;
            this.Controls.Add(gridTeams);
        }

        private void LoadData()
        {
            var teams = _teamService.Get<TeamViewModel>();
            gridTeams.DataSource = new List<TeamViewModel>(teams); // List wrapper
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var city = _cityService.GetById<City>(id);
                    FormToObject(city);
                    city = _cityService.Update<City, City, CityValidator>(city);
                }
                else
                {
                    var city = new City();
                    FormToObject(city);
                    _cityService.Add<City, City, CityValidator>(city);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                @"IFSP Store", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedId != null)
            {
                if (MessageBox.Show("Deseja excluir?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _teamService.Delete(_selectedId.Value);
                    ClearFields();
                    LoadData();
                }
            }
        }

        private void GridTeams_DoubleClick(object sender, EventArgs e)
        {
            if (gridTeams.SelectedRows.Count > 0)
            {
                var item = (TeamViewModel)gridTeams.SelectedRows[0].DataBoundItem;
                _selectedId = item.Id;
                txtName.Text = item.Name;
                txtCategory.Text = item.Category;
            }
        }

        private void ClearFields()
        {
            _selectedId = null;
            txtName.Text = "";
            txtCategory.Text = "";
            txtName.Focus();
        }
    }
}