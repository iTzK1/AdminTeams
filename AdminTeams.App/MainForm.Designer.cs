namespace AdminTeams.App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelTeams = new System.Windows.Forms.Panel();
            lblTitleTeams = new ReaLTaiizor.Controls.MaterialLabel();
            btnTeams = new ReaLTaiizor.Controls.MaterialButton();
            panelPositions = new System.Windows.Forms.Panel();
            lblTitlePositions = new ReaLTaiizor.Controls.MaterialLabel();
            btnPositions = new ReaLTaiizor.Controls.MaterialButton();
            panelPlayers = new System.Windows.Forms.Panel();
            lblTitlePlayers = new ReaLTaiizor.Controls.MaterialLabel();
            btnPlayers = new ReaLTaiizor.Controls.MaterialButton();
            panelInjuries = new System.Windows.Forms.Panel();
            lblTitleInjuries = new ReaLTaiizor.Controls.MaterialLabel();
            btnInjuries = new ReaLTaiizor.Controls.MaterialButton();
            panelTeams.SuspendLayout();
            panelPositions.SuspendLayout();
            panelPlayers.SuspendLayout();
            panelInjuries.SuspendLayout();
            SuspendLayout();
            // 
            // panelTeams
            // 
            panelTeams.BackColor = System.Drawing.Color.White;
            panelTeams.Controls.Add(lblTitleTeams);
            panelTeams.Controls.Add(btnTeams);
            panelTeams.Location = new System.Drawing.Point(60, 100);
            panelTeams.Name = "panelTeams";
            panelTeams.Size = new System.Drawing.Size(300, 140);
            panelTeams.TabIndex = 0;
            // 
            // lblTitleTeams
            // 
            lblTitleTeams.AutoSize = true;
            lblTitleTeams.Depth = 0;
            lblTitleTeams.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            lblTitleTeams.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            lblTitleTeams.Location = new System.Drawing.Point(17, 20);
            lblTitleTeams.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblTitleTeams.Name = "lblTitleTeams";
            lblTitleTeams.Size = new System.Drawing.Size(71, 29);
            lblTitleTeams.TabIndex = 1;
            lblTitleTeams.Text = "TIMES";
            // 
            // btnTeams
            // 
            btnTeams.AutoSize = false;
            btnTeams.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnTeams.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnTeams.Depth = 0;
            btnTeams.HighEmphasis = true;
            btnTeams.Icon = null;
            btnTeams.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnTeams.Location = new System.Drawing.Point(22, 70);
            btnTeams.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnTeams.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnTeams.Name = "btnTeams";
            btnTeams.NoAccentTextColor = System.Drawing.Color.Empty;
            btnTeams.Size = new System.Drawing.Size(250, 45);
            btnTeams.TabIndex = 0;
            btnTeams.Text = "Gerenciar Times";
            btnTeams.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTeams.UseAccentColor = false;
            btnTeams.UseVisualStyleBackColor = true;
            btnTeams.Click += btnTeams_Click;
            // 
            // panelPositions
            // 
            panelPositions.BackColor = System.Drawing.Color.White;
            panelPositions.Controls.Add(lblTitlePositions);
            panelPositions.Controls.Add(btnPositions);
            panelPositions.Location = new System.Drawing.Point(400, 100);
            panelPositions.Name = "panelPositions";
            panelPositions.Size = new System.Drawing.Size(300, 140);
            panelPositions.TabIndex = 1;
            // 
            // lblTitlePositions
            // 
            lblTitlePositions.AutoSize = true;
            lblTitlePositions.Depth = 0;
            lblTitlePositions.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            lblTitlePositions.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            lblTitlePositions.Location = new System.Drawing.Point(17, 20);
            lblTitlePositions.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblTitlePositions.Name = "lblTitlePositions";
            lblTitlePositions.Size = new System.Drawing.Size(115, 29);
            lblTitlePositions.TabIndex = 1;
            lblTitlePositions.Text = "POSIÇÕES";
            // 
            // btnPositions
            // 
            btnPositions.AutoSize = false;
            btnPositions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnPositions.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPositions.Depth = 0;
            btnPositions.HighEmphasis = true;
            btnPositions.Icon = null;
            btnPositions.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnPositions.Location = new System.Drawing.Point(22, 70);
            btnPositions.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnPositions.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnPositions.Name = "btnPositions";
            btnPositions.NoAccentTextColor = System.Drawing.Color.Empty;
            btnPositions.Size = new System.Drawing.Size(250, 45);
            btnPositions.TabIndex = 0;
            btnPositions.Text = "Gerenciar Posições";
            btnPositions.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPositions.UseAccentColor = false;
            btnPositions.UseVisualStyleBackColor = true;
            btnPositions.Click += btnPositions_Click;
            // 
            // panelPlayers
            // 
            panelPlayers.BackColor = System.Drawing.Color.White;
            panelPlayers.Controls.Add(lblTitlePlayers);
            panelPlayers.Controls.Add(btnPlayers);
            panelPlayers.Location = new System.Drawing.Point(60, 260);
            panelPlayers.Name = "panelPlayers";
            panelPlayers.Size = new System.Drawing.Size(300, 140);
            panelPlayers.TabIndex = 2;
            // 
            // lblTitlePlayers
            // 
            lblTitlePlayers.AutoSize = true;
            lblTitlePlayers.Depth = 0;
            lblTitlePlayers.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            lblTitlePlayers.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            lblTitlePlayers.Location = new System.Drawing.Point(17, 20);
            lblTitlePlayers.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblTitlePlayers.Name = "lblTitlePlayers";
            lblTitlePlayers.Size = new System.Drawing.Size(139, 29);
            lblTitlePlayers.TabIndex = 1;
            lblTitlePlayers.Text = "JOGADORES";
            // 
            // btnPlayers
            // 
            btnPlayers.AutoSize = false;
            btnPlayers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnPlayers.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPlayers.Depth = 0;
            btnPlayers.HighEmphasis = true;
            btnPlayers.Icon = null;
            btnPlayers.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnPlayers.Location = new System.Drawing.Point(22, 70);
            btnPlayers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnPlayers.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnPlayers.Name = "btnPlayers";
            btnPlayers.NoAccentTextColor = System.Drawing.Color.Empty;
            btnPlayers.Size = new System.Drawing.Size(250, 45);
            btnPlayers.TabIndex = 0;
            btnPlayers.Text = "Gerenciar Jogadores";
            btnPlayers.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPlayers.UseAccentColor = false;
            btnPlayers.UseVisualStyleBackColor = true;
            btnPlayers.Click += btnPlayers_Click;
            // 
            // panelInjuries
            // 
            panelInjuries.BackColor = System.Drawing.Color.White;
            panelInjuries.Controls.Add(lblTitleInjuries);
            panelInjuries.Controls.Add(btnInjuries);
            panelInjuries.Location = new System.Drawing.Point(400, 260);
            panelInjuries.Name = "panelInjuries";
            panelInjuries.Size = new System.Drawing.Size(300, 140);
            panelInjuries.TabIndex = 3;
            // 
            // lblTitleInjuries
            // 
            lblTitleInjuries.AutoSize = true;
            lblTitleInjuries.Depth = 0;
            lblTitleInjuries.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            lblTitleInjuries.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            lblTitleInjuries.Location = new System.Drawing.Point(17, 20);
            lblTitleInjuries.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblTitleInjuries.Name = "lblTitleInjuries";
            lblTitleInjuries.Size = new System.Drawing.Size(87, 29);
            lblTitleInjuries.TabIndex = 1;
            lblTitleInjuries.Text = "LESÕES";
            // 
            // btnInjuries
            // 
            btnInjuries.AutoSize = false;
            btnInjuries.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnInjuries.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnInjuries.Depth = 0;
            btnInjuries.HighEmphasis = true;
            btnInjuries.Icon = null;
            btnInjuries.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnInjuries.Location = new System.Drawing.Point(22, 70);
            btnInjuries.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnInjuries.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnInjuries.Name = "btnInjuries";
            btnInjuries.NoAccentTextColor = System.Drawing.Color.Empty;
            btnInjuries.Size = new System.Drawing.Size(250, 45);
            btnInjuries.TabIndex = 0;
            btnInjuries.Text = "Gerenciar Lesões";
            btnInjuries.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnInjuries.UseAccentColor = false;
            btnInjuries.UseVisualStyleBackColor = true;
            btnInjuries.Click += btnInjuries_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.unnamed;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panelInjuries);
            Controls.Add(panelPlayers);
            Controls.Add(panelPositions);
            Controls.Add(panelTeams);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Painel de Controle - AdminTeams";
            panelTeams.ResumeLayout(false);
            panelTeams.PerformLayout();
            panelPositions.ResumeLayout(false);
            panelPositions.PerformLayout();
            panelPlayers.ResumeLayout(false);
            panelPlayers.PerformLayout();
            panelInjuries.ResumeLayout(false);
            panelInjuries.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTeams;
        private ReaLTaiizor.Controls.MaterialLabel lblTitleTeams;
        private ReaLTaiizor.Controls.MaterialButton btnTeams;

        private System.Windows.Forms.Panel panelPositions;
        private ReaLTaiizor.Controls.MaterialLabel lblTitlePositions;
        private ReaLTaiizor.Controls.MaterialButton btnPositions;

        private System.Windows.Forms.Panel panelPlayers;
        private ReaLTaiizor.Controls.MaterialLabel lblTitlePlayers;
        private ReaLTaiizor.Controls.MaterialButton btnPlayers;

        private System.Windows.Forms.Panel panelInjuries;
        private ReaLTaiizor.Controls.MaterialLabel lblTitleInjuries;
        private ReaLTaiizor.Controls.MaterialButton btnInjuries;
    }
}