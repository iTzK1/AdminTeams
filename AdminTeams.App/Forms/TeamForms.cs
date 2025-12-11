using AdminTeams.App.Base;
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
    public partial class TeamForm : Base.BaseForm
    {
        private readonly IBaseService<Team> _teamService;
        private List<TeamViewModel>? teams;


        private void FormToObject(Team team)
        {
            team.Name = txtName.Text;
            team.Category = txtCategory.Text;
        }


        public TeamForm(IBaseService<Team> teamService)
        {
            _teamService = teamService;
            InitializeComponent();
        }


        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var team = _teamService.GetById<Team>(id);
                    FormToObject(team);
                    team = _teamService.Update<Team, Team, TeamValidator>(team);
                }
                else
                {
                    var team = new Team();
                    FormToObject(team);
                    _teamService.Add<Team, Team, TeamValidator>(team);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                @"Admin Teams", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _teamService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                @"Admin Teams", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            teams = _teamService.Get<TeamViewModel>().ToList();
            dataGridViewList.DataSource = teams;
            dataGridViewList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record.Cells["Id"].Value.ToString();
            txtName.Text = record.Cells["Name"].Value.ToString();
            txtCategory.Text = record.Cells["Category"].Value.ToString();

        }

        
    }
}
