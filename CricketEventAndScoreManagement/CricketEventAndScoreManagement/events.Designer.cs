namespace CricketEventAndScoreManagement
{
    partial class events
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
            this.components = new System.ComponentModel.Container();
            this.add = new System.Windows.Forms.Button();
            this.addteamgb = new System.Windows.Forms.GroupBox();
            this.teamname = new System.Windows.Forms.Label();
            this.teamnametext = new System.Windows.Forms.TextBox();
            this.Manageteamandplayers = new System.Windows.Forms.Button();
            this.Startamatch = new System.Windows.Forms.Button();
            this.ViewTeam = new System.Windows.Forms.Button();
            this.Addteambtn = new System.Windows.Forms.Button();
            this.UpdateTeambtn = new System.Windows.Forms.Button();
            this.cricketDBDataSet = new CricketEventAndScoreManagement.CricketDBDataSet();
            this.eventcreationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventcreationTableAdapter = new CricketEventAndScoreManagement.CricketDBDataSetTableAdapters.eventcreationTableAdapter();
            this.cricketDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamDBDataSet = new CricketEventAndScoreManagement.TeamDBDataSet();
            this.teamListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamListTableAdapter = new CricketEventAndScoreManagement.TeamDBDataSetTableAdapters.TeamListTableAdapter();
            this.teamListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teamDBDataSet1 = new CricketEventAndScoreManagement.TeamDBDataSet1();
            this.bangladeshBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangladeshTableAdapter = new CricketEventAndScoreManagement.TeamDBDataSet1TableAdapters.BangladeshTableAdapter();
            this.AddPlayerGroupBox = new System.Windows.Forms.GroupBox();
            this.playerroleslabel = new System.Windows.Forms.Label();
            this.playerdateofbirthlabel = new System.Windows.Forms.Label();
            this.playernamelabel = new System.Windows.Forms.Label();
            this.Tname = new System.Windows.Forms.Label();
            this.AddPlayerbtn = new System.Windows.Forms.Button();
            this.PlayerDateTime = new System.Windows.Forms.DateTimePicker();
            this.Playercombobox = new System.Windows.Forms.ComboBox();
            this.PlayerNameText = new System.Windows.Forms.TextBox();
            this.AddPlayerbtn1 = new System.Windows.Forms.Button();
            this.UpdatePlayerBtn = new System.Windows.Forms.Button();
            this.comboBoxUpdatePlayer = new System.Windows.Forms.ComboBox();
            this.UpdatePlayerGroupBox = new System.Windows.Forms.GroupBox();
            this.UpdatePlayerRoles = new System.Windows.Forms.Label();
            this.UpdatePlayerDateofBirth = new System.Windows.Forms.Label();
            this.UpdatePlayerName = new System.Windows.Forms.Label();
            this.UpdatedTeamNameLabel = new System.Windows.Forms.Label();
            this.UpdatePBtn = new System.Windows.Forms.Button();
            this.UpdatePlayerdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UpdatePlayerCombobox = new System.Windows.Forms.ComboBox();
            this.UpdatePlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.teamlistComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteTeamBtn = new System.Windows.Forms.Button();
            this.DeleteTeamComboBox = new System.Windows.Forms.ComboBox();
            this.dltteambtn = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.viewcomboBox = new System.Windows.Forms.ComboBox();
            this.TeamDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addteamgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cricketDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventcreationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cricketDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangladeshBindingSource)).BeginInit();
            this.AddPlayerGroupBox.SuspendLayout();
            this.UpdatePlayerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(133, 68);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(53, 23);
            this.add.TabIndex = 0;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // addteamgb
            // 
            this.addteamgb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addteamgb.Controls.Add(this.add);
            this.addteamgb.Controls.Add(this.teamname);
            this.addteamgb.Controls.Add(this.teamnametext);
            this.addteamgb.Location = new System.Drawing.Point(26, 157);
            this.addteamgb.Name = "addteamgb";
            this.addteamgb.Size = new System.Drawing.Size(203, 103);
            this.addteamgb.TabIndex = 1;
            this.addteamgb.TabStop = false;
            this.addteamgb.Text = "Add team";
            this.addteamgb.Visible = false;
            this.addteamgb.Enter += new System.EventHandler(this.addteamgb_Enter);
            // 
            // teamname
            // 
            this.teamname.AutoSize = true;
            this.teamname.Location = new System.Drawing.Point(16, 32);
            this.teamname.Name = "teamname";
            this.teamname.Size = new System.Drawing.Size(63, 13);
            this.teamname.TabIndex = 1;
            this.teamname.Text = "Team name";
            // 
            // teamnametext
            // 
            this.teamnametext.Location = new System.Drawing.Point(85, 32);
            this.teamnametext.Name = "teamnametext";
            this.teamnametext.Size = new System.Drawing.Size(101, 20);
            this.teamnametext.TabIndex = 0;
            this.teamnametext.TextChanged += new System.EventHandler(this.teamnametext_TextChanged);
            // 
            // Manageteamandplayers
            // 
            this.Manageteamandplayers.Location = new System.Drawing.Point(204, 22);
            this.Manageteamandplayers.Name = "Manageteamandplayers";
            this.Manageteamandplayers.Size = new System.Drawing.Size(162, 23);
            this.Manageteamandplayers.TabIndex = 3;
            this.Manageteamandplayers.Text = "Manage team and players";
            this.Manageteamandplayers.UseVisualStyleBackColor = true;
            this.Manageteamandplayers.Click += new System.EventHandler(this.Manageteamandplayers_Click);
            // 
            // Startamatch
            // 
            this.Startamatch.Location = new System.Drawing.Point(430, 22);
            this.Startamatch.Name = "Startamatch";
            this.Startamatch.Size = new System.Drawing.Size(162, 23);
            this.Startamatch.TabIndex = 4;
            this.Startamatch.Text = "Start a match";
            this.Startamatch.UseVisualStyleBackColor = true;
            this.Startamatch.Click += new System.EventHandler(this.Startamatch_Click);
            // 
            // ViewTeam
            // 
            this.ViewTeam.Location = new System.Drawing.Point(315, 51);
            this.ViewTeam.Name = "ViewTeam";
            this.ViewTeam.Size = new System.Drawing.Size(162, 23);
            this.ViewTeam.TabIndex = 5;
            this.ViewTeam.Text = "View Team";
            this.ViewTeam.UseVisualStyleBackColor = true;
            this.ViewTeam.Click += new System.EventHandler(this.ViewTeam_Click);
            // 
            // Addteambtn
            // 
            this.Addteambtn.Location = new System.Drawing.Point(26, 84);
            this.Addteambtn.Name = "Addteambtn";
            this.Addteambtn.Size = new System.Drawing.Size(79, 23);
            this.Addteambtn.TabIndex = 6;
            this.Addteambtn.Text = "Add team";
            this.Addteambtn.UseVisualStyleBackColor = true;
            this.Addteambtn.Visible = false;
            this.Addteambtn.Click += new System.EventHandler(this.Addteambtn_Click);
            // 
            // UpdateTeambtn
            // 
            this.UpdateTeambtn.Location = new System.Drawing.Point(111, 84);
            this.UpdateTeambtn.Name = "UpdateTeambtn";
            this.UpdateTeambtn.Size = new System.Drawing.Size(89, 23);
            this.UpdateTeambtn.TabIndex = 7;
            this.UpdateTeambtn.Text = "Update team";
            this.UpdateTeambtn.UseVisualStyleBackColor = true;
            this.UpdateTeambtn.Visible = false;
            this.UpdateTeambtn.Click += new System.EventHandler(this.ViewTeambtn_Click);
            // 
            // cricketDBDataSet
            // 
            this.cricketDBDataSet.DataSetName = "CricketDBDataSet";
            this.cricketDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventcreationBindingSource
            // 
            this.eventcreationBindingSource.DataMember = "eventcreation";
            this.eventcreationBindingSource.DataSource = this.cricketDBDataSet;
            // 
            // eventcreationTableAdapter
            // 
            this.eventcreationTableAdapter.ClearBeforeFill = true;
            // 
            // cricketDBDataSetBindingSource
            // 
            this.cricketDBDataSetBindingSource.DataSource = this.cricketDBDataSet;
            this.cricketDBDataSetBindingSource.Position = 0;
            // 
            // teamDBDataSet
            // 
            this.teamDBDataSet.DataSetName = "TeamDBDataSet";
            this.teamDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamListBindingSource
            // 
            this.teamListBindingSource.DataMember = "TeamList";
            this.teamListBindingSource.DataSource = this.teamDBDataSet;
            // 
            // teamListTableAdapter
            // 
            this.teamListTableAdapter.ClearBeforeFill = true;
            // 
            // teamListBindingSource1
            // 
            this.teamListBindingSource1.DataMember = "TeamList";
            this.teamListBindingSource1.DataSource = this.teamDBDataSet;
            // 
            // teamDBDataSet1
            // 
            this.teamDBDataSet1.DataSetName = "TeamDBDataSet1";
            this.teamDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangladeshBindingSource
            // 
            this.bangladeshBindingSource.DataMember = "Bangladesh";
            this.bangladeshBindingSource.DataSource = this.teamDBDataSet1;
            // 
            // bangladeshTableAdapter
            // 
            this.bangladeshTableAdapter.ClearBeforeFill = true;
            // 
            // AddPlayerGroupBox
            // 
            this.AddPlayerGroupBox.Controls.Add(this.playerroleslabel);
            this.AddPlayerGroupBox.Controls.Add(this.playerdateofbirthlabel);
            this.AddPlayerGroupBox.Controls.Add(this.playernamelabel);
            this.AddPlayerGroupBox.Controls.Add(this.Tname);
            this.AddPlayerGroupBox.Controls.Add(this.AddPlayerbtn);
            this.AddPlayerGroupBox.Controls.Add(this.PlayerDateTime);
            this.AddPlayerGroupBox.Controls.Add(this.Playercombobox);
            this.AddPlayerGroupBox.Controls.Add(this.PlayerNameText);
            this.AddPlayerGroupBox.Location = new System.Drawing.Point(250, 157);
            this.AddPlayerGroupBox.Name = "AddPlayerGroupBox";
            this.AddPlayerGroupBox.Size = new System.Drawing.Size(270, 171);
            this.AddPlayerGroupBox.TabIndex = 8;
            this.AddPlayerGroupBox.TabStop = false;
            this.AddPlayerGroupBox.Text = "Add Player";
            this.AddPlayerGroupBox.Visible = false;
            this.AddPlayerGroupBox.Enter += new System.EventHandler(this.AddPlayerGroupBox_Enter);
            // 
            // playerroleslabel
            // 
            this.playerroleslabel.AutoSize = true;
            this.playerroleslabel.Location = new System.Drawing.Point(19, 120);
            this.playerroleslabel.Name = "playerroleslabel";
            this.playerroleslabel.Size = new System.Drawing.Size(34, 13);
            this.playerroleslabel.TabIndex = 15;
            this.playerroleslabel.Text = "Roles";
            // 
            // playerdateofbirthlabel
            // 
            this.playerdateofbirthlabel.AutoSize = true;
            this.playerdateofbirthlabel.Location = new System.Drawing.Point(19, 89);
            this.playerdateofbirthlabel.Name = "playerdateofbirthlabel";
            this.playerdateofbirthlabel.Size = new System.Drawing.Size(66, 13);
            this.playerdateofbirthlabel.TabIndex = 14;
            this.playerdateofbirthlabel.Text = "Date of Birth";
            // 
            // playernamelabel
            // 
            this.playernamelabel.AutoSize = true;
            this.playernamelabel.Location = new System.Drawing.Point(19, 50);
            this.playernamelabel.Name = "playernamelabel";
            this.playernamelabel.Size = new System.Drawing.Size(35, 13);
            this.playernamelabel.TabIndex = 13;
            this.playernamelabel.Text = "Name";
            // 
            // Tname
            // 
            this.Tname.AutoSize = true;
            this.Tname.Location = new System.Drawing.Point(92, 20);
            this.Tname.Name = "Tname";
            this.Tname.Size = new System.Drawing.Size(35, 13);
            this.Tname.TabIndex = 12;
            this.Tname.Text = "label1";
            this.Tname.Click += new System.EventHandler(this.Tname_Click);
            // 
            // AddPlayerbtn
            // 
            this.AddPlayerbtn.Location = new System.Drawing.Point(181, 139);
            this.AddPlayerbtn.Name = "AddPlayerbtn";
            this.AddPlayerbtn.Size = new System.Drawing.Size(75, 23);
            this.AddPlayerbtn.TabIndex = 11;
            this.AddPlayerbtn.Text = "Add";
            this.AddPlayerbtn.UseVisualStyleBackColor = true;
            this.AddPlayerbtn.Click += new System.EventHandler(this.AddPlayerbtn_Click);
            // 
            // PlayerDateTime
            // 
            this.PlayerDateTime.CustomFormat = "MM-dd-yyyy";
            this.PlayerDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PlayerDateTime.Location = new System.Drawing.Point(160, 82);
            this.PlayerDateTime.Name = "PlayerDateTime";
            this.PlayerDateTime.Size = new System.Drawing.Size(96, 20);
            this.PlayerDateTime.TabIndex = 2;
            // 
            // Playercombobox
            // 
            this.Playercombobox.FormattingEnabled = true;
            this.Playercombobox.Items.AddRange(new object[] {
            "Batsman",
            "Bowler",
            "Allrounder"});
            this.Playercombobox.Location = new System.Drawing.Point(135, 112);
            this.Playercombobox.Name = "Playercombobox";
            this.Playercombobox.Size = new System.Drawing.Size(121, 21);
            this.Playercombobox.TabIndex = 1;
            this.Playercombobox.SelectedIndexChanged += new System.EventHandler(this.Playercombobox_SelectedIndexChanged);
            // 
            // PlayerNameText
            // 
            this.PlayerNameText.Location = new System.Drawing.Point(115, 47);
            this.PlayerNameText.Name = "PlayerNameText";
            this.PlayerNameText.Size = new System.Drawing.Size(141, 20);
            this.PlayerNameText.TabIndex = 0;
            // 
            // AddPlayerbtn1
            // 
            this.AddPlayerbtn1.Location = new System.Drawing.Point(344, 86);
            this.AddPlayerbtn1.Name = "AddPlayerbtn1";
            this.AddPlayerbtn1.Size = new System.Drawing.Size(85, 23);
            this.AddPlayerbtn1.TabIndex = 9;
            this.AddPlayerbtn1.Text = "Add Player";
            this.AddPlayerbtn1.UseVisualStyleBackColor = true;
            this.AddPlayerbtn1.Visible = false;
            this.AddPlayerbtn1.Click += new System.EventHandler(this.AddPlayerbtn1_Click);
            // 
            // UpdatePlayerBtn
            // 
            this.UpdatePlayerBtn.Location = new System.Drawing.Point(435, 86);
            this.UpdatePlayerBtn.Name = "UpdatePlayerBtn";
            this.UpdatePlayerBtn.Size = new System.Drawing.Size(85, 23);
            this.UpdatePlayerBtn.TabIndex = 10;
            this.UpdatePlayerBtn.Text = "Update Player";
            this.UpdatePlayerBtn.UseVisualStyleBackColor = true;
            this.UpdatePlayerBtn.Visible = false;
            this.UpdatePlayerBtn.Click += new System.EventHandler(this.UpdatePlayerBtn_Click);
            // 
            // comboBoxUpdatePlayer
            // 
            this.comboBoxUpdatePlayer.FormattingEnabled = true;
            this.comboBoxUpdatePlayer.Location = new System.Drawing.Point(536, 88);
            this.comboBoxUpdatePlayer.Name = "comboBoxUpdatePlayer";
            this.comboBoxUpdatePlayer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUpdatePlayer.TabIndex = 11;
            this.comboBoxUpdatePlayer.Visible = false;
            this.comboBoxUpdatePlayer.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UpdatePlayerGroupBox
            // 
            this.UpdatePlayerGroupBox.Controls.Add(this.UpdatePlayerRoles);
            this.UpdatePlayerGroupBox.Controls.Add(this.UpdatePlayerDateofBirth);
            this.UpdatePlayerGroupBox.Controls.Add(this.UpdatePlayerName);
            this.UpdatePlayerGroupBox.Controls.Add(this.UpdatedTeamNameLabel);
            this.UpdatePlayerGroupBox.Controls.Add(this.UpdatePBtn);
            this.UpdatePlayerGroupBox.Controls.Add(this.UpdatePlayerdateTimePicker);
            this.UpdatePlayerGroupBox.Controls.Add(this.UpdatePlayerCombobox);
            this.UpdatePlayerGroupBox.Controls.Add(this.UpdatePlayerNameTextBox);
            this.UpdatePlayerGroupBox.Location = new System.Drawing.Point(536, 157);
            this.UpdatePlayerGroupBox.Name = "UpdatePlayerGroupBox";
            this.UpdatePlayerGroupBox.Size = new System.Drawing.Size(301, 184);
            this.UpdatePlayerGroupBox.TabIndex = 12;
            this.UpdatePlayerGroupBox.TabStop = false;
            this.UpdatePlayerGroupBox.Text = "Update Player";
            this.UpdatePlayerGroupBox.Visible = false;
            // 
            // UpdatePlayerRoles
            // 
            this.UpdatePlayerRoles.AutoSize = true;
            this.UpdatePlayerRoles.Location = new System.Drawing.Point(19, 120);
            this.UpdatePlayerRoles.Name = "UpdatePlayerRoles";
            this.UpdatePlayerRoles.Size = new System.Drawing.Size(34, 13);
            this.UpdatePlayerRoles.TabIndex = 15;
            this.UpdatePlayerRoles.Text = "Roles";
            // 
            // UpdatePlayerDateofBirth
            // 
            this.UpdatePlayerDateofBirth.AutoSize = true;
            this.UpdatePlayerDateofBirth.Location = new System.Drawing.Point(19, 89);
            this.UpdatePlayerDateofBirth.Name = "UpdatePlayerDateofBirth";
            this.UpdatePlayerDateofBirth.Size = new System.Drawing.Size(66, 13);
            this.UpdatePlayerDateofBirth.TabIndex = 14;
            this.UpdatePlayerDateofBirth.Text = "Date of Birth";
            // 
            // UpdatePlayerName
            // 
            this.UpdatePlayerName.AutoSize = true;
            this.UpdatePlayerName.Location = new System.Drawing.Point(16, 57);
            this.UpdatePlayerName.Name = "UpdatePlayerName";
            this.UpdatePlayerName.Size = new System.Drawing.Size(35, 13);
            this.UpdatePlayerName.TabIndex = 13;
            this.UpdatePlayerName.Text = "Name";
            // 
            // UpdatedTeamNameLabel
            // 
            this.UpdatedTeamNameLabel.AutoSize = true;
            this.UpdatedTeamNameLabel.Location = new System.Drawing.Point(92, 20);
            this.UpdatedTeamNameLabel.Name = "UpdatedTeamNameLabel";
            this.UpdatedTeamNameLabel.Size = new System.Drawing.Size(35, 13);
            this.UpdatedTeamNameLabel.TabIndex = 12;
            this.UpdatedTeamNameLabel.Text = "label1";
            // 
            // UpdatePBtn
            // 
            this.UpdatePBtn.Location = new System.Drawing.Point(205, 139);
            this.UpdatePBtn.Name = "UpdatePBtn";
            this.UpdatePBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdatePBtn.TabIndex = 11;
            this.UpdatePBtn.Text = "Update";
            this.UpdatePBtn.UseVisualStyleBackColor = true;
            this.UpdatePBtn.Click += new System.EventHandler(this.UpdatePBtn_Click);
            // 
            // UpdatePlayerdateTimePicker
            // 
            this.UpdatePlayerdateTimePicker.CustomFormat = "MM-dd-yyyy";
            this.UpdatePlayerdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.UpdatePlayerdateTimePicker.Location = new System.Drawing.Point(184, 83);
            this.UpdatePlayerdateTimePicker.Name = "UpdatePlayerdateTimePicker";
            this.UpdatePlayerdateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.UpdatePlayerdateTimePicker.TabIndex = 2;
            // 
            // UpdatePlayerCombobox
            // 
            this.UpdatePlayerCombobox.FormattingEnabled = true;
            this.UpdatePlayerCombobox.Items.AddRange(new object[] {
            "Batsman",
            "Bowler",
            "Allrounder"});
            this.UpdatePlayerCombobox.Location = new System.Drawing.Point(159, 112);
            this.UpdatePlayerCombobox.Name = "UpdatePlayerCombobox";
            this.UpdatePlayerCombobox.Size = new System.Drawing.Size(121, 21);
            this.UpdatePlayerCombobox.TabIndex = 1;
            this.UpdatePlayerCombobox.SelectedIndexChanged += new System.EventHandler(this.UpdatePlayerCombobox_SelectedIndexChanged);
            // 
            // UpdatePlayerNameTextBox
            // 
            this.UpdatePlayerNameTextBox.Location = new System.Drawing.Point(139, 57);
            this.UpdatePlayerNameTextBox.Name = "UpdatePlayerNameTextBox";
            this.UpdatePlayerNameTextBox.Size = new System.Drawing.Size(141, 20);
            this.UpdatePlayerNameTextBox.TabIndex = 0;
            // 
            // teamlistComboBox
            // 
            this.teamlistComboBox.FormattingEnabled = true;
            this.teamlistComboBox.Location = new System.Drawing.Point(213, 86);
            this.teamlistComboBox.Name = "teamlistComboBox";
            this.teamlistComboBox.Size = new System.Drawing.Size(121, 21);
            this.teamlistComboBox.TabIndex = 13;
            this.teamlistComboBox.Visible = false;
            this.teamlistComboBox.SelectedIndexChanged += new System.EventHandler(this.teamlistComboBox_SelectedIndexChanged);
            // 
            // DeleteTeamBtn
            // 
            this.DeleteTeamBtn.Location = new System.Drawing.Point(26, 120);
            this.DeleteTeamBtn.Name = "DeleteTeamBtn";
            this.DeleteTeamBtn.Size = new System.Drawing.Size(174, 23);
            this.DeleteTeamBtn.TabIndex = 14;
            this.DeleteTeamBtn.Text = "Delete Team";
            this.DeleteTeamBtn.UseVisualStyleBackColor = true;
            this.DeleteTeamBtn.Visible = false;
            this.DeleteTeamBtn.Click += new System.EventHandler(this.DeleteTeamBtn_Click);
            // 
            // DeleteTeamComboBox
            // 
            this.DeleteTeamComboBox.FormattingEnabled = true;
            this.DeleteTeamComboBox.Location = new System.Drawing.Point(213, 120);
            this.DeleteTeamComboBox.Name = "DeleteTeamComboBox";
            this.DeleteTeamComboBox.Size = new System.Drawing.Size(121, 21);
            this.DeleteTeamComboBox.TabIndex = 15;
            this.DeleteTeamComboBox.Visible = false;
            this.DeleteTeamComboBox.SelectedIndexChanged += new System.EventHandler(this.DeleteTeamComboBox_SelectedIndexChanged);
            // 
            // dltteambtn
            // 
            this.dltteambtn.Location = new System.Drawing.Point(345, 120);
            this.dltteambtn.Name = "dltteambtn";
            this.dltteambtn.Size = new System.Drawing.Size(101, 23);
            this.dltteambtn.TabIndex = 16;
            this.dltteambtn.Text = "Delete Team";
            this.dltteambtn.UseVisualStyleBackColor = true;
            this.dltteambtn.Visible = false;
            this.dltteambtn.Click += new System.EventHandler(this.dltteambtn_Click);
            // 
            // viewcomboBox
            // 
            this.viewcomboBox.FormattingEnabled = true;
            this.viewcomboBox.Location = new System.Drawing.Point(500, 51);
            this.viewcomboBox.Name = "viewcomboBox";
            this.viewcomboBox.Size = new System.Drawing.Size(121, 21);
            this.viewcomboBox.TabIndex = 17;
            this.viewcomboBox.Visible = false;
            this.viewcomboBox.SelectedIndexChanged += new System.EventHandler(this.viewcomboBox_SelectedIndexChanged);
            // 
            // TeamDataGrid
            // 
            this.TeamDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.TeamDataGrid.Location = new System.Drawing.Point(669, 51);
            this.TeamDataGrid.Name = "TeamDataGrid";
            this.TeamDataGrid.Size = new System.Drawing.Size(343, 217);
            this.TeamDataGrid.TabIndex = 19;
            this.TeamDataGrid.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date of Birth";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Role";
            this.Column3.Name = "Column3";
            // 
            // events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 416);
            this.Controls.Add(this.TeamDataGrid);
            this.Controls.Add(this.viewcomboBox);
            this.Controls.Add(this.dltteambtn);
            this.Controls.Add(this.DeleteTeamComboBox);
            this.Controls.Add(this.DeleteTeamBtn);
            this.Controls.Add(this.teamlistComboBox);
            this.Controls.Add(this.UpdatePlayerGroupBox);
            this.Controls.Add(this.comboBoxUpdatePlayer);
            this.Controls.Add(this.UpdatePlayerBtn);
            this.Controls.Add(this.AddPlayerbtn1);
            this.Controls.Add(this.AddPlayerGroupBox);
            this.Controls.Add(this.UpdateTeambtn);
            this.Controls.Add(this.Addteambtn);
            this.Controls.Add(this.ViewTeam);
            this.Controls.Add(this.Startamatch);
            this.Controls.Add(this.Manageteamandplayers);
            this.Controls.Add(this.addteamgb);
            this.Name = "events";
            this.Text = "events";
            this.addteamgb.ResumeLayout(false);
            this.addteamgb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cricketDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventcreationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cricketDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangladeshBindingSource)).EndInit();
            this.AddPlayerGroupBox.ResumeLayout(false);
            this.AddPlayerGroupBox.PerformLayout();
            this.UpdatePlayerGroupBox.ResumeLayout(false);
            this.UpdatePlayerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.GroupBox addteamgb;
        private System.Windows.Forms.Button Manageteamandplayers;
        private System.Windows.Forms.Button Startamatch;
        private System.Windows.Forms.Button ViewTeam;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label teamname;
        private System.Windows.Forms.TextBox teamnametext;
        private System.Windows.Forms.Button Addteambtn;
        private System.Windows.Forms.Button UpdateTeambtn;
        private CricketDBDataSet cricketDBDataSet;
        private System.Windows.Forms.BindingSource eventcreationBindingSource;
        private CricketDBDataSetTableAdapters.eventcreationTableAdapter eventcreationTableAdapter;
        private System.Windows.Forms.BindingSource cricketDBDataSetBindingSource;
        private TeamDBDataSet teamDBDataSet;
        private System.Windows.Forms.BindingSource teamListBindingSource;
        private TeamDBDataSetTableAdapters.TeamListTableAdapter teamListTableAdapter;
        private System.Windows.Forms.BindingSource teamListBindingSource1;
        private TeamDBDataSet1 teamDBDataSet1;
        private System.Windows.Forms.BindingSource bangladeshBindingSource;
        private TeamDBDataSet1TableAdapters.BangladeshTableAdapter bangladeshTableAdapter;
        private System.Windows.Forms.GroupBox AddPlayerGroupBox;
        private System.Windows.Forms.Label playerroleslabel;
        private System.Windows.Forms.Label playerdateofbirthlabel;
        private System.Windows.Forms.Label playernamelabel;
        private System.Windows.Forms.Label Tname;
        private System.Windows.Forms.Button AddPlayerbtn;
        private System.Windows.Forms.DateTimePicker PlayerDateTime;
        private System.Windows.Forms.ComboBox Playercombobox;
        private System.Windows.Forms.TextBox PlayerNameText;
        private System.Windows.Forms.Button AddPlayerbtn1;
        private System.Windows.Forms.Button UpdatePlayerBtn;
        private System.Windows.Forms.ComboBox comboBoxUpdatePlayer;
        private System.Windows.Forms.GroupBox UpdatePlayerGroupBox;
        private System.Windows.Forms.Label UpdatePlayerRoles;
        private System.Windows.Forms.Label UpdatePlayerDateofBirth;
        private System.Windows.Forms.Label UpdatePlayerName;
        private System.Windows.Forms.Label UpdatedTeamNameLabel;
        private System.Windows.Forms.Button UpdatePBtn;
        private System.Windows.Forms.DateTimePicker UpdatePlayerdateTimePicker;
        private System.Windows.Forms.ComboBox UpdatePlayerCombobox;
        private System.Windows.Forms.TextBox UpdatePlayerNameTextBox;
        private System.Windows.Forms.ComboBox teamlistComboBox;
        private System.Windows.Forms.Button DeleteTeamBtn;
        private System.Windows.Forms.ComboBox DeleteTeamComboBox;
        private System.Windows.Forms.Button dltteambtn;
        private System.Windows.Forms.ComboBox viewcomboBox;
        private System.Windows.Forms.DataGridView TeamDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}