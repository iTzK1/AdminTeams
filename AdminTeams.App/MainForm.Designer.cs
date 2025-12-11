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
            btnTeams = new ReaLTaiizor.Controls.MaterialButton();
            btnPositions = new ReaLTaiizor.Controls.MaterialButton();
            btnPlayers = new ReaLTaiizor.Controls.MaterialButton();
            btnInjuries = new ReaLTaiizor.Controls.MaterialButton();
            SuspendLayout();
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
            btnTeams.Location = new System.Drawing.Point(283, 94);
            btnTeams.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnTeams.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnTeams.Name = "btnTeams";
            btnTeams.NoAccentTextColor = System.Drawing.Color.Empty;
            btnTeams.Size = new System.Drawing.Size(200, 50);
            btnTeams.TabIndex = 0;
            btnTeams.Text = "Gerenciar Times";
            btnTeams.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTeams.UseAccentColor = false;
            btnTeams.UseVisualStyleBackColor = true;
            btnTeams.Click += btnTeams_Click;
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
            btnPositions.Location = new System.Drawing.Point(283, 173);
            btnPositions.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnPositions.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnPositions.Name = "btnPositions";
            btnPositions.NoAccentTextColor = System.Drawing.Color.Empty;
            btnPositions.Size = new System.Drawing.Size(200, 50);
            btnPositions.TabIndex = 1;
            btnPositions.Text = "Gerenciar Posições";
            btnPositions.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPositions.UseAccentColor = false;
            btnPositions.UseVisualStyleBackColor = true;
            btnPositions.Click += btnPositions_Click;
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
            btnPlayers.Location = new System.Drawing.Point(283, 253);
            btnPlayers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnPlayers.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnPlayers.Name = "btnPlayers";
            btnPlayers.NoAccentTextColor = System.Drawing.Color.Empty;
            btnPlayers.Size = new System.Drawing.Size(200, 50);
            btnPlayers.TabIndex = 2;
            btnPlayers.Text = "Gerenciar Jogadores";
            btnPlayers.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPlayers.UseAccentColor = false;
            btnPlayers.UseVisualStyleBackColor = true;
            btnPlayers.Click += btnPlayers_Click;
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
            btnInjuries.Location = new System.Drawing.Point(283, 335);
            btnInjuries.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnInjuries.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnInjuries.Name = "btnInjuries";
            btnInjuries.NoAccentTextColor = System.Drawing.Color.Empty;
            btnInjuries.Size = new System.Drawing.Size(200, 50);
            btnInjuries.TabIndex = 3;
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
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnInjuries);
            Controls.Add(btnPlayers);
            Controls.Add(btnPositions);
            Controls.Add(btnTeams);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "S";
            ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialButton btnTeams;
        private ReaLTaiizor.Controls.MaterialButton btnPositions;
        private ReaLTaiizor.Controls.MaterialButton btnPlayers;
        private ReaLTaiizor.Controls.MaterialButton btnInjuries;
    }
}