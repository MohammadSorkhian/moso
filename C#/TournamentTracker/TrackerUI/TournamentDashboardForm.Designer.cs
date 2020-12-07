
namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.TournamentDashboardLabel = new System.Windows.Forms.Label();
            this.LoadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.LoadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.loadTournamnetButton = new System.Windows.Forms.Button();
            this.CreateTournamnetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TournamentDashboardLabel
            // 
            this.TournamentDashboardLabel.AutoSize = true;
            this.TournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentDashboardLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.TournamentDashboardLabel.Location = new System.Drawing.Point(116, 40);
            this.TournamentDashboardLabel.Name = "TournamentDashboardLabel";
            this.TournamentDashboardLabel.Size = new System.Drawing.Size(307, 38);
            this.TournamentDashboardLabel.TabIndex = 26;
            this.TournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // LoadExistingTournamentLabel
            // 
            this.LoadExistingTournamentLabel.AutoSize = true;
            this.LoadExistingTournamentLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.LoadExistingTournamentLabel.Location = new System.Drawing.Point(122, 150);
            this.LoadExistingTournamentLabel.Name = "LoadExistingTournamentLabel";
            this.LoadExistingTournamentLabel.Size = new System.Drawing.Size(290, 32);
            this.LoadExistingTournamentLabel.TabIndex = 24;
            this.LoadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // LoadExistingTournamentDropDown
            // 
            this.LoadExistingTournamentDropDown.FormattingEnabled = true;
            this.LoadExistingTournamentDropDown.Location = new System.Drawing.Point(106, 201);
            this.LoadExistingTournamentDropDown.Name = "LoadExistingTournamentDropDown";
            this.LoadExistingTournamentDropDown.Size = new System.Drawing.Size(316, 39);
            this.LoadExistingTournamentDropDown.TabIndex = 27;
            // 
            // loadTournamnetButton
            // 
            this.loadTournamnetButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTournamnetButton.FlatAppearance.BorderSize = 2;
            this.loadTournamnetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTournamnetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadTournamnetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamnetButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTournamnetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.loadTournamnetButton.Location = new System.Drawing.Point(112, 298);
            this.loadTournamnetButton.Name = "loadTournamnetButton";
            this.loadTournamnetButton.Size = new System.Drawing.Size(305, 56);
            this.loadTournamnetButton.TabIndex = 32;
            this.loadTournamnetButton.Text = "Load Tournamnet";
            this.loadTournamnetButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamnetButton
            // 
            this.CreateTournamnetButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamnetButton.FlatAppearance.BorderSize = 2;
            this.CreateTournamnetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamnetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTournamnetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamnetButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamnetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTournamnetButton.Location = new System.Drawing.Point(112, 399);
            this.CreateTournamnetButton.Name = "CreateTournamnetButton";
            this.CreateTournamnetButton.Size = new System.Drawing.Size(305, 56);
            this.CreateTournamnetButton.TabIndex = 33;
            this.CreateTournamnetButton.Text = "Create Tournament";
            this.CreateTournamnetButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 481);
            this.Controls.Add(this.CreateTournamnetButton);
            this.Controls.Add(this.loadTournamnetButton);
            this.Controls.Add(this.LoadExistingTournamentDropDown);
            this.Controls.Add(this.TournamentDashboardLabel);
            this.Controls.Add(this.LoadExistingTournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TournamentDashboardLabel;
        private System.Windows.Forms.Label LoadExistingTournamentLabel;
        private System.Windows.Forms.ComboBox LoadExistingTournamentDropDown;
        private System.Windows.Forms.Button loadTournamnetButton;
        private System.Windows.Forms.Button CreateTournamnetButton;
    }
}