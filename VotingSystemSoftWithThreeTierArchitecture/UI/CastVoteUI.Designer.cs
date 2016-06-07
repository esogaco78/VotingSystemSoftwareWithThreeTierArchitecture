namespace VotingSystemSoftWithThreeTierArchitecture.UI
{
    partial class CastVoteUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.castVoteButton = new System.Windows.Forms.Button();
            this.voterIDTextBox = new System.Windows.Forms.TextBox();
            this.candidateSymbolComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.candidateListDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidateListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.castVoteButton);
            this.groupBox1.Controls.Add(this.voterIDTextBox);
            this.groupBox1.Controls.Add(this.candidateSymbolComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voter Panel";
            // 
            // castVoteButton
            // 
            this.castVoteButton.Location = new System.Drawing.Point(38, 145);
            this.castVoteButton.Name = "castVoteButton";
            this.castVoteButton.Size = new System.Drawing.Size(290, 84);
            this.castVoteButton.TabIndex = 3;
            this.castVoteButton.Text = "Cast Vote";
            this.castVoteButton.UseVisualStyleBackColor = true;
            this.castVoteButton.Click += new System.EventHandler(this.castVoteButton_Click);
            // 
            // voterIDTextBox
            // 
            this.voterIDTextBox.Enabled = false;
            this.voterIDTextBox.Location = new System.Drawing.Point(106, 46);
            this.voterIDTextBox.Name = "voterIDTextBox";
            this.voterIDTextBox.Size = new System.Drawing.Size(171, 20);
            this.voterIDTextBox.TabIndex = 2;
            // 
            // candidateSymbolComboBox
            // 
            this.candidateSymbolComboBox.FormattingEnabled = true;
            this.candidateSymbolComboBox.Location = new System.Drawing.Point(106, 96);
            this.candidateSymbolComboBox.Name = "candidateSymbolComboBox";
            this.candidateSymbolComboBox.Size = new System.Drawing.Size(160, 21);
            this.candidateSymbolComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Symmbol of the Candidate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voter ID";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.candidateListDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(392, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 367);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of the Candidate";
            // 
            // candidateListDataGridView
            // 
            this.candidateListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidateListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.candidateListDataGridView.Location = new System.Drawing.Point(7, 20);
            this.candidateListDataGridView.Name = "candidateListDataGridView";
            this.candidateListDataGridView.Size = new System.Drawing.Size(345, 341);
            this.candidateListDataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Serial Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Candidate Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Candidate Symbol";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // CastVoteUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 389);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CastVoteUI";
            this.Text = "CastVoteUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CastVoteUI_FormClosing);
            this.Load += new System.EventHandler(this.CastVoteUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.candidateListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button castVoteButton;
        private System.Windows.Forms.TextBox voterIDTextBox;
        private System.Windows.Forms.ComboBox candidateSymbolComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView candidateListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}