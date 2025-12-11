using AdminTeams.App.Models;
using AdminTeams.Domain.Base;
using AdminTeams.Domain.Entities;
using AdminTeams.Service.Validators;
using ReaLTaiizor.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AdminTeams.App.Forms
{
    public partial class InjuryForm : Base.BaseForm
    {
        private readonly IBaseService<Injury> _injuryService;
        private readonly IBaseService<Player> _playerService;
        private List<InjuryViewModel>? injuries;

        public InjuryForm(IBaseService<Injury> injuryService, IBaseService<Player> playerService)
        {
            _injuryService = injuryService;
            _playerService = playerService;
            InitializeComponent();
            LoadCombos();
        }

        private void LoadCombos()
        {
            var players = _playerService.Get<PlayerViewModel>().ToList();
            cmbPlayer.DataSource = players;
            cmbPlayer.DisplayMember = "Name";
            cmbPlayer.ValueMember = "Id";
            cmbPlayer.SelectedIndex = -1;
        }

        private void FormToObject(Injury injury)
        {
            injury.Description = txtDescription.Text;
            injury.StartDate = dtStart.Value;

            if (chkHasEnd.Checked)
                injury.EndDate = dtEnd.Value;
            else
                injury.EndDate = null;

            if (cmbPlayer.SelectedValue != null)
                injury.PlayerId = (int)cmbPlayer.SelectedValue;
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var injury = _injuryService.GetById<Injury>(id);
                    FormToObject(injury);
                    _injuryService.Update<Injury, Injury, InjuryValidator>(injury);
                }
                else
                {
                    var injury = new Injury();
                    FormToObject(injury);
                    _injuryService.Add<Injury, Injury, InjuryValidator>(injury);
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
                _injuryService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Admin Teams", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            // Inclui "Player" para exibir o nome no Grid
            injuries = _injuryService.Get<InjuryViewModel>(new List<string> { "Player" }).ToList();
            dataGridViewList.DataSource = injuries;
            dataGridViewList.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            if (record == null) return;

            int id = int.Parse(record.Cells["Id"].Value.ToString());
            var injury = _injuryService.GetById<Injury>(id);

            txtId.Text = injury.Id.ToString();
            txtDescription.Text = injury.Description;
            dtStart.Value = injury.StartDate;

            if (injury.EndDate.HasValue)
            {
                chkHasEnd.Checked = true;
                dtEnd.Value = injury.EndDate.Value;
            }
            else
            {
                chkHasEnd.Checked = false;
            }

            cmbPlayer.SelectedValue = injury.PlayerId;
        }
    }
}   