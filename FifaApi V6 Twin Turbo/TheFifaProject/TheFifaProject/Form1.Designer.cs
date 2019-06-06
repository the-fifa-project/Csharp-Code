namespace TheFifaProject
{
    partial class Form1
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
            this.overviewGroupBox = new System.Windows.Forms.GroupBox();
            this.overviewListBox = new System.Windows.Forms.ListBox();
            this.showTeamsButton = new System.Windows.Forms.Button();
            this.showGamesButton = new System.Windows.Forms.Button();
            this.addGamblerButton = new System.Windows.Forms.Button();
            this.gamblerConfirmWagerButton = new System.Windows.Forms.Button();
            this.gamblerWagerUpDown = new System.Windows.Forms.NumericUpDown();
            this.gamblerTeamComboBox = new System.Windows.Forms.ComboBox();
            this.gamblerTeamLabel = new System.Windows.Forms.Label();
            this.gamblerAmountLabel = new System.Windows.Forms.Label();
            this.gamblerHeaderLabel = new System.Windows.Forms.Label();
            this.gamblerNameLabel = new System.Windows.Forms.Label();
            this.gamblerCurrencyLabel = new System.Windows.Forms.Label();
            this.selectGamblerComboBox = new System.Windows.Forms.ComboBox();
            this.teamOneScoreUpDown = new System.Windows.Forms.NumericUpDown();
            this.payoutComboBox = new System.Windows.Forms.ComboBox();
            this.teamTwoScoreUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.payoutButton = new System.Windows.Forms.Button();
            this.betHistoryListBox = new System.Windows.Forms.ListBox();
            this.overviewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamblerWagerUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamOneScoreUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamTwoScoreUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // overviewGroupBox
            // 
            this.overviewGroupBox.Controls.Add(this.overviewListBox);
            this.overviewGroupBox.Controls.Add(this.showTeamsButton);
            this.overviewGroupBox.Controls.Add(this.showGamesButton);
            this.overviewGroupBox.Location = new System.Drawing.Point(9, 10);
            this.overviewGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.overviewGroupBox.Name = "overviewGroupBox";
            this.overviewGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.overviewGroupBox.Size = new System.Drawing.Size(278, 346);
            this.overviewGroupBox.TabIndex = 0;
            this.overviewGroupBox.TabStop = false;
            this.overviewGroupBox.Text = "Toernooi Overview";
            // 
            // overviewListBox
            // 
            this.overviewListBox.FormattingEnabled = true;
            this.overviewListBox.Location = new System.Drawing.Point(5, 72);
            this.overviewListBox.Margin = new System.Windows.Forms.Padding(2);
            this.overviewListBox.Name = "overviewListBox";
            this.overviewListBox.Size = new System.Drawing.Size(266, 251);
            this.overviewListBox.TabIndex = 5;
            this.overviewListBox.SelectedIndexChanged += new System.EventHandler(this.overviewListBox_SelectedIndexChanged);
            // 
            // showTeamsButton
            // 
            this.showTeamsButton.Location = new System.Drawing.Point(141, 27);
            this.showTeamsButton.Margin = new System.Windows.Forms.Padding(2);
            this.showTeamsButton.Name = "showTeamsButton";
            this.showTeamsButton.Size = new System.Drawing.Size(130, 40);
            this.showTeamsButton.TabIndex = 4;
            this.showTeamsButton.Text = "Teams";
            this.showTeamsButton.UseVisualStyleBackColor = true;
            this.showTeamsButton.Click += new System.EventHandler(this.showTeamsButton_Click);
            // 
            // showGamesButton
            // 
            this.showGamesButton.Location = new System.Drawing.Point(5, 27);
            this.showGamesButton.Margin = new System.Windows.Forms.Padding(2);
            this.showGamesButton.Name = "showGamesButton";
            this.showGamesButton.Size = new System.Drawing.Size(130, 40);
            this.showGamesButton.TabIndex = 2;
            this.showGamesButton.Text = "Wedstrijden";
            this.showGamesButton.UseVisualStyleBackColor = true;
            this.showGamesButton.Click += new System.EventHandler(this.showGamesButton_Click);
            // 
            // addGamblerButton
            // 
            this.addGamblerButton.Location = new System.Drawing.Point(302, 27);
            this.addGamblerButton.Margin = new System.Windows.Forms.Padding(2);
            this.addGamblerButton.Name = "addGamblerButton";
            this.addGamblerButton.Size = new System.Drawing.Size(128, 40);
            this.addGamblerButton.TabIndex = 3;
            this.addGamblerButton.Text = "Gokker Toevoegen";
            this.addGamblerButton.UseVisualStyleBackColor = true;
            this.addGamblerButton.Click += new System.EventHandler(this.addGamblerButton_Click);
            // 
            // gamblerConfirmWagerButton
            // 
            this.gamblerConfirmWagerButton.Location = new System.Drawing.Point(302, 293);
            this.gamblerConfirmWagerButton.Margin = new System.Windows.Forms.Padding(2);
            this.gamblerConfirmWagerButton.Name = "gamblerConfirmWagerButton";
            this.gamblerConfirmWagerButton.Size = new System.Drawing.Size(128, 40);
            this.gamblerConfirmWagerButton.TabIndex = 4;
            this.gamblerConfirmWagerButton.Text = "Inzetten";
            this.gamblerConfirmWagerButton.UseVisualStyleBackColor = true;
            this.gamblerConfirmWagerButton.Click += new System.EventHandler(this.gamblerConfirmWagerButton_Click);
            // 
            // gamblerWagerUpDown
            // 
            this.gamblerWagerUpDown.Location = new System.Drawing.Point(358, 187);
            this.gamblerWagerUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.gamblerWagerUpDown.Name = "gamblerWagerUpDown";
            this.gamblerWagerUpDown.Size = new System.Drawing.Size(71, 20);
            this.gamblerWagerUpDown.TabIndex = 5;
            // 
            // gamblerTeamComboBox
            // 
            this.gamblerTeamComboBox.FormattingEnabled = true;
            this.gamblerTeamComboBox.Location = new System.Drawing.Point(358, 210);
            this.gamblerTeamComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.gamblerTeamComboBox.Name = "gamblerTeamComboBox";
            this.gamblerTeamComboBox.Size = new System.Drawing.Size(72, 21);
            this.gamblerTeamComboBox.TabIndex = 6;
            // 
            // gamblerTeamLabel
            // 
            this.gamblerTeamLabel.AutoSize = true;
            this.gamblerTeamLabel.Location = new System.Drawing.Point(300, 212);
            this.gamblerTeamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gamblerTeamLabel.Name = "gamblerTeamLabel";
            this.gamblerTeamLabel.Size = new System.Drawing.Size(34, 13);
            this.gamblerTeamLabel.TabIndex = 7;
            this.gamblerTeamLabel.Text = "Team";
            // 
            // gamblerAmountLabel
            // 
            this.gamblerAmountLabel.AutoSize = true;
            this.gamblerAmountLabel.Location = new System.Drawing.Point(300, 188);
            this.gamblerAmountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gamblerAmountLabel.Name = "gamblerAmountLabel";
            this.gamblerAmountLabel.Size = new System.Drawing.Size(30, 13);
            this.gamblerAmountLabel.TabIndex = 8;
            this.gamblerAmountLabel.Text = "Inzet";
            // 
            // gamblerHeaderLabel
            // 
            this.gamblerHeaderLabel.AutoSize = true;
            this.gamblerHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamblerHeaderLabel.Location = new System.Drawing.Point(300, 155);
            this.gamblerHeaderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gamblerHeaderLabel.Name = "gamblerHeaderLabel";
            this.gamblerHeaderLabel.Size = new System.Drawing.Size(76, 17);
            this.gamblerHeaderLabel.TabIndex = 9;
            this.gamblerHeaderLabel.Text = "Gambling";
            // 
            // gamblerNameLabel
            // 
            this.gamblerNameLabel.AutoSize = true;
            this.gamblerNameLabel.Location = new System.Drawing.Point(300, 82);
            this.gamblerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gamblerNameLabel.Name = "gamblerNameLabel";
            this.gamblerNameLabel.Size = new System.Drawing.Size(72, 13);
            this.gamblerNameLabel.TabIndex = 10;
            this.gamblerNameLabel.Text = "Speler naam: ";
            // 
            // gamblerCurrencyLabel
            // 
            this.gamblerCurrencyLabel.AutoSize = true;
            this.gamblerCurrencyLabel.Location = new System.Drawing.Point(395, 82);
            this.gamblerCurrencyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gamblerCurrencyLabel.Name = "gamblerCurrencyLabel";
            this.gamblerCurrencyLabel.Size = new System.Drawing.Size(30, 13);
            this.gamblerCurrencyLabel.TabIndex = 11;
            this.gamblerCurrencyLabel.Text = "Inzet";
            // 
            // selectGamblerComboBox
            // 
            this.selectGamblerComboBox.FormattingEnabled = true;
            this.selectGamblerComboBox.Location = new System.Drawing.Point(451, 38);
            this.selectGamblerComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectGamblerComboBox.Name = "selectGamblerComboBox";
            this.selectGamblerComboBox.Size = new System.Drawing.Size(98, 21);
            this.selectGamblerComboBox.TabIndex = 12;
            this.selectGamblerComboBox.SelectedIndexChanged += new System.EventHandler(this.selectGamblerComboBox_SelectedIndexChanged);
            this.selectGamblerComboBox.Click += new System.EventHandler(this.selectGamblerComboBox_Click);
            // 
            // teamOneScoreUpDown
            // 
            this.teamOneScoreUpDown.Location = new System.Drawing.Point(302, 263);
            this.teamOneScoreUpDown.Name = "teamOneScoreUpDown";
            this.teamOneScoreUpDown.Size = new System.Drawing.Size(43, 20);
            this.teamOneScoreUpDown.TabIndex = 13;
            // 
            // payoutComboBox
            // 
            this.payoutComboBox.FormattingEnabled = true;
            this.payoutComboBox.Location = new System.Drawing.Point(303, 236);
            this.payoutComboBox.Name = "payoutComboBox";
            this.payoutComboBox.Size = new System.Drawing.Size(127, 21);
            this.payoutComboBox.TabIndex = 14;
            this.payoutComboBox.SelectedIndexChanged += new System.EventHandler(this.payoutComboBox_SelectedIndexChanged);
            // 
            // teamTwoScoreUpDown
            // 
            this.teamTwoScoreUpDown.Location = new System.Drawing.Point(386, 263);
            this.teamTwoScoreUpDown.Name = "teamTwoScoreUpDown";
            this.teamTwoScoreUpDown.Size = new System.Drawing.Size(43, 20);
            this.teamTwoScoreUpDown.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "-";
            // 
            // payoutButton
            // 
            this.payoutButton.Location = new System.Drawing.Point(451, 293);
            this.payoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.payoutButton.Name = "payoutButton";
            this.payoutButton.Size = new System.Drawing.Size(128, 40);
            this.payoutButton.TabIndex = 17;
            this.payoutButton.Text = "Uitbetalen";
            this.payoutButton.UseVisualStyleBackColor = true;
            this.payoutButton.Click += new System.EventHandler(this.payoutButton_Click);
            // 
            // betHistoryListBox
            // 
            this.betHistoryListBox.FormattingEnabled = true;
            this.betHistoryListBox.Location = new System.Drawing.Point(451, 76);
            this.betHistoryListBox.Name = "betHistoryListBox";
            this.betHistoryListBox.Size = new System.Drawing.Size(128, 212);
            this.betHistoryListBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.betHistoryListBox);
            this.Controls.Add(this.payoutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamTwoScoreUpDown);
            this.Controls.Add(this.payoutComboBox);
            this.Controls.Add(this.teamOneScoreUpDown);
            this.Controls.Add(this.selectGamblerComboBox);
            this.Controls.Add(this.gamblerCurrencyLabel);
            this.Controls.Add(this.gamblerNameLabel);
            this.Controls.Add(this.gamblerHeaderLabel);
            this.Controls.Add(this.gamblerAmountLabel);
            this.Controls.Add(this.gamblerTeamLabel);
            this.Controls.Add(this.gamblerTeamComboBox);
            this.Controls.Add(this.gamblerWagerUpDown);
            this.Controls.Add(this.gamblerConfirmWagerButton);
            this.Controls.Add(this.overviewGroupBox);
            this.Controls.Add(this.addGamblerButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Fifa gok applicatie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.overviewGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gamblerWagerUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamOneScoreUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamTwoScoreUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox overviewGroupBox;
        private System.Windows.Forms.ListBox overviewListBox;
        private System.Windows.Forms.Button showTeamsButton;
        private System.Windows.Forms.Button showGamesButton;
        private System.Windows.Forms.Button addGamblerButton;
        private System.Windows.Forms.Button gamblerConfirmWagerButton;
        private System.Windows.Forms.NumericUpDown gamblerWagerUpDown;
        private System.Windows.Forms.ComboBox gamblerTeamComboBox;
        private System.Windows.Forms.Label gamblerTeamLabel;
        private System.Windows.Forms.Label gamblerAmountLabel;
        private System.Windows.Forms.Label gamblerHeaderLabel;
        private System.Windows.Forms.Label gamblerNameLabel;
        private System.Windows.Forms.Label gamblerCurrencyLabel;
        private System.Windows.Forms.ComboBox selectGamblerComboBox;
        private System.Windows.Forms.NumericUpDown teamOneScoreUpDown;
        private System.Windows.Forms.ComboBox payoutComboBox;
        private System.Windows.Forms.NumericUpDown teamTwoScoreUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button payoutButton;
        private System.Windows.Forms.ListBox betHistoryListBox;
    }
}

