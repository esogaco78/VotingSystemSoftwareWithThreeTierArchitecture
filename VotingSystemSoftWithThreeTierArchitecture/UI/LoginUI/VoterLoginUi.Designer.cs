namespace VotingSystemSoftWithThreeTierArchitecture.UI
{
    partial class VoterLoginUi
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
            this.voterSignInButton = new System.Windows.Forms.Button();
            this.voterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.voterIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // voterSignInButton
            // 
            this.voterSignInButton.Location = new System.Drawing.Point(135, 111);
            this.voterSignInButton.Name = "voterSignInButton";
            this.voterSignInButton.Size = new System.Drawing.Size(75, 23);
            this.voterSignInButton.TabIndex = 12;
            this.voterSignInButton.Text = "Sign In";
            this.voterSignInButton.UseVisualStyleBackColor = true;
            this.voterSignInButton.Click += new System.EventHandler(this.voterSignInButton_Click);
            // 
            // voterPasswordTextBox
            // 
            this.voterPasswordTextBox.Location = new System.Drawing.Point(90, 63);
            this.voterPasswordTextBox.Name = "voterPasswordTextBox";
            this.voterPasswordTextBox.Size = new System.Drawing.Size(191, 20);
            this.voterPasswordTextBox.TabIndex = 11;
            // 
            // voterIDTextBox
            // 
            this.voterIDTextBox.Location = new System.Drawing.Point(90, 30);
            this.voterIDTextBox.Name = "voterIDTextBox";
            this.voterIDTextBox.Size = new System.Drawing.Size(191, 20);
            this.voterIDTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Voter ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.voterSignInButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.voterPasswordTextBox);
            this.groupBox1.Controls.Add(this.voterIDTextBox);
            this.groupBox1.Location = new System.Drawing.Point(79, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 145);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voter Login";
            // 
            // VoterLoginUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 217);
            this.Controls.Add(this.groupBox1);
            this.Name = "VoterLoginUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoterLoginUi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VoterLoginUi_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button voterSignInButton;
        private System.Windows.Forms.TextBox voterPasswordTextBox;
        private System.Windows.Forms.TextBox voterIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}