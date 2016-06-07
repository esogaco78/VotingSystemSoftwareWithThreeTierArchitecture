namespace VotingSystemSoftWithThreeTierArchitecture.UI
{
    partial class ChooseLoginUI
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
            this.adminLoginButton = new System.Windows.Forms.Button();
            this.VoterLoginButton = new System.Windows.Forms.Button();
            this.CandidateLoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminLoginButton
            // 
            this.adminLoginButton.Location = new System.Drawing.Point(69, 81);
            this.adminLoginButton.Name = "adminLoginButton";
            this.adminLoginButton.Size = new System.Drawing.Size(227, 44);
            this.adminLoginButton.TabIndex = 0;
            this.adminLoginButton.Text = "Admin";
            this.adminLoginButton.UseVisualStyleBackColor = true;
            this.adminLoginButton.Click += new System.EventHandler(this.adminLoginButton_Click);
            // 
            // VoterLoginButton
            // 
            this.VoterLoginButton.Location = new System.Drawing.Point(69, 131);
            this.VoterLoginButton.Name = "VoterLoginButton";
            this.VoterLoginButton.Size = new System.Drawing.Size(227, 44);
            this.VoterLoginButton.TabIndex = 1;
            this.VoterLoginButton.Text = "Voter";
            this.VoterLoginButton.UseVisualStyleBackColor = true;
            this.VoterLoginButton.Click += new System.EventHandler(this.VoterLoginButton_Click);
            // 
            // CandidateLoginButton
            // 
            this.CandidateLoginButton.Location = new System.Drawing.Point(69, 181);
            this.CandidateLoginButton.Name = "CandidateLoginButton";
            this.CandidateLoginButton.Size = new System.Drawing.Size(227, 44);
            this.CandidateLoginButton.TabIndex = 2;
            this.CandidateLoginButton.Tag = "";
            this.CandidateLoginButton.Text = "Candidate";
            this.CandidateLoginButton.UseVisualStyleBackColor = true;
            this.CandidateLoginButton.Click += new System.EventHandler(this.CandidateLoginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Voting System";
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(389, 106);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(155, 94);
            this.resultButton.TabIndex = 3;
            this.resultButton.Text = "Result";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // ChooseLoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 260);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CandidateLoginButton);
            this.Controls.Add(this.VoterLoginButton);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.adminLoginButton);
            this.Name = "ChooseLoginUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseLoginUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseLoginUI_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminLoginButton;
        private System.Windows.Forms.Button VoterLoginButton;
        private System.Windows.Forms.Button CandidateLoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resultButton;
    }
}