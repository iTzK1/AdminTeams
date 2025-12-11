using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace AdminTeams.App.Forms
{
    partial class InjuryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtDescription = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cmbPlayer = new ReaLTaiizor.Controls.MaterialComboBox();
            dtStart = new DateTimePicker();
            dtEnd = new DateTimePicker();
            lblStart = new Label();
            lblEnd = new Label();
            chkHasEnd = new CheckBox();

            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            SuspendLayout();

            // tabControlRegister
            tabControlRegister.Size = new Size(800, 350);

            // tabPageRegister
            tabPageRegister.Controls.Add(chkHasEnd);
            tabPageRegister.Controls.Add(lblEnd);
            tabPageRegister.Controls.Add(lblStart);
            tabPageRegister.Controls.Add(dtEnd);
            tabPageRegister.Controls.Add(dtStart);
            tabPageRegister.Controls.Add(cmbPlayer);
            tabPageRegister.Controls.Add(txtId);
            tabPageRegister.Controls.Add(txtDescription);
            tabPageRegister.Size = new Size(792, 322);

            // txtDescription
            txtDescription.Hint = "Description / Injury Type";
            txtDescription.Location = new Point(18, 22);
            txtDescription.Size = new Size(400, 48);
            txtDescription.Name = "txtDescription";

            // txtId (Hidden)
            txtId.Hint = "Id";
            txtId.Location = new Point(430, 22);
            txtId.Size = new Size(80, 48);
            txtId.ReadOnly = true;
            txtId.Visible = false;

            // cmbPlayer
            cmbPlayer.Hint = "Select Player";
            cmbPlayer.Location = new Point(18, 90);
            cmbPlayer.Size = new Size(400, 49);
            cmbPlayer.StartIndex = 0;

            // Date Pickers Labels
            lblStart.AutoSize = true;
            lblStart.Location = new Point(18, 160);
            lblStart.Text = "Start Date:";

            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(250, 160);
            lblEnd.Text = "End Date:";

            // dtStart
            dtStart.Format = DateTimePickerFormat.Short;
            dtStart.Location = new Point(90, 155);
            dtStart.Size = new Size(120, 23);

            // dtEnd
            dtEnd.Format = DateTimePickerFormat.Short;
            dtEnd.Location = new Point(320, 155);
            dtEnd.Size = new Size(120, 23);
            dtEnd.Enabled = false;

            // chkHasEnd
            chkHasEnd.AutoSize = true;
            chkHasEnd.Location = new Point(450, 158);
            chkHasEnd.Text = "Recovered?";
            chkHasEnd.CheckedChanged += (s, e) => { dtEnd.Enabled = chkHasEnd.Checked; };

            // InjuryForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 450);
            Name = "InjuryForm";
            Text = "Injury Management";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            tabPageRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescription;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cmbPlayer;
        private DateTimePicker dtStart;
        private DateTimePicker dtEnd;
        private Label lblStart;
        private Label lblEnd;
        private CheckBox chkHasEnd;
    }
}