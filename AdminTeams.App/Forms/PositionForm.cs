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
    public partial class PositionForm : Base.BaseForm
    {
        private readonly IBaseService<Position> _positionService;
        private List<PositionViewModel>? positions;

        public PositionForm(IBaseService<Position> positionService)
        {
            _positionService = positionService;
            InitializeComponent();
        }

        private void FormToObject(Position position)
        {
            position.Name = txtName.Text;
            position.Acronym = txtAcronym.Text;
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var position = _positionService.GetById<Position>(id);
                    FormToObject(position);
                    _positionService.Update<Position, Position, PositionValidator>(position);
                }
                else
                {
                    var position = new Position();
                    FormToObject(position);
                    _positionService.Add<Position, Position, PositionValidator>(position);
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
                _positionService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Admin Teams", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            positions = _positionService.Get<PositionViewModel>().ToList();
            dataGridViewList.DataSource = positions;
            dataGridViewList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            if (record == null) return;
            txtId.Text = record.Cells["Id"].Value.ToString();
            txtName.Text = record.Cells["Name"].Value.ToString();
            txtAcronym.Text = record.Cells["Acronym"].Value.ToString();
        }
    }
}