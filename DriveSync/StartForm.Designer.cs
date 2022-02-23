namespace DriveSync
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.SettingsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SyncFolderLabel = new System.Windows.Forms.Label();
            this.SyncButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.RepeatTimeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NextSyncLabel = new System.Windows.Forms.Label();
            this.LastSyncedLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.SystemColors.Control;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.Location = new System.Drawing.Point(749, 12);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(50, 50);
            this.SettingsButton.TabIndex = 0;
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sync Folder";
            // 
            // SyncFolderLabel
            // 
            this.SyncFolderLabel.AutoSize = true;
            this.SyncFolderLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SyncFolderLabel.Location = new System.Drawing.Point(126, 46);
            this.SyncFolderLabel.Name = "SyncFolderLabel";
            this.SyncFolderLabel.Size = new System.Drawing.Size(139, 28);
            this.SyncFolderLabel.TabIndex = 2;
            this.SyncFolderLabel.Text = "Not specified";
            // 
            // SyncButton
            // 
            this.SyncButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SyncButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SyncButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SyncButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SyncButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SyncButton.Location = new System.Drawing.Point(220, 101);
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.Size = new System.Drawing.Size(371, 106);
            this.SyncButton.TabIndex = 4;
            this.SyncButton.Text = "Sync";
            this.SyncButton.UseVisualStyleBackColor = false;
            this.SyncButton.Click += new System.EventHandler(this.SyncButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SyncButton);
            this.panel1.Location = new System.Drawing.Point(12, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 283);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Repeat Time";
            // 
            // RepeatTimeLabel
            // 
            this.RepeatTimeLabel.AutoSize = true;
            this.RepeatTimeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RepeatTimeLabel.Location = new System.Drawing.Point(126, 87);
            this.RepeatTimeLabel.Name = "RepeatTimeLabel";
            this.RepeatTimeLabel.Size = new System.Drawing.Size(139, 28);
            this.RepeatTimeLabel.TabIndex = 7;
            this.RepeatTimeLabel.Text = "Not specified";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Next Sync";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last synced";
            // 
            // NextSyncLabel
            // 
            this.NextSyncLabel.AutoSize = true;
            this.NextSyncLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NextSyncLabel.Location = new System.Drawing.Point(126, 130);
            this.NextSyncLabel.Name = "NextSyncLabel";
            this.NextSyncLabel.Size = new System.Drawing.Size(139, 28);
            this.NextSyncLabel.TabIndex = 10;
            this.NextSyncLabel.Text = "Not specified";
            // 
            // LastSyncedLabel
            // 
            this.LastSyncedLabel.AutoSize = true;
            this.LastSyncedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LastSyncedLabel.Location = new System.Drawing.Point(126, 173);
            this.LastSyncedLabel.Name = "LastSyncedLabel";
            this.LastSyncedLabel.Size = new System.Drawing.Size(139, 28);
            this.LastSyncedLabel.TabIndex = 11;
            this.LastSyncedLabel.Text = "Not specified";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 515);
            this.Controls.Add(this.LastSyncedLabel);
            this.Controls.Add(this.NextSyncLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RepeatTimeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SyncFolderLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SettingsButton);
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.Text = "Home - DriveSync";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SettingsButton;
        private Label label1;
        private Label SyncFolderLabel;
        private Button SyncButton;
        private Panel panel1;
        private Label label2;
        private Label RepeatTimeLabel;
        private Label label3;
        private Label label4;
        private Label NextSyncLabel;
        private Label LastSyncedLabel;
    }
}