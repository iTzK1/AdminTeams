using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AdminTeams.App.Models;
using AdminTeams.Domain.Base;
using AdminTeams.Domain.Entities;
using AdminTeams.Service.Validators;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace AdminTeams.App.Forms
{
    public partial class PositionForm : MaterialForm
    {
        private readonly IBaseService<Position> _service;
        private readonly MaterialSkinManager _materialSkinManager;

        private MaterialTextBoxEdit txtName;
        private MaterialTextBoxEdit txtAcronym;
        private DataGridView grid;
        private int? _selectedId = null;

        public PositionForm(IBaseService<Position> service)
        {
            _service = service;
            _materialSkinManager = MaterialSkinManager.Instance;
            _materialSkinManager.AddFormToManage(this);
            InitializeUI();
            LoadData();
        }

        private void InitializeUI()
        {
            this.Text = "Cadastro de Posições";
            this.Size = new System.Drawing.Size(800, 600);
            this.StartPosition = FormStartPosition.CenterParent;

            txtName = new MaterialTextBoxEdit() { Hint = "Nome da Posição", Location = new System.Drawing.Point(20, 80), Size = new System.Drawing.Size(300, 50) };
            txtAcronym = new MaterialTextBoxEdit() { Hint = "Sigla (ex: ATA)", Location = new System.Drawing.Point(340, 80), Size = new System.Drawing.Size(300, 50) };

            this.Controls.Add(txtName);
            this.Controls.Add(txtAcronym);

            var btnSave = new MaterialButton() { Text = "Salvar", Location = new System.Drawing.Point(660, 85), Size = new System.Drawing.Size(100, 40) };
            btnSave.Click += BtnSave_Click;
            this.Controls.Add(btnSave);

            var btnClear = new MaterialButton() { Text = "Novo", Location = new System.Drawing.Point(660, 135), Size = new System.Drawing.Size(100, 40), Type = MaterialButton.MaterialButtonType.Outlined };
            btnClear.Click += (s, e) => ClearFields();
            this.Controls.Add(btnClear);

            var btnDelete = new MaterialButton() { Text = "Excluir", Location = new System.Drawing.Point(20, 540), Type = MaterialButton.MaterialButtonType.Text };
            btnDelete.Click += BtnDelete_Click;
            this.Controls.Add(btnDelete);

            grid = new DataGridView();
            grid.Location = new System.Drawing.Point(20, 150);
            grid.Size = new System.Drawing.Size(740, 380);
            grid.BackgroundColor = System.Drawing.Color.White;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.ReadOnly = true;
            grid.DoubleClick += Grid_DoubleClick;
            this.Controls.Add(grid);
        }

        private void LoadData()
        {
            var data = _service.Get<PositionViewModel>();
            grid.DataSource = new List<PositionViewModel>(data);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var model = new PositionInputModel
                {
                    Id = _selectedId ?? 0,
                    Name = txtName.Text,
                    Acronym = txtAcronym.Text
                };

                if (_selectedId == null)
                    _service.Add<PositionInputModel, PositionViewModel, PositionValidator>(model);
                else
                    _service.Update<PositionInputModel, PositionViewModel, PositionValidator>(model);

                MessageBox.Show("Salvo!");
                ClearFields();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedId != null && MessageBox.Show("Excluir?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _service.Delete(_selectedId.Value);
                ClearFields();
                LoadData();
            }
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                var item = (PositionViewModel)grid.SelectedRows[0].DataBoundItem;
                _selectedId = item.Id;
                txtName.Text = item.Name;
                txtAcronym.Text = item.Acronym;
            }
        }

        private void ClearFields()
        {
            _selectedId = null;
            txtName.Text = "";
            txtAcronym.Text = "";
        }
    }
}