using System.Drawing;
using System.Windows.Forms;

namespace IFSPStore.App.Base
{
    partial class BaseForm
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
            components = new System.ComponentModel.Container();
            imageList1 = new ImageList(components);
            tabControlRegister = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageRegister = new TabPage();
            panel1 = new Panel();
            ButtonSave = new ReaLTaiizor.Controls.MaterialButton();
            ButtonCancel = new ReaLTaiizor.Controls.MaterialButton();
            tabPageList = new TabPage();
            panel2 = new Panel();
            buttonDelete = new ReaLTaiizor.Controls.MaterialButton();
            buttonEdit = new ReaLTaiizor.Controls.MaterialButton();
            buttonNew = new ReaLTaiizor.Controls.MaterialButton();
            dataGridViewList = new DataGridView();
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            panel1.SuspendLayout();
            tabPageList.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // tabControlRegister
            // 
            tabControlRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlRegister.Controls.Add(tabPageRegister);
            tabControlRegister.Controls.Add(tabPageList);
            tabControlRegister.Depth = 0;
            tabControlRegister.ImageList = imageList1;
            tabControlRegister.Location = new Point(-3, 64);
            tabControlRegister.Margin = new Padding(3, 2, 3, 2);
            tabControlRegister.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlRegister.Multiline = true;
            tabControlRegister.Name = "tabControlRegister";
            tabControlRegister.SelectedIndex = 0;
            tabControlRegister.Size = new Size(704, 282);
            tabControlRegister.TabIndex = 0;
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(panel1);
            tabPageRegister.ImageIndex = 1;
            tabPageRegister.Location = new Point(4, 24);
            tabPageRegister.Margin = new Padding(3, 2, 3, 2);
            tabPageRegister.Name = "tabPageRegister";
            tabPageRegister.Padding = new Padding(3, 2, 3, 2);
            tabPageRegister.Size = new Size(696, 254);
            tabPageRegister.TabIndex = 0;
            tabPageRegister.Text = "Register";
            tabPageRegister.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(ButtonSave);
            panel1.Controls.Add(ButtonCancel);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 203);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(690, 49);
            panel1.TabIndex = 2;
            // 
            // ButtonSave
            // 
            ButtonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonSave.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonSave.Depth = 0;
            ButtonSave.HighEmphasis = true;
            ButtonSave.Icon = null;
            ButtonSave.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonSave.Location = new Point(533, 4);
            ButtonSave.Margin = new Padding(4, 4, 4, 4);
            ButtonSave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonSave.Name = "ButtonSave";
            ButtonSave.NoAccentTextColor = Color.Empty;
            ButtonSave.Size = new Size(64, 36);
            ButtonSave.TabIndex = 0;
            ButtonSave.Text = "Save";
            ButtonSave.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonSave.UseAccentColor = false;
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += btnSave_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonCancel.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonCancel.Depth = 0;
            ButtonCancel.HighEmphasis = true;
            ButtonCancel.Icon = null;
            ButtonCancel.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonCancel.Location = new Point(605, 4);
            ButtonCancel.Margin = new Padding(4, 4, 4, 4);
            ButtonCancel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.NoAccentTextColor = Color.Empty;
            ButtonCancel.Size = new Size(77, 36);
            ButtonCancel.TabIndex = 1;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonCancel.UseAccentColor = false;
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += btnCancel_Click;
            // 
            // tabPageList
            // 
            tabPageList.Controls.Add(panel2);
            tabPageList.Controls.Add(dataGridViewList);
            tabPageList.ImageIndex = 0;
            tabPageList.Location = new Point(4, 24);
            tabPageList.Margin = new Padding(3, 2, 3, 2);
            tabPageList.Name = "tabPageList";
            tabPageList.Padding = new Padding(3, 2, 3, 2);
            tabPageList.Size = new Size(696, 254);
            tabPageList.TabIndex = 1;
            tabPageList.Text = "List";
            tabPageList.UseVisualStyleBackColor = true;
            tabPageList.Enter += tabPageList_Enter;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonDelete);
            panel2.Controls.Add(buttonEdit);
            panel2.Controls.Add(buttonNew);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 193);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(690, 59);
            panel2.TabIndex = 4;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonDelete.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonDelete.Depth = 0;
            buttonDelete.HighEmphasis = true;
            buttonDelete.Icon = null;
            buttonDelete.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            buttonDelete.Location = new Point(608, 13);
            buttonDelete.Margin = new Padding(4, 4, 4, 4);
            buttonDelete.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            buttonDelete.Name = "buttonDelete";
            buttonDelete.NoAccentTextColor = Color.Empty;
            buttonDelete.Size = new Size(73, 36);
            buttonDelete.TabIndex = 0;
            buttonDelete.Text = "Delete";
            buttonDelete.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonDelete.UseAccentColor = false;
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += btnDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonEdit.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonEdit.Depth = 0;
            buttonEdit.HighEmphasis = true;
            buttonEdit.Icon = null;
            buttonEdit.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            buttonEdit.Location = new Point(537, 13);
            buttonEdit.Margin = new Padding(4, 4, 4, 4);
            buttonEdit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            buttonEdit.Name = "buttonEdit";
            buttonEdit.NoAccentTextColor = Color.Empty;
            buttonEdit.Size = new Size(64, 36);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Edit";
            buttonEdit.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonEdit.UseAccentColor = false;
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += btnEdit_Click;
            // 
            // buttonNew
            // 
            buttonNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonNew.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonNew.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonNew.Depth = 0;
            buttonNew.HighEmphasis = true;
            buttonNew.Icon = null;
            buttonNew.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            buttonNew.Location = new Point(465, 13);
            buttonNew.Margin = new Padding(4, 4, 4, 4);
            buttonNew.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            buttonNew.Name = "buttonNew";
            buttonNew.NoAccentTextColor = Color.Empty;
            buttonNew.Size = new Size(64, 36);
            buttonNew.TabIndex = 2;
            buttonNew.Text = "New";
            buttonNew.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonNew.UseAccentColor = false;
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += btnNew_Click;
            // 
            // dataGridViewList
            // 
            dataGridViewList.AllowUserToAddRows = false;
            dataGridViewList.AllowUserToDeleteRows = false;
            dataGridViewList.AllowUserToResizeColumns = false;
            dataGridViewList.AllowUserToResizeRows = false;
            dataGridViewList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewList.Location = new Point(5, 4);
            dataGridViewList.Margin = new Padding(3, 2, 3, 2);
            dataGridViewList.Name = "dataGridViewList";
            dataGridViewList.ReadOnly = true;
            dataGridViewList.RightToLeft = RightToLeft.No;
            dataGridViewList.RowHeadersWidth = 51;
            dataGridViewList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewList.Size = new Size(679, 185);
            dataGridViewList.TabIndex = 3;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 348);
            Controls.Add(tabControlRegister);
            DrawerTabControl = tabControlRegister;
            Margin = new Padding(3, 2, 3, 2);
            Name = "BaseForm";
            Padding = new Padding(3, 48, 3, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BaseForm";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageList.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialButton ButtonSave;
        private ReaLTaiizor.Controls.MaterialButton ButtonCancel;
        private ReaLTaiizor.Controls.MaterialButton buttonNew;
        private ReaLTaiizor.Controls.MaterialButton buttonEdit;
        private ReaLTaiizor.Controls.MaterialButton buttonDelete;
        protected ReaLTaiizor.Controls.MaterialTabControl tabControlRegister;
        protected TabPage tabPageList;
        protected DataGridView dataGridViewList;
        protected TabPage tabPageRegister;
        private Panel panel1;
        private Panel panel2;
    }
}