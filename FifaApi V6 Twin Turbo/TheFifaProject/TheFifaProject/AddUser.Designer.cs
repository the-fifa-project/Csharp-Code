namespace TheFifaProject
{
    partial class AddUser
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
            this.addGablerHead = new System.Windows.Forms.Label();
            this.addgamblerLabel = new System.Windows.Forms.Label();
            this.gamblerNameTextBox = new System.Windows.Forms.TextBox();
            this.addGamblerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addGablerHead
            // 
            this.addGablerHead.AutoSize = true;
            this.addGablerHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGablerHead.Location = new System.Drawing.Point(12, 9);
            this.addGablerHead.Name = "addGablerHead";
            this.addGablerHead.Size = new System.Drawing.Size(172, 25);
            this.addGablerHead.TabIndex = 2;
            this.addGablerHead.Text = "Gokker toevoegen";
            // 
            // addgamblerLabel
            // 
            this.addgamblerLabel.AutoSize = true;
            this.addgamblerLabel.Location = new System.Drawing.Point(14, 55);
            this.addgamblerLabel.Name = "addgamblerLabel";
            this.addgamblerLabel.Size = new System.Drawing.Size(76, 13);
            this.addgamblerLabel.TabIndex = 3;
            this.addgamblerLabel.Text = "Gokkersnaam:";
            // 
            // gamblerNameTextBox
            // 
            this.gamblerNameTextBox.Location = new System.Drawing.Point(96, 52);
            this.gamblerNameTextBox.Name = "gamblerNameTextBox";
            this.gamblerNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.gamblerNameTextBox.TabIndex = 4;
            // 
            // addGamblerButton
            // 
            this.addGamblerButton.Location = new System.Drawing.Point(17, 99);
            this.addGamblerButton.Name = "addGamblerButton";
            this.addGamblerButton.Size = new System.Drawing.Size(216, 37);
            this.addGamblerButton.TabIndex = 5;
            this.addGamblerButton.Text = "Toevoegen!";
            this.addGamblerButton.UseVisualStyleBackColor = true;
            this.addGamblerButton.Click += new System.EventHandler(this.addGamblerButton_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 153);
            this.Controls.Add(this.addGamblerButton);
            this.Controls.Add(this.gamblerNameTextBox);
            this.Controls.Add(this.addgamblerLabel);
            this.Controls.Add(this.addGablerHead);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addGablerHead;
        private System.Windows.Forms.Label addgamblerLabel;
        private System.Windows.Forms.TextBox gamblerNameTextBox;
        private System.Windows.Forms.Button addGamblerButton;
    }
}