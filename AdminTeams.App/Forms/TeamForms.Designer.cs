using System.Drawing;
using System.Windows.Forms;

namespace AdminTeams.App.Forms
{
    partial class TeamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCategory = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Location = new Point(5, 64);
            tabControlRegister.Size = new Size(791, 248);
            // 
            // tabPageList
            // 
            tabPageList.Size = new Size(783, 220);
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(txtCategory);
            tabPageRegister.Controls.Add(txtId);
            tabPageRegister.Controls.Add(txtName);
            tabPageRegister.Size = new Size(783, 220);
            tabPageRegister.Controls.SetChildIndex(txtName, 0);
            tabPageRegister.Controls.SetChildIndex(txtId, 0);
            tabPageRegister.Controls.SetChildIndex(txtCategory, 0);
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.AutoCompleteMode = AutoCompleteMode.None;
            txtName.AutoCompleteSource = AutoCompleteSource.None;
            txtName.BackgroundImageLayout = ImageLayout.None;
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.Depth = 0;
            txtName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.HideSelection = true;
            txtName.Hint = "Name";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(18, 22);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.MaxLength = 32767;
            txtName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PrefixSuffixText = null;
            txtName.ReadOnly = false;
            txtName.RightToLeft = RightToLeft.No;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new Size(273, 48);
            txtName.TabIndex = 2;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(383, 22);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(273, 48);
            txtId.TabIndex = 3;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtCategory
            // 
            txtCategory.AnimateReadOnly = false;
            txtCategory.AutoCompleteMode = AutoCompleteMode.None;
            txtCategory.AutoCompleteSource = AutoCompleteSource.None;
            txtCategory.BackgroundImageLayout = ImageLayout.None;
            txtCategory.CharacterCasing = CharacterCasing.Normal;
            txtCategory.Depth = 0;
            txtCategory.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCategory.HideSelection = true;
            txtCategory.Hint = "Category";
            txtCategory.LeadingIcon = null;
            txtCategory.Location = new Point(18, 95);
            txtCategory.Margin = new Padding(3, 2, 3, 2);
            txtCategory.MaxLength = 32767;
            txtCategory.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCategory.Name = "txtCategory";
            txtCategory.PasswordChar = '\0';
            txtCategory.PrefixSuffixText = null;
            txtCategory.ReadOnly = false;
            txtCategory.RightToLeft = RightToLeft.No;
            txtCategory.SelectedText = "";
            txtCategory.SelectionLength = 0;
            txtCategory.SelectionStart = 0;
            txtCategory.ShortcutsEnabled = true;
            txtCategory.Size = new Size(273, 48);
            txtCategory.TabIndex = 4;
            txtCategory.TabStop = false;
            txtCategory.TextAlign = HorizontalAlignment.Left;
            txtCategory.TrailingIcon = null;
            txtCategory.UseSystemPasswordChar = false;
            // 
            // TeamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 316);
            Location = new Point(0, 0);
            Name = "TeamForm";
            Padding = new Padding(3, 36, 3, 2);
            Text = "Team Register";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCategory;
    }
}