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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.showTeamsButton = new System.Windows.Forms.Button();
            this.showGamesButton = new System.Windows.Forms.Button();
            this.showPlayersButton = new System.Windows.Forms.Button();
            this.addGamblerButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gamblerConfirmWagerButton = new System.Windows.Forms.Button();
            this.gamblerWagerUpDoewn = new System.Windows.Forms.NumericUpDown();
            this.gamblerTeamComboBox = new System.Windows.Forms.ComboBox();
            this.gamblerTeamLabel = new System.Windows.Forms.Label();
            this.gamblerAmountLabel = new System.Windows.Forms.Label();
            this.gamblerHeaderLabel = new System.Windows.Forms.Label();
            this.gamblerNameLabel = new System.Windows.Forms.Label();
            this.gamblerWagerLabel = new System.Windows.Forms.Label();
            this.selectGamblerComboBox = new System.Windows.Forms.ComboBox();
            this.overviewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamblerWagerUpDoewn)).BeginInit();
            this.SuspendLayout();
            // 
            // overviewGroupBox
            // 
            this.overviewGroupBox.Controls.Add(this.listBox1);
            this.overviewGroupBox.Controls.Add(this.showTeamsButton);
            this.overviewGroupBox.Controls.Add(this.showGamesButton);
            this.overviewGroupBox.Controls.Add(this.showPlayersButton);
            this.overviewGroupBox.Location = new System.Drawing.Point(12, 12);
            this.overviewGroupBox.Name = "overviewGroupBox";
            this.overviewGroupBox.Size = new System.Drawing.Size(371, 426);
            this.overviewGroupBox.TabIndex = 0;
            this.overviewGroupBox.TabStop = false;
            this.overviewGroupBox.Text = "Toernooi Overview";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(7, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(353, 308);
            this.listBox1.TabIndex = 5;
            // 
            // showTeamsButton
            // 
            this.showTeamsButton.Location = new System.Drawing.Point(246, 21);
            this.showTeamsButton.Name = "showTeamsButton";
            this.showTeamsButton.Size = new System.Drawing.Size(114, 49);
            this.showTeamsButton.TabIndex = 4;
            this.showTeamsButton.Text = "Teams";
            this.showTeamsButton.UseVisualStyleBackColor = true;
            // 
            // showGamesButton
            // 
            this.showGamesButton.Location = new System.Drawing.Point(126, 21);
            this.showGamesButton.Name = "showGamesButton";
            this.showGamesButton.Size = new System.Drawing.Size(114, 49);
            this.showGamesButton.TabIndex = 2;
            this.showGamesButton.Text = "Wedstrijden";
            this.showGamesButton.UseVisualStyleBackColor = true;
            // 
            // showPlayersButton
            // 
            this.showPlayersButton.Location = new System.Drawing.Point(6, 21);
            this.showPlayersButton.Name = "showPlayersButton";
            this.showPlayersButton.Size = new System.Drawing.Size(114, 49);
            this.showPlayersButton.TabIndex = 1;
            this.showPlayersButton.Text = "Spelers";
            this.showPlayersButton.UseVisualStyleBackColor = true;
            // 
            // addGamblerButton
            // 
            this.addGamblerButton.Location = new System.Drawing.Point(403, 33);
            this.addGamblerButton.Name = "addGamblerButton";
            this.addGamblerButton.Size = new System.Drawing.Size(170, 49);
            this.addGamblerButton.TabIndex = 3;
            this.addGamblerButton.Text = "Gokker Toevoegen";
            this.addGamblerButton.UseVisualStyleBackColor = true;
            // 
            // gamblerConfirmWagerButton
            // 
            this.gamblerConfirmWagerButton.Location = new System.Drawing.Point(403, 298);
            this.gamblerConfirmWagerButton.Name = "gamblerConfirmWagerButton";
            this.gamblerConfirmWagerButton.Size = new System.Drawing.Size(170, 49);
            this.gamblerConfirmWagerButton.TabIndex = 4;
            this.gamblerConfirmWagerButton.Text = "Inzetten";
            this.gamblerConfirmWagerButton.UseVisualStyleBackColor = true;
            // 
            // gamblerWagerUpDoewn
            // 
            this.gamblerWagerUpDoewn.Location = new System.Drawing.Point(478, 230);
            this.gamblerWagerUpDoewn.Name = "gamblerWagerUpDoewn";
            this.gamblerWagerUpDoewn.Size = new System.Drawing.Size(95, 22);
            this.gamblerWagerUpDoewn.TabIndex = 5;
            // 
            // gamblerTeamComboBox
            // 
            this.gamblerTeamComboBox.FormattingEnabled = true;
            this.gamblerTeamComboBox.Location = new System.Drawing.Point(478, 258);
            this.gamblerTeamComboBox.Name = "gamblerTeamComboBox";
            this.gamblerTeamComboBox.Size = new System.Drawing.Size(95, 24);
            this.gamblerTeamComboBox.TabIndex = 6;
            // 
            // gamblerTeamLabel
            // 
            this.gamblerTeamLabel.AutoSize = true;
            this.gamblerTeamLabel.Location = new System.Drawing.Point(400, 261);
            this.gamblerTeamLabel.Name = "gamblerTeamLabel";
            this.gamblerTeamLabel.Size = new System.Drawing.Size(44, 17);
            this.gamblerTeamLabel.TabIndex = 7;
            this.gamblerTeamLabel.Text = "Team";
            // 
            // gamblerAmountLabel
            // 
            this.gamblerAmountLabel.AutoSize = true;
            this.gamblerAmountLabel.Location = new System.Drawing.Point(400, 232);
            this.gamblerAmountLabel.Name = "gamblerAmountLabel";
            this.gamblerAmountLabel.Size = new System.Drawing.Size(38, 17);
            this.gamblerAmountLabel.TabIndex = 8;
            this.gamblerAmountLabel.Text = "Inzet";
            // 
            // gamblerHeaderLabel
            // 
            this.gamblerHeaderLabel.AutoSize = true;
            this.gamblerHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamblerHeaderLabel.Location = new System.Drawing.Point(400, 191);
            this.gamblerHeaderLabel.Name = "gamblerHeaderLabel";
            this.gamblerHeaderLabel.Size = new System.Drawing.Size(88, 20);
            this.gamblerHeaderLabel.TabIndex = 9;
            this.gamblerHeaderLabel.Text = "Gambling";
            // 
            // gamblerNameLabel
            // 
            this.gamblerNameLabel.AutoSize = true;
            this.gamblerNameLabel.Location = new System.Drawing.Point(400, 101);
            this.gamblerNameLabel.Name = "gamblerNameLabel";
            this.gamblerNameLabel.Size = new System.Drawing.Size(96, 17);
            this.gamblerNameLabel.TabIndex = 10;
            this.gamblerNameLabel.Text = "Speler naam: ";
            // 
            // gamblerWagerLabel
            // 
            this.gamblerWagerLabel.AutoSize = true;
            this.gamblerWagerLabel.Location = new System.Drawing.Point(527, 101);
            this.gamblerWagerLabel.Name = "gamblerWagerLabel";
            this.gamblerWagerLabel.Size = new System.Drawing.Size(38, 17);
            this.gamblerWagerLabel.TabIndex = 11;
            this.gamblerWagerLabel.Text = "Inzet";
            // 
            // selectGamblerComboBox
            // 
            this.selectGamblerComboBox.FormattingEnabled = true;
            this.selectGamblerComboBox.Location = new System.Drawing.Point(579, 46);
            this.selectGamblerComboBox.Name = "selectGamblerComboBox";
            this.selectGamblerComboBox.Size = new System.Drawing.Size(130, 24);
            this.selectGamblerComboBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectGamblerComboBox);
            this.Controls.Add(this.gamblerWagerLabel);
            this.Controls.Add(this.gamblerNameLabel);
            this.Controls.Add(this.gamblerHeaderLabel);
            this.Controls.Add(this.gamblerAmountLabel);
            this.Controls.Add(this.gamblerTeamLabel);
            this.Controls.Add(this.gamblerTeamComboBox);
            this.Controls.Add(this.gamblerWagerUpDoewn);
            this.Controls.Add(this.gamblerConfirmWagerButton);
            this.Controls.Add(this.overviewGroupBox);
            this.Controls.Add(this.addGamblerButton);
            this.Name = "Form1";
            this.Text = "Fifa Gok Applicatie";
            this.overviewGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gamblerWagerUpDoewn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox overviewGroupBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button showTeamsButton;
        private System.Windows.Forms.Button showGamesButton;
        private System.Windows.Forms.Button showPlayersButton;
        private System.Windows.Forms.Button addGamblerButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button gamblerConfirmWagerButton;
        private System.Windows.Forms.NumericUpDown gamblerWagerUpDoewn;
        private System.Windows.Forms.ComboBox gamblerTeamComboBox;
        private System.Windows.Forms.Label gamblerTeamLabel;
        private System.Windows.Forms.Label gamblerAmountLabel;
        private System.Windows.Forms.Label gamblerHeaderLabel;
        private System.Windows.Forms.Label gamblerNameLabel;
        private System.Windows.Forms.Label gamblerWagerLabel;
        private System.Windows.Forms.ComboBox selectGamblerComboBox;
    }
}

