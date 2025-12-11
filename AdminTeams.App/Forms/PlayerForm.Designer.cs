using System.Drawing;
using System.Windows.Forms;

namespace AdminTeams.App.Forms
{
    partial class PlayerForm
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
            txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtShirt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cmbTeam = new ReaLTaiizor.Controls.MaterialComboBox();
            cmbPosition = new ReaLTaiizor.Controls.MaterialComboBox();
            dtBirth = new DateTimePicker();
            lblDate = new Label();

            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            SuspendLayout();

            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(850, 400);

            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(lblDate);
            tabPageRegister.Controls.Add(dtBirth);
            tabPageRegister.Controls.Add(cmbPosition);
            tabPageRegister.Controls.Add(cmbTeam);
            tabPageRegister.Controls.Add(txtShirt);
            tabPageRegister.Controls.Add(txtId);
            tabPageRegister.Controls.Add(txtName);
            tabPageRegister.Size = new Size(842, 372);

            // 
            // txtName
            // 
            txtName.Hint = "Name";
            txtName.Location = new Point(18, 22);
            txtName.Size = new Size(400, 48);
            txtName.Name = "txtName";

            // 
            // txtShirt
            // 
            txtShirt.Hint = "Shirt Nº";
            txtShirt.Location = new Point(430, 22);
            txtShirt.Size = new Size(100, 48);
            txtShirt.Name = "txtShirt";
            txtShirt.UseSystemPasswordChar = false;

            // 
            // txtId
            // 
            txtId.Hint = "Id";
            txtId.Location = new Point(540, 22);
            txtId.Size = new Size(80, 48);
            txtId.ReadOnly = true;
            txtId.Name = "txtId";
            txtId.Visible = false;

            // 
            // cmbTeam
            // 
            cmbTeam.Hint = "Select Team";
            cmbTeam.Location = new Point(18, 90);
            cmbTeam.Size = new Size(300, 49);
            cmbTeam.Name = "cmbTeam";
            cmbTeam.StartIndex = 0;

            // 
            // cmbPosition
            // 
            cmbPosition.Hint = "Select Position";
            cmbPosition.Location = new Point(330, 90);
            cmbPosition.Size = new Size(300, 49);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.StartIndex = 0;

            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(18, 160);
            lblDate.Text = "Birth Date:";
            lblDate.Name = "lblDate";

            // 
            // dtBirth
            // 
            dtBirth.Format = DateTimePickerFormat.Short;
            dtBirth.Location = new Point(100, 155);
            dtBirth.Size = new Size(150, 23);
            dtBirth.Name = "dtBirth";

            // 
            // PlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 500);
            Name = "PlayerForm";
            Text = "Player Register";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            tabPageRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtShirt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cmbTeam;
        private ReaLTaiizor.Controls.MaterialComboBox cmbPosition;
        private DateTimePicker dtBirth;
        private Label lblDate;
    }
}