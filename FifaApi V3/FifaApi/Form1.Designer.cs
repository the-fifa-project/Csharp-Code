namespace FifaApi
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
<<<<<<< HEAD
            this.getDataButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.inputNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.goalsLabel = new System.Windows.Forms.Label();
            this.winsLabel = new System.Windows.Forms.Label();
            this.lossesLabel = new System.Windows.Forms.Label();
            this.teamNamesList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // getDataButton
            // 
            this.getDataButton.Location = new System.Drawing.Point(118, 32);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(117, 36);
            this.getDataButton.TabIndex = 0;
            this.getDataButton.Text = "Get Team Data";
            this.getDataButton.UseVisualStyleBackColor = true;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(95, 113);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 20);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "label1";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(302, 116);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(0, 17);
            this.idLabel.TabIndex = 3;
            this.idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(88, 136);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(229, 36);
            this.listBox.TabIndex = 7;
            // 
            // inputNumber
            // 
            this.inputNumber.Location = new System.Drawing.Point(12, 40);
            this.inputNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.inputNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputNumber.Name = "inputNumber";
            this.inputNumber.Size = new System.Drawing.Size(100, 22);
            this.inputNumber.TabIndex = 8;
            this.inputNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Members:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select a team!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Goals:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Wins:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Losses:";
            // 
            // goalsLabel
            // 
            this.goalsLabel.AutoSize = true;
            this.goalsLabel.Location = new System.Drawing.Point(210, 178);
            this.goalsLabel.Name = "goalsLabel";
            this.goalsLabel.Size = new System.Drawing.Size(0, 17);
            this.goalsLabel.TabIndex = 17;
            this.goalsLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // winsLabel
            // 
            this.winsLabel.AutoSize = true;
            this.winsLabel.Location = new System.Drawing.Point(210, 220);
            this.winsLabel.Name = "winsLabel";
            this.winsLabel.Size = new System.Drawing.Size(0, 17);
            this.winsLabel.TabIndex = 18;
            // 
            // lossesLabel
            // 
            this.lossesLabel.AutoSize = true;
            this.lossesLabel.Location = new System.Drawing.Point(210, 262);
            this.lossesLabel.Name = "lossesLabel";
            this.lossesLabel.Size = new System.Drawing.Size(0, 17);
            this.lossesLabel.TabIndex = 19;
            // 
            // teamNamesList
            // 
            this.teamNamesList.FormattingEnabled = true;
            this.teamNamesList.ItemHeight = 16;
            this.teamNamesList.Location = new System.Drawing.Point(371, 40);
            this.teamNamesList.Name = "teamNamesList";
            this.teamNamesList.Size = new System.Drawing.Size(120, 132);
            this.teamNamesList.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "List of teams";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 310);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.teamNamesList);
            this.Controls.Add(this.lossesLabel);
            this.Controls.Add(this.winsLabel);
            this.Controls.Add(this.goalsLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputNumber);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.getDataButton);
            this.Name = "Form1";
            this.Text = "FIFA GAMBLE APPLICATION";
            ((System.ComponentModel.ISupportInitialize)(this.inputNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

=======
            this.getDataButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.inputNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.allMatchesListBox = new System.Windows.Forms.ListBox();
            this.gambleUserComboBox = new System.Windows.Forms.ComboBox();
            this.gamblingAmmountNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gambleButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.currencyLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.betOnTeam = new System.Windows.Forms.NumericUpDown();
            this.reloadMatchesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamblingAmmountNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betOnTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // getDataButton
            // 
            this.getDataButton.Location = new System.Drawing.Point(88, 26);
            this.getDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(88, 29);
            this.getDataButton.TabIndex = 0;
            this.getDataButton.Text = "Get Team Data";
            this.getDataButton.UseVisualStyleBackColor = true;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(71, 92);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 17);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "label1";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
<<<<<<< HEAD
            this.idLabel.Location = new System.Drawing.Point(445, 284);
=======
            this.idLabel.Location = new System.Drawing.Point(253, 110);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
>>>>>>> Gokken
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(35, 13);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "label2";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
<<<<<<< HEAD
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(99, 136);
=======
            this.listBox.Location = new System.Drawing.Point(66, 110);
            this.listBox.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Gokken
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(179, 148);
            this.listBox.TabIndex = 7;
            this.listBox.Click += new System.EventHandler(this.listBox_Click);
            // 
            // inputNumber
            // 
            this.inputNumber.Location = new System.Drawing.Point(9, 32);
            this.inputNumber.Margin = new System.Windows.Forms.Padding(2);
            this.inputNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.inputNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputNumber.Name = "inputNumber";
            this.inputNumber.Size = new System.Drawing.Size(75, 20);
            this.inputNumber.TabIndex = 8;
            this.inputNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Members:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select a team!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Goals:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "wins:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "loses:";
            // 
<<<<<<< HEAD
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
=======
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 179);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 213);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "label8";
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(276, 23);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(90, 29);
            this.addUserButton.TabIndex = 20;
            this.addUserButton.Text = "Add user";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(431, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Gambling:";
            // 
            // allMatchesListBox
            // 
            this.allMatchesListBox.FormattingEnabled = true;
            this.allMatchesListBox.Location = new System.Drawing.Point(542, 63);
            this.allMatchesListBox.Name = "allMatchesListBox";
            this.allMatchesListBox.Size = new System.Drawing.Size(140, 173);
            this.allMatchesListBox.TabIndex = 22;
            // 
            // gambleUserComboBox
            // 
            this.gambleUserComboBox.FormattingEnabled = true;
            this.gambleUserComboBox.Location = new System.Drawing.Point(393, 119);
            this.gambleUserComboBox.Name = "gambleUserComboBox";
            this.gambleUserComboBox.Size = new System.Drawing.Size(121, 21);
            this.gambleUserComboBox.TabIndex = 23;
            this.gambleUserComboBox.SelectedIndexChanged += new System.EventHandler(this.gambleUserComboBox_SelectedIndexChanged);
            this.gambleUserComboBox.Click += new System.EventHandler(this.gambleUserComboBox_Click);
            // 
            // gamblingAmmountNumUpDown
            // 
            this.gamblingAmmountNumUpDown.Location = new System.Drawing.Point(394, 146);
            this.gamblingAmmountNumUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.gamblingAmmountNumUpDown.Name = "gamblingAmmountNumUpDown";
            this.gamblingAmmountNumUpDown.Size = new System.Drawing.Size(120, 20);
            this.gamblingAmmountNumUpDown.TabIndex = 24;
            this.gamblingAmmountNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(539, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Match:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(334, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Gambler:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(334, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Ammount:";
            // 
            // gambleButton
            // 
            this.gambleButton.Location = new System.Drawing.Point(391, 203);
            this.gambleButton.Name = "gambleButton";
            this.gambleButton.Size = new System.Drawing.Size(123, 33);
            this.gambleButton.TabIndex = 28;
            this.gambleButton.Text = "Gamble!";
            this.gambleButton.UseVisualStyleBackColor = true;
            this.gambleButton.Click += new System.EventHandler(this.gambleButton_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(388, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Currency selected gambler:";
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyLabel.Location = new System.Drawing.Point(388, 63);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(14, 13);
            this.currencyLabel.TabIndex = 30;
            this.currencyLabel.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(337, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Team:";
            // 
            // betOnTeam
            // 
            this.betOnTeam.Location = new System.Drawing.Point(392, 176);
            this.betOnTeam.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.betOnTeam.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.betOnTeam.Name = "betOnTeam";
            this.betOnTeam.Size = new System.Drawing.Size(120, 20);
            this.betOnTeam.TabIndex = 32;
            this.betOnTeam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // reloadMatchesButton
            // 
            this.reloadMatchesButton.Location = new System.Drawing.Point(607, 37);
            this.reloadMatchesButton.Name = "reloadMatchesButton";
            this.reloadMatchesButton.Size = new System.Drawing.Size(75, 23);
            this.reloadMatchesButton.TabIndex = 33;
            this.reloadMatchesButton.Text = "Reload";
            this.reloadMatchesButton.UseVisualStyleBackColor = true;
            this.reloadMatchesButton.Click += new System.EventHandler(this.reloadMatchesButton_Click);
>>>>>>> Gokken
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(503, 310);
            this.Controls.Add(this.button1);
=======
            this.ClientSize = new System.Drawing.Size(694, 252);
            this.Controls.Add(this.reloadMatchesButton);
            this.Controls.Add(this.betOnTeam);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.currencyLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gambleButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gamblingAmmountNumUpDown);
            this.Controls.Add(this.gambleUserComboBox);
            this.Controls.Add(this.allMatchesListBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
>>>>>>> Gokken
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputNumber);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.getDataButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "FIFA GAMBLE APPLICATION";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamblingAmmountNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betOnTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

>>>>>>> master
        }

        #endregion

        private System.Windows.Forms.Button getDataButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.NumericUpDown inputNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
<<<<<<< HEAD
        private System.Windows.Forms.Label goalsLabel;
        private System.Windows.Forms.Label winsLabel;
        private System.Windows.Forms.Label lossesLabel;
        private System.Windows.Forms.ListBox teamNamesList;
        private System.Windows.Forms.Label label6;
=======
<<<<<<< HEAD
        private System.Windows.Forms.Button button1;
=======
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox allMatchesListBox;
        private System.Windows.Forms.ComboBox gambleUserComboBox;
        private System.Windows.Forms.NumericUpDown gamblingAmmountNumUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button gambleButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown betOnTeam;
        private System.Windows.Forms.Button reloadMatchesButton;
>>>>>>> Gokken
>>>>>>> master
    }
}

