
namespace TrackerUI
{
    partial class TournamentViewer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.MatchupListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Team1ScoreLabel = new System.Windows.Forms.Label();
            this.Team1ScoreText = new System.Windows.Forms.TextBox();
            this.Team2ScoreText = new System.Windows.Forms.TextBox();
            this.Team2ScoreLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.VersusLabel = new System.Windows.Forms.Label();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tournament : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Location = new System.Drawing.Point(217, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "<none>";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Location = new System.Drawing.Point(24, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Round";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(224, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 45);
            this.comboBox1.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.checkBox1.Location = new System.Drawing.Point(224, 131);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(222, 42);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Unplayed Only";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MatchupListBox
            // 
            this.MatchupListBox.FormattingEnabled = true;
            this.MatchupListBox.ItemHeight = 37;
            this.MatchupListBox.Location = new System.Drawing.Point(46, 197);
            this.MatchupListBox.Name = "MatchupListBox";
            this.MatchupListBox.Size = new System.Drawing.Size(377, 189);
            this.MatchupListBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label4.Location = new System.Drawing.Point(447, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "<Team 1>";
            // 
            // Team1ScoreLabel
            // 
            this.Team1ScoreLabel.AutoSize = true;
            this.Team1ScoreLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.Team1ScoreLabel.Location = new System.Drawing.Point(447, 247);
            this.Team1ScoreLabel.Name = "Team1ScoreLabel";
            this.Team1ScoreLabel.Size = new System.Drawing.Size(86, 38);
            this.Team1ScoreLabel.TabIndex = 6;
            this.Team1ScoreLabel.Text = "Score";
            this.Team1ScoreLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // Team1ScoreText
            // 
            this.Team1ScoreText.Location = new System.Drawing.Point(539, 242);
            this.Team1ScoreText.Name = "Team1ScoreText";
            this.Team1ScoreText.Size = new System.Drawing.Size(100, 43);
            this.Team1ScoreText.TabIndex = 7;
            // 
            // Team2ScoreText
            // 
            this.Team2ScoreText.Location = new System.Drawing.Point(539, 371);
            this.Team2ScoreText.Name = "Team2ScoreText";
            this.Team2ScoreText.Size = new System.Drawing.Size(100, 43);
            this.Team2ScoreText.TabIndex = 10;
            // 
            // Team2ScoreLabel
            // 
            this.Team2ScoreLabel.AutoSize = true;
            this.Team2ScoreLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.Team2ScoreLabel.Location = new System.Drawing.Point(447, 376);
            this.Team2ScoreLabel.Name = "Team2ScoreLabel";
            this.Team2ScoreLabel.Size = new System.Drawing.Size(86, 38);
            this.Team2ScoreLabel.TabIndex = 8;
            this.Team2ScoreLabel.Text = "Score";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label7.Location = new System.Drawing.Point(447, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 38);
            this.label7.TabIndex = 9;
            this.label7.Text = "<Team 2>";
            // 
            // VersusLabel
            // 
            this.VersusLabel.AutoSize = true;
            this.VersusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersusLabel.ForeColor = System.Drawing.Color.CadetBlue;
            this.VersusLabel.Location = new System.Drawing.Point(604, 302);
            this.VersusLabel.Name = "VersusLabel";
            this.VersusLabel.Size = new System.Drawing.Size(35, 28);
            this.VersusLabel.TabIndex = 11;
            this.VersusLabel.Text = "VS";
            // 
            // ScoreButton
            // 
            this.ScoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ScoreButton.FlatAppearance.BorderSize = 2;
            this.ScoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ScoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ScoreButton.Location = new System.Drawing.Point(679, 302);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(81, 41);
            this.ScoreButton.TabIndex = 12;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 441);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.VersusLabel);
            this.Controls.Add(this.Team2ScoreText);
            this.Controls.Add(this.Team2ScoreLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Team1ScoreText);
            this.Controls.Add(this.Team1ScoreLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MatchupListBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewer";
            this.Text = "TournamentViewer";
            this.Load += new System.EventHandler(this.TournamentViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox MatchupListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Team1ScoreLabel;
        private System.Windows.Forms.TextBox Team1ScoreText;
        private System.Windows.Forms.TextBox Team2ScoreText;
        private System.Windows.Forms.Label Team2ScoreLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label VersusLabel;
        private System.Windows.Forms.Button ScoreButton;
    }
}

