namespace VotingSystemSoftWithThreeTierArchitecture.UI
{
    partial class CandidateLoginUI
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
            this.candidateSignInButton = new System.Windows.Forms.Button();
            this.candidatePasswordTextBox = new System.Windows.Forms.TextBox();
            this.candidateNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // candidateSignInButton
            // 
            this.candidateSignInButton.Location = new System.Drawing.Point(193, 100);
            this.candidateSignInButton.Name = "candidateSignInButton";
            this.candidateSignInButton.Size = new System.Drawing.Size(75, 23);
            this.candidateSignInButton.TabIndex = 7;
            this.candidateSignInButton.Text = "Sign In";
            this.candidateSignInButton.UseVisualStyleBackColor = true;
            this.candidateSignInButton.Click += new System.EventHandler(this.candidateSignInButton_Click);
            // 
            // candidatePasswordTextBox
            // 
            this.candidatePasswordTextBox.Location = new System.Drawing.Point(148, 52);
            this.candidatePasswordTextBox.Name = "candidatePasswordTextBox";
            this.candidatePasswordTextBox.Size = new System.Drawing.Size(191, 20);
            this.candidatePasswordTextBox.TabIndex = 6;
            // 
            // candidateNameTextBox
            // 
            this.candidateNameTextBox.Location = new System.Drawing.Point(148, 19);
            this.candidateNameTextBox.Name = "candidateNameTextBox";
            this.candidateNameTextBox.Size = new System.Drawing.Size(191, 20);
            this.candidateNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Candidate Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.candidateNameTextBox);
            this.groupBox1.Controls.Add(this.candidateSignInButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.candidatePasswordTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(130, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 141);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Candidate Login";
            // 
            // CandidateLoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 262);
            this.Controls.Add(this.groupBox1);
            this.Name = "CandidateLoginUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CandidateLoginUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CandidateLoginUI_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button candidateSignInButton;
        private System.Windows.Forms.TextBox candidatePasswordTextBox;
        private System.Windows.Forms.TextBox candidateNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}