namespace CricketEventAndScoreManagement
{
    partial class live_score
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.WicketCombo = new System.Windows.Forms.GroupBox();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.LegalDelivery = new System.Windows.Forms.RadioButton();
            this.WD = new System.Windows.Forms.RadioButton();
            this.NB = new System.Windows.Forms.RadioButton();
            this.RunGroupBox = new System.Windows.Forms.GroupBox();
            this.labelWicket = new System.Windows.Forms.Label();
            this.wicketComboBox = new System.Windows.Forms.ComboBox();
            this.run0 = new System.Windows.Forms.RadioButton();
            this.run1 = new System.Windows.Forms.RadioButton();
            this.run3 = new System.Windows.Forms.RadioButton();
            this.run2 = new System.Windows.Forms.RadioButton();
            this.run4 = new System.Windows.Forms.RadioButton();
            this.run6 = new System.Windows.Forms.RadioButton();
            this.BowlerNameLvl = new System.Windows.Forms.Label();
            this.WicketLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RunLabel = new System.Windows.Forms.Label();
            this.BattingTeamLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Batting2Name = new System.Windows.Forms.RadioButton();
            this.Batting1Name = new System.Windows.Forms.RadioButton();
            this.eventcreationTableAdapter1 = new CricketEventAndScoreManagement.CricketDBDataSetTableAdapters.eventcreationTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBall = new System.Windows.Forms.Label();
            this.labelOver = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ScoreCard = new System.Windows.Forms.Button();
            this.dataGridViewBall = new System.Windows.Forms.DataGridView();
            this.dataGridViewBat = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.WicketCombo.SuspendLayout();
            this.RunGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dataGridViewBat);
            this.panel1.Controls.Add(this.dataGridViewBall);
            this.panel1.Controls.Add(this.ScoreCard);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.WicketCombo);
            this.panel1.Controls.Add(this.RunGroupBox);
            this.panel1.Controls.Add(this.BowlerNameLvl);
            this.panel1.Controls.Add(this.labelOver);
            this.panel1.Controls.Add(this.labelBall);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.WicketLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.RunLabel);
            this.panel1.Controls.Add(this.BattingTeamLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Batting2Name);
            this.panel1.Controls.Add(this.Batting1Name);
            this.panel1.Location = new System.Drawing.Point(40, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 484);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // WicketCombo
            // 
            this.WicketCombo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.WicketCombo.Controls.Add(this.ConfirmBtn);
            this.WicketCombo.Controls.Add(this.LegalDelivery);
            this.WicketCombo.Controls.Add(this.WD);
            this.WicketCombo.Controls.Add(this.NB);
            this.WicketCombo.Location = new System.Drawing.Point(287, 158);
            this.WicketCombo.Name = "WicketCombo";
            this.WicketCombo.Size = new System.Drawing.Size(270, 98);
            this.WicketCombo.TabIndex = 16;
            this.WicketCombo.TabStop = false;
            this.WicketCombo.Text = "Ball";
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(11, 62);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBtn.TabIndex = 13;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // LegalDelivery
            // 
            this.LegalDelivery.AutoSize = true;
            this.LegalDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LegalDelivery.Location = new System.Drawing.Point(11, 23);
            this.LegalDelivery.Name = "LegalDelivery";
            this.LegalDelivery.Size = new System.Drawing.Size(45, 20);
            this.LegalDelivery.TabIndex = 8;
            this.LegalDelivery.TabStop = true;
            this.LegalDelivery.Text = "LD";
            this.LegalDelivery.UseVisualStyleBackColor = true;
            // 
            // WD
            // 
            this.WD.AutoSize = true;
            this.WD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WD.Location = new System.Drawing.Point(115, 23);
            this.WD.Name = "WD";
            this.WD.Size = new System.Drawing.Size(51, 20);
            this.WD.TabIndex = 12;
            this.WD.TabStop = true;
            this.WD.Text = "WD";
            this.WD.UseVisualStyleBackColor = true;
            // 
            // NB
            // 
            this.NB.AutoSize = true;
            this.NB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NB.Location = new System.Drawing.Point(62, 23);
            this.NB.Name = "NB";
            this.NB.Size = new System.Drawing.Size(47, 20);
            this.NB.TabIndex = 10;
            this.NB.TabStop = true;
            this.NB.Text = "NB";
            this.NB.UseVisualStyleBackColor = true;
            // 
            // RunGroupBox
            // 
            this.RunGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RunGroupBox.Controls.Add(this.labelWicket);
            this.RunGroupBox.Controls.Add(this.wicketComboBox);
            this.RunGroupBox.Controls.Add(this.run0);
            this.RunGroupBox.Controls.Add(this.run1);
            this.RunGroupBox.Controls.Add(this.run3);
            this.RunGroupBox.Controls.Add(this.run2);
            this.RunGroupBox.Controls.Add(this.run4);
            this.RunGroupBox.Controls.Add(this.run6);
            this.RunGroupBox.Location = new System.Drawing.Point(17, 158);
            this.RunGroupBox.Name = "RunGroupBox";
            this.RunGroupBox.Size = new System.Drawing.Size(264, 98);
            this.RunGroupBox.TabIndex = 15;
            this.RunGroupBox.TabStop = false;
            this.RunGroupBox.Text = "Run";
            // 
            // labelWicket
            // 
            this.labelWicket.AutoSize = true;
            this.labelWicket.Location = new System.Drawing.Point(12, 46);
            this.labelWicket.Name = "labelWicket";
            this.labelWicket.Size = new System.Drawing.Size(41, 13);
            this.labelWicket.TabIndex = 10;
            this.labelWicket.Text = "Wicket";
            // 
            // wicketComboBox
            // 
            this.wicketComboBox.FormattingEnabled = true;
            this.wicketComboBox.Location = new System.Drawing.Point(12, 62);
            this.wicketComboBox.Name = "wicketComboBox";
            this.wicketComboBox.Size = new System.Drawing.Size(121, 21);
            this.wicketComboBox.TabIndex = 9;
            // 
            // run0
            // 
            this.run0.AutoSize = true;
            this.run0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run0.Location = new System.Drawing.Point(220, 23);
            this.run0.Name = "run0";
            this.run0.Size = new System.Drawing.Size(34, 20);
            this.run0.TabIndex = 7;
            this.run0.TabStop = true;
            this.run0.Text = "0";
            this.run0.UseVisualStyleBackColor = true;
            // 
            // run1
            // 
            this.run1.AutoSize = true;
            this.run1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run1.Location = new System.Drawing.Point(180, 23);
            this.run1.Name = "run1";
            this.run1.Size = new System.Drawing.Size(34, 20);
            this.run1.TabIndex = 6;
            this.run1.TabStop = true;
            this.run1.Text = "1";
            this.run1.UseVisualStyleBackColor = true;
            // 
            // run3
            // 
            this.run3.AutoSize = true;
            this.run3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run3.Location = new System.Drawing.Point(99, 23);
            this.run3.Name = "run3";
            this.run3.Size = new System.Drawing.Size(34, 20);
            this.run3.TabIndex = 5;
            this.run3.TabStop = true;
            this.run3.Text = "3";
            this.run3.UseVisualStyleBackColor = true;
            // 
            // run2
            // 
            this.run2.AutoSize = true;
            this.run2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run2.Location = new System.Drawing.Point(140, 23);
            this.run2.Name = "run2";
            this.run2.Size = new System.Drawing.Size(34, 20);
            this.run2.TabIndex = 4;
            this.run2.TabStop = true;
            this.run2.Text = "2";
            this.run2.UseVisualStyleBackColor = true;
            // 
            // run4
            // 
            this.run4.AutoSize = true;
            this.run4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run4.Location = new System.Drawing.Point(55, 23);
            this.run4.Name = "run4";
            this.run4.Size = new System.Drawing.Size(34, 20);
            this.run4.TabIndex = 3;
            this.run4.TabStop = true;
            this.run4.Text = "4";
            this.run4.UseVisualStyleBackColor = true;
            // 
            // run6
            // 
            this.run6.AutoSize = true;
            this.run6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run6.Location = new System.Drawing.Point(15, 23);
            this.run6.Name = "run6";
            this.run6.Size = new System.Drawing.Size(34, 20);
            this.run6.TabIndex = 1;
            this.run6.TabStop = true;
            this.run6.Text = "6";
            this.run6.UseVisualStyleBackColor = true;
            // 
            // BowlerNameLvl
            // 
            this.BowlerNameLvl.AutoSize = true;
            this.BowlerNameLvl.Location = new System.Drawing.Point(394, 97);
            this.BowlerNameLvl.Name = "BowlerNameLvl";
            this.BowlerNameLvl.Size = new System.Drawing.Size(67, 13);
            this.BowlerNameLvl.TabIndex = 11;
            this.BowlerNameLvl.Text = "BowlerName";
            // 
            // WicketLabel
            // 
            this.WicketLabel.AutoSize = true;
            this.WicketLabel.Location = new System.Drawing.Point(205, 35);
            this.WicketLabel.Name = "WicketLabel";
            this.WicketLabel.Size = new System.Drawing.Size(41, 13);
            this.WicketLabel.TabIndex = 7;
            this.WicketLabel.Text = "Wicket";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "/";
            // 
            // RunLabel
            // 
            this.RunLabel.AutoSize = true;
            this.RunLabel.Location = new System.Drawing.Point(113, 35);
            this.RunLabel.Name = "RunLabel";
            this.RunLabel.Size = new System.Drawing.Size(54, 13);
            this.RunLabel.TabIndex = 5;
            this.RunLabel.Text = "Total Run";
            // 
            // BattingTeamLabel
            // 
            this.BattingTeamLabel.AutoSize = true;
            this.BattingTeamLabel.Location = new System.Drawing.Point(27, 35);
            this.BattingTeamLabel.Name = "BattingTeamLabel";
            this.BattingTeamLabel.Size = new System.Drawing.Size(76, 13);
            this.BattingTeamLabel.TabIndex = 4;
            this.BattingTeamLabel.Text = "BattingTeam - ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "BOWLER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BATSMAN";
            // 
            // Batting2Name
            // 
            this.Batting2Name.AutoSize = true;
            this.Batting2Name.Location = new System.Drawing.Point(151, 97);
            this.Batting2Name.Name = "Batting2Name";
            this.Batting2Name.Size = new System.Drawing.Size(72, 17);
            this.Batting2Name.TabIndex = 1;
            this.Batting2Name.TabStop = true;
            this.Batting2Name.Text = "Batsman2";
            this.Batting2Name.UseVisualStyleBackColor = true;
            // 
            // Batting1Name
            // 
            this.Batting1Name.AutoSize = true;
            this.Batting1Name.Location = new System.Drawing.Point(30, 97);
            this.Batting1Name.Name = "Batting1Name";
            this.Batting1Name.Size = new System.Drawing.Size(72, 17);
            this.Batting1Name.TabIndex = 0;
            this.Batting1Name.TabStop = true;
            this.Batting1Name.Text = "Batsman1";
            this.Batting1Name.UseVisualStyleBackColor = true;
            this.Batting1Name.CheckedChanged += new System.EventHandler(this.Batting1Name_CheckedChanged);
            // 
            // eventcreationTableAdapter1
            // 
            this.eventcreationTableAdapter1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = ".";
            // 
            // labelBall
            // 
            this.labelBall.AutoSize = true;
            this.labelBall.Location = new System.Drawing.Point(379, 35);
            this.labelBall.Name = "labelBall";
            this.labelBall.Size = new System.Drawing.Size(24, 13);
            this.labelBall.TabIndex = 9;
            this.labelBall.Text = "Ball";
            // 
            // labelOver
            // 
            this.labelOver.AutoSize = true;
            this.labelOver.Location = new System.Drawing.Point(343, 35);
            this.labelOver.Name = "labelOver";
            this.labelOver.Size = new System.Drawing.Size(30, 13);
            this.labelOver.TabIndex = 10;
            this.labelOver.Text = "Over";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Over";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ScoreCard
            // 
            this.ScoreCard.Location = new System.Drawing.Point(17, 262);
            this.ScoreCard.Name = "ScoreCard";
            this.ScoreCard.Size = new System.Drawing.Size(75, 23);
            this.ScoreCard.TabIndex = 18;
            this.ScoreCard.Text = "ScoreCard";
            this.ScoreCard.UseVisualStyleBackColor = true;
            this.ScoreCard.Click += new System.EventHandler(this.ScoreCard_Click);
            // 
            // dataGridViewBall
            // 
            this.dataGridViewBall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridViewBall.Location = new System.Drawing.Point(336, 315);
            this.dataGridViewBall.Name = "dataGridViewBall";
            this.dataGridViewBall.Size = new System.Drawing.Size(417, 150);
            this.dataGridViewBall.TabIndex = 20;
            // 
            // dataGridViewBat
            // 
            this.dataGridViewBat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewBat.Location = new System.Drawing.Point(3, 315);
            this.dataGridViewBat.Name = "dataGridViewBat";
            this.dataGridViewBat.Size = new System.Drawing.Size(322, 150);
            this.dataGridViewBat.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Run";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ball";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Name";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ball";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Run";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Wicket";
            this.Column7.Name = "Column7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Batting";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Bowling";
            // 
            // live_score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 489);
            this.Controls.Add(this.panel1);
            this.Name = "live_score";
            this.Text = "live_score";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.WicketCombo.ResumeLayout(false);
            this.WicketCombo.PerformLayout();
            this.RunGroupBox.ResumeLayout(false);
            this.RunGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label WicketLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label RunLabel;
        private System.Windows.Forms.Label BattingTeamLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Batting2Name;
        private System.Windows.Forms.RadioButton Batting1Name;
        private System.Windows.Forms.Label BowlerNameLvl;
        private System.Windows.Forms.GroupBox RunGroupBox;
        private System.Windows.Forms.RadioButton run6;
        private System.Windows.Forms.RadioButton WD;
        private System.Windows.Forms.RadioButton NB;
        private System.Windows.Forms.RadioButton LegalDelivery;
        private System.Windows.Forms.RadioButton run0;
        private System.Windows.Forms.RadioButton run1;
        private System.Windows.Forms.RadioButton run3;
        private System.Windows.Forms.RadioButton run2;
        private System.Windows.Forms.RadioButton run4;
        private CricketDBDataSetTableAdapters.eventcreationTableAdapter eventcreationTableAdapter1;
        private System.Windows.Forms.GroupBox WicketCombo;
        private System.Windows.Forms.ComboBox wicketComboBox;
        private System.Windows.Forms.Label labelWicket;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Label labelOver;
        private System.Windows.Forms.Label labelBall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ScoreCard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewBat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView dataGridViewBall;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}