
namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.CellPhoneText = new System.Windows.Forms.TextBox();
            this.CellphoneLabel = new System.Windows.Forms.Label();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.TeamMemberListBox = new System.Windows.Forms.ListBox();
            this.DeleteMemberButton = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddTeamButton.FlatAppearance.BorderSize = 2;
            this.AddTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AddTeamButton.Location = new System.Drawing.Point(128, 271);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(139, 41);
            this.AddTeamButton.TabIndex = 19;
            this.AddTeamButton.Text = "Add Member";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(42, 209);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(316, 39);
            this.SelectTeamDropDown.TabIndex = 17;
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.SelectTeamLabel.Location = new System.Drawing.Point(36, 174);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(241, 32);
            this.SelectTeamLabel.TabIndex = 16;
            this.SelectTeamLabel.Text = "Select Team Member";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 38);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(35, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Team Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(35, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 38);
            this.label2.TabIndex = 20;
            this.label2.Text = "Create Team";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreateMemberButton);
            this.groupBox1.Controls.Add(this.CellPhoneText);
            this.groupBox1.Controls.Add(this.CellphoneLabel);
            this.groupBox1.Controls.Add(this.EmailText);
            this.groupBox1.Controls.Add(this.EmailLabel);
            this.groupBox1.Controls.Add(this.LastNameText);
            this.groupBox1.Controls.Add(this.LastNameLabel);
            this.groupBox1.Controls.Add(this.FirstNameText);
            this.groupBox1.Controls.Add(this.FirstNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(42, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 298);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Member";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(128, 41);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(184, 38);
            this.FirstNameText.TabIndex = 19;
            this.FirstNameText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.FirstNameLabel.Location = new System.Drawing.Point(0, 44);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(130, 32);
            this.FirstNameLabel.TabIndex = 18;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(128, 87);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(184, 38);
            this.LastNameText.TabIndex = 21;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.LastNameLabel.Location = new System.Drawing.Point(3, 90);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(127, 32);
            this.LastNameLabel.TabIndex = 20;
            this.LastNameLabel.Text = "Last Name";
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(128, 135);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(184, 38);
            this.EmailText.TabIndex = 23;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.EmailLabel.Location = new System.Drawing.Point(3, 138);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(72, 32);
            this.EmailLabel.TabIndex = 22;
            this.EmailLabel.Text = "Email";
            // 
            // CellPhoneText
            // 
            this.CellPhoneText.Location = new System.Drawing.Point(128, 179);
            this.CellPhoneText.Name = "CellPhoneText";
            this.CellPhoneText.Size = new System.Drawing.Size(184, 38);
            this.CellPhoneText.TabIndex = 25;
            // 
            // CellphoneLabel
            // 
            this.CellphoneLabel.AutoSize = true;
            this.CellphoneLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.CellphoneLabel.Location = new System.Drawing.Point(3, 186);
            this.CellphoneLabel.Name = "CellphoneLabel";
            this.CellphoneLabel.Size = new System.Drawing.Size(123, 32);
            this.CellphoneLabel.TabIndex = 24;
            this.CellphoneLabel.Text = "CellPhone";
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateMemberButton.FlatAppearance.BorderSize = 2;
            this.CreateMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateMemberButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateMemberButton.Location = new System.Drawing.Point(81, 239);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(156, 41);
            this.CreateMemberButton.TabIndex = 22;
            this.CreateMemberButton.Text = "Create Member";
            this.CreateMemberButton.UseVisualStyleBackColor = true;
            // 
            // TeamMemberListBox
            // 
            this.TeamMemberListBox.FormattingEnabled = true;
            this.TeamMemberListBox.ItemHeight = 31;
            this.TeamMemberListBox.Location = new System.Drawing.Point(414, 120);
            this.TeamMemberListBox.Name = "TeamMemberListBox";
            this.TeamMemberListBox.Size = new System.Drawing.Size(377, 531);
            this.TeamMemberListBox.TabIndex = 22;
            // 
            // DeleteMemberButton
            // 
            this.DeleteMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteMemberButton.FlatAppearance.BorderSize = 2;
            this.DeleteMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteMemberButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.DeleteMemberButton.Location = new System.Drawing.Point(797, 340);
            this.DeleteMemberButton.Name = "DeleteMemberButton";
            this.DeleteMemberButton.Size = new System.Drawing.Size(124, 70);
            this.DeleteMemberButton.TabIndex = 23;
            this.DeleteMemberButton.Text = "Delete Member";
            this.DeleteMemberButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTeamButton.FlatAppearance.BorderSize = 2;
            this.CreateTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTeamButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTeamButton.Location = new System.Drawing.Point(414, 727);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(231, 56);
            this.CreateTeamButton.TabIndex = 26;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 872);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.DeleteMemberButton);
            this.Controls.Add(this.TeamMemberListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTeamForm";
            this.Text = "CreateTeam";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTeamButton;
        private System.Windows.Forms.ComboBox SelectTeamDropDown;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox CellPhoneText;
        private System.Windows.Forms.Label CellphoneLabel;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button CreateMemberButton;
        private System.Windows.Forms.ListBox TeamMemberListBox;
        private System.Windows.Forms.Button DeleteMemberButton;
        private System.Windows.Forms.Button CreateTeamButton;
    }
}