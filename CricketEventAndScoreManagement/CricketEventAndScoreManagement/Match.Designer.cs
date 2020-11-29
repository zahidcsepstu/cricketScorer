namespace CricketEventAndScoreManagement
{
    partial class Match
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
            this.CreateamatchGroupbox = new System.Windows.Forms.GroupBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelVenue = new System.Windows.Forms.Label();
            this.labelOver = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTeamA = new System.Windows.Forms.Label();
            this.labelMatchName = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.MatchDate = new System.Windows.Forms.DateTimePicker();
            this.MatchVenue = new System.Windows.Forms.TextBox();
            this.MatchOver = new System.Windows.Forms.TextBox();
            this.TeamBCombo = new System.Windows.Forms.ComboBox();
            this.TeamACombo = new System.Windows.Forms.ComboBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.DeleteMatch = new System.Windows.Forms.Button();
            this.Continuematch = new System.Windows.Forms.Button();
            this.Selectamatchgroupbox = new System.Windows.Forms.GroupBox();
            this.MatchNameLabel = new System.Windows.Forms.Label();
            this.matchcombobox = new System.Windows.Forms.ComboBox();
            this.MatchListBtn = new System.Windows.Forms.Button();
            this.BattingComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerNameGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BowlerComboBox = new System.Windows.Forms.ComboBox();
            this.Batting2ComboBox = new System.Windows.Forms.ComboBox();
            this.Batting1ComboBox = new System.Windows.Forms.ComboBox();
            this.Bowler = new System.Windows.Forms.Label();
            this.Batsman2 = new System.Windows.Forms.Label();
            this.Batsman1 = new System.Windows.Forms.Label();
            this.TossGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FieldingComboBox = new System.Windows.Forms.ComboBox();
            this.CreateamatchGroupbox.SuspendLayout();
            this.Selectamatchgroupbox.SuspendLayout();
            this.PlayerNameGroupBox.SuspendLayout();
            this.TossGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateamatchGroupbox
            // 
            this.CreateamatchGroupbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CreateamatchGroupbox.Controls.Add(this.labelDate);
            this.CreateamatchGroupbox.Controls.Add(this.labelVenue);
            this.CreateamatchGroupbox.Controls.Add(this.labelOver);
            this.CreateamatchGroupbox.Controls.Add(this.label3);
            this.CreateamatchGroupbox.Controls.Add(this.labelTeamA);
            this.CreateamatchGroupbox.Controls.Add(this.labelMatchName);
            this.CreateamatchGroupbox.Controls.Add(this.CreateButton);
            this.CreateamatchGroupbox.Controls.Add(this.MatchDate);
            this.CreateamatchGroupbox.Controls.Add(this.MatchVenue);
            this.CreateamatchGroupbox.Controls.Add(this.MatchOver);
            this.CreateamatchGroupbox.Controls.Add(this.TeamBCombo);
            this.CreateamatchGroupbox.Controls.Add(this.TeamACombo);
            this.CreateamatchGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateamatchGroupbox.Location = new System.Drawing.Point(35, 52);
            this.CreateamatchGroupbox.Name = "CreateamatchGroupbox";
            this.CreateamatchGroupbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CreateamatchGroupbox.Size = new System.Drawing.Size(243, 237);
            this.CreateamatchGroupbox.TabIndex = 0;
            this.CreateamatchGroupbox.TabStop = false;
            this.CreateamatchGroupbox.Text = "Create a Match";
            this.CreateamatchGroupbox.Enter += new System.EventHandler(this.CreateamatchGroupbox_Enter);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(6, 164);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 12;
            this.labelDate.Text = "Date";
            // 
            // labelVenue
            // 
            this.labelVenue.AutoSize = true;
            this.labelVenue.Location = new System.Drawing.Point(6, 138);
            this.labelVenue.Name = "labelVenue";
            this.labelVenue.Size = new System.Drawing.Size(38, 13);
            this.labelVenue.TabIndex = 11;
            this.labelVenue.Text = "Venue";
            // 
            // labelOver
            // 
            this.labelOver.AutoSize = true;
            this.labelOver.Location = new System.Drawing.Point(6, 111);
            this.labelOver.Name = "labelOver";
            this.labelOver.Size = new System.Drawing.Size(30, 13);
            this.labelOver.TabIndex = 10;
            this.labelOver.Text = "Over";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Team B";
            // 
            // labelTeamA
            // 
            this.labelTeamA.AutoSize = true;
            this.labelTeamA.Location = new System.Drawing.Point(6, 56);
            this.labelTeamA.Name = "labelTeamA";
            this.labelTeamA.Size = new System.Drawing.Size(44, 13);
            this.labelTeamA.TabIndex = 8;
            this.labelTeamA.Text = "Team A";
            // 
            // labelMatchName
            // 
            this.labelMatchName.AutoSize = true;
            this.labelMatchName.Location = new System.Drawing.Point(80, 27);
            this.labelMatchName.Name = "labelMatchName";
            this.labelMatchName.Size = new System.Drawing.Size(68, 13);
            this.labelMatchName.TabIndex = 7;
            this.labelMatchName.Text = "Match Name";
            // 
            // CreateButton
            // 
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Location = new System.Drawing.Point(162, 196);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 6;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // MatchDate
            // 
            this.MatchDate.CustomFormat = "MM-dd-yyyy";
            this.MatchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MatchDate.Location = new System.Drawing.Point(116, 164);
            this.MatchDate.Name = "MatchDate";
            this.MatchDate.Size = new System.Drawing.Size(121, 20);
            this.MatchDate.TabIndex = 5;
            // 
            // MatchVenue
            // 
            this.MatchVenue.Location = new System.Drawing.Point(116, 138);
            this.MatchVenue.Name = "MatchVenue";
            this.MatchVenue.Size = new System.Drawing.Size(121, 20);
            this.MatchVenue.TabIndex = 4;
            // 
            // MatchOver
            // 
            this.MatchOver.Location = new System.Drawing.Point(116, 111);
            this.MatchOver.Name = "MatchOver";
            this.MatchOver.Size = new System.Drawing.Size(121, 20);
            this.MatchOver.TabIndex = 3;
            // 
            // TeamBCombo
            // 
            this.TeamBCombo.FormattingEnabled = true;
            this.TeamBCombo.Location = new System.Drawing.Point(116, 83);
            this.TeamBCombo.Name = "TeamBCombo";
            this.TeamBCombo.Size = new System.Drawing.Size(121, 21);
            this.TeamBCombo.TabIndex = 1;
            this.TeamBCombo.SelectedIndexChanged += new System.EventHandler(this.TeamBCombo_SelectedIndexChanged);
            // 
            // TeamACombo
            // 
            this.TeamACombo.FormattingEnabled = true;
            this.TeamACombo.Location = new System.Drawing.Point(116, 56);
            this.TeamACombo.Name = "TeamACombo";
            this.TeamACombo.Size = new System.Drawing.Size(121, 21);
            this.TeamACombo.TabIndex = 0;
            this.TeamACombo.SelectedIndexChanged += new System.EventHandler(this.TeamACombo_SelectedIndexChanged);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(35, 13);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.Back_Click);
            // 
            // DeleteMatch
            // 
            this.DeleteMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteMatch.Location = new System.Drawing.Point(137, 105);
            this.DeleteMatch.Name = "DeleteMatch";
            this.DeleteMatch.Size = new System.Drawing.Size(75, 23);
            this.DeleteMatch.TabIndex = 2;
            this.DeleteMatch.Text = "Delete";
            this.DeleteMatch.UseVisualStyleBackColor = true;
            this.DeleteMatch.Click += new System.EventHandler(this.DeleteMatch_Click);
            // 
            // Continuematch
            // 
            this.Continuematch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Continuematch.Location = new System.Drawing.Point(15, 104);
            this.Continuematch.Name = "Continuematch";
            this.Continuematch.Size = new System.Drawing.Size(75, 23);
            this.Continuematch.TabIndex = 3;
            this.Continuematch.Text = "Continue";
            this.Continuematch.UseVisualStyleBackColor = true;
            this.Continuematch.Click += new System.EventHandler(this.Continuematch_Click);
            // 
            // Selectamatchgroupbox
            // 
            this.Selectamatchgroupbox.BackColor = System.Drawing.Color.DarkKhaki;
            this.Selectamatchgroupbox.Controls.Add(this.MatchNameLabel);
            this.Selectamatchgroupbox.Controls.Add(this.matchcombobox);
            this.Selectamatchgroupbox.Controls.Add(this.Continuematch);
            this.Selectamatchgroupbox.Controls.Add(this.DeleteMatch);
            this.Selectamatchgroupbox.Location = new System.Drawing.Point(298, 56);
            this.Selectamatchgroupbox.Name = "Selectamatchgroupbox";
            this.Selectamatchgroupbox.Size = new System.Drawing.Size(235, 154);
            this.Selectamatchgroupbox.TabIndex = 4;
            this.Selectamatchgroupbox.TabStop = false;
            this.Selectamatchgroupbox.Text = "Select a match";
            this.Selectamatchgroupbox.Visible = false;
            // 
            // MatchNameLabel
            // 
            this.MatchNameLabel.AutoSize = true;
            this.MatchNameLabel.Location = new System.Drawing.Point(75, 32);
            this.MatchNameLabel.Name = "MatchNameLabel";
            this.MatchNameLabel.Size = new System.Drawing.Size(68, 13);
            this.MatchNameLabel.TabIndex = 6;
            this.MatchNameLabel.Text = "Match Name";
            // 
            // matchcombobox
            // 
            this.matchcombobox.FormattingEnabled = true;
            this.matchcombobox.Location = new System.Drawing.Point(15, 62);
            this.matchcombobox.Name = "matchcombobox";
            this.matchcombobox.Size = new System.Drawing.Size(197, 21);
            this.matchcombobox.TabIndex = 5;
            this.matchcombobox.SelectedIndexChanged += new System.EventHandler(this.matchcombobox_SelectedIndexChanged);
            // 
            // MatchListBtn
            // 
            this.MatchListBtn.Location = new System.Drawing.Point(131, 13);
            this.MatchListBtn.Name = "MatchListBtn";
            this.MatchListBtn.Size = new System.Drawing.Size(75, 23);
            this.MatchListBtn.TabIndex = 5;
            this.MatchListBtn.Text = "Match List";
            this.MatchListBtn.UseVisualStyleBackColor = true;
            this.MatchListBtn.Click += new System.EventHandler(this.MatchListBtn_Click);
            // 
            // BattingComboBox
            // 
            this.BattingComboBox.FormattingEnabled = true;
            this.BattingComboBox.Location = new System.Drawing.Point(82, 29);
            this.BattingComboBox.Name = "BattingComboBox";
            this.BattingComboBox.Size = new System.Drawing.Size(121, 24);
            this.BattingComboBox.TabIndex = 6;
            this.BattingComboBox.SelectedIndexChanged += new System.EventHandler(this.BattingComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fielding";
            // 
            // PlayerNameGroupBox
            // 
            this.PlayerNameGroupBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PlayerNameGroupBox.Controls.Add(this.button1);
            this.PlayerNameGroupBox.Controls.Add(this.BowlerComboBox);
            this.PlayerNameGroupBox.Controls.Add(this.Batting2ComboBox);
            this.PlayerNameGroupBox.Controls.Add(this.Batting1ComboBox);
            this.PlayerNameGroupBox.Controls.Add(this.Bowler);
            this.PlayerNameGroupBox.Controls.Add(this.Batsman2);
            this.PlayerNameGroupBox.Controls.Add(this.Batsman1);
            this.PlayerNameGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayerNameGroupBox.Location = new System.Drawing.Point(565, 145);
            this.PlayerNameGroupBox.Name = "PlayerNameGroupBox";
            this.PlayerNameGroupBox.Size = new System.Drawing.Size(219, 166);
            this.PlayerNameGroupBox.TabIndex = 8;
            this.PlayerNameGroupBox.TabStop = false;
            this.PlayerNameGroupBox.Text = "Enter Name";
            this.PlayerNameGroupBox.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(130, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BowlerComboBox
            // 
            this.BowlerComboBox.FormattingEnabled = true;
            this.BowlerComboBox.Location = new System.Drawing.Point(84, 86);
            this.BowlerComboBox.Name = "BowlerComboBox";
            this.BowlerComboBox.Size = new System.Drawing.Size(121, 21);
            this.BowlerComboBox.TabIndex = 5;
            this.BowlerComboBox.SelectedIndexChanged += new System.EventHandler(this.BowlerComboBox_SelectedIndexChanged);
            // 
            // Batting2ComboBox
            // 
            this.Batting2ComboBox.FormattingEnabled = true;
            this.Batting2ComboBox.Location = new System.Drawing.Point(84, 58);
            this.Batting2ComboBox.Name = "Batting2ComboBox";
            this.Batting2ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Batting2ComboBox.TabIndex = 4;
            this.Batting2ComboBox.SelectedIndexChanged += new System.EventHandler(this.Batting2ComboBox_SelectedIndexChanged);
            // 
            // Batting1ComboBox
            // 
            this.Batting1ComboBox.FormattingEnabled = true;
            this.Batting1ComboBox.Location = new System.Drawing.Point(82, 22);
            this.Batting1ComboBox.Name = "Batting1ComboBox";
            this.Batting1ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Batting1ComboBox.TabIndex = 3;
            this.Batting1ComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Bowler
            // 
            this.Bowler.AutoSize = true;
            this.Bowler.Location = new System.Drawing.Point(7, 89);
            this.Bowler.Name = "Bowler";
            this.Bowler.Size = new System.Drawing.Size(39, 13);
            this.Bowler.TabIndex = 2;
            this.Bowler.Text = "Bowler";
            // 
            // Batsman2
            // 
            this.Batsman2.AutoSize = true;
            this.Batsman2.Location = new System.Drawing.Point(6, 61);
            this.Batsman2.Name = "Batsman2";
            this.Batsman2.Size = new System.Drawing.Size(57, 13);
            this.Batsman2.TabIndex = 1;
            this.Batsman2.Text = "Batsman 2";
            // 
            // Batsman1
            // 
            this.Batsman1.AutoSize = true;
            this.Batsman1.Location = new System.Drawing.Point(7, 30);
            this.Batsman1.Name = "Batsman1";
            this.Batsman1.Size = new System.Drawing.Size(57, 13);
            this.Batsman1.TabIndex = 0;
            this.Batsman1.Text = "Batsman 1";
            // 
            // TossGroupBox
            // 
            this.TossGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TossGroupBox.Controls.Add(this.label2);
            this.TossGroupBox.Controls.Add(this.FieldingComboBox);
            this.TossGroupBox.Controls.Add(this.label1);
            this.TossGroupBox.Controls.Add(this.BattingComboBox);
            this.TossGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TossGroupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.TossGroupBox.Location = new System.Drawing.Point(565, 30);
            this.TossGroupBox.Name = "TossGroupBox";
            this.TossGroupBox.Size = new System.Drawing.Size(219, 99);
            this.TossGroupBox.TabIndex = 9;
            this.TossGroupBox.TabStop = false;
            this.TossGroupBox.Text = "Toss";
            this.TossGroupBox.Visible = false;
            this.TossGroupBox.Enter += new System.EventHandler(this.TossGroupBox_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Batting";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FieldingComboBox
            // 
            this.FieldingComboBox.FormattingEnabled = true;
            this.FieldingComboBox.Location = new System.Drawing.Point(82, 68);
            this.FieldingComboBox.Name = "FieldingComboBox";
            this.FieldingComboBox.Size = new System.Drawing.Size(121, 24);
            this.FieldingComboBox.TabIndex = 11;
            this.FieldingComboBox.SelectedIndexChanged += new System.EventHandler(this.FieldingComboBox_SelectedIndexChanged);
            // 
            // Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 603);
            this.Controls.Add(this.TossGroupBox);
            this.Controls.Add(this.PlayerNameGroupBox);
            this.Controls.Add(this.MatchListBtn);
            this.Controls.Add(this.Selectamatchgroupbox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CreateamatchGroupbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Match";
            this.Text = "Match";
            this.CreateamatchGroupbox.ResumeLayout(false);
            this.CreateamatchGroupbox.PerformLayout();
            this.Selectamatchgroupbox.ResumeLayout(false);
            this.Selectamatchgroupbox.PerformLayout();
            this.PlayerNameGroupBox.ResumeLayout(false);
            this.PlayerNameGroupBox.PerformLayout();
            this.TossGroupBox.ResumeLayout(false);
            this.TossGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CreateamatchGroupbox;
        private System.Windows.Forms.ComboBox TeamBCombo;
        private System.Windows.Forms.ComboBox TeamACombo;
        private System.Windows.Forms.DateTimePicker MatchDate;
        private System.Windows.Forms.TextBox MatchVenue;
        private System.Windows.Forms.TextBox MatchOver;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelVenue;
        private System.Windows.Forms.Label labelOver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTeamA;
        private System.Windows.Forms.Label labelMatchName;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button DeleteMatch;
        private System.Windows.Forms.Button Continuematch;
        private System.Windows.Forms.GroupBox Selectamatchgroupbox;
        private System.Windows.Forms.ComboBox matchcombobox;
        private System.Windows.Forms.Label MatchNameLabel;
        private System.Windows.Forms.Button MatchListBtn;
        private System.Windows.Forms.ComboBox BattingComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox PlayerNameGroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox BowlerComboBox;
        private System.Windows.Forms.ComboBox Batting2ComboBox;
        private System.Windows.Forms.ComboBox Batting1ComboBox;
        private System.Windows.Forms.Label Bowler;
        private System.Windows.Forms.Label Batsman2;
        private System.Windows.Forms.Label Batsman1;
        private System.Windows.Forms.GroupBox TossGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FieldingComboBox;
    }
}