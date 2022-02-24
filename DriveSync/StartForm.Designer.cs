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
            this.SyncButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.RepeatSyncLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NextSyncLabel = new System.Windows.Forms.Label();
            this.LastSyncedLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentlySyncingLabel = new System.Windows.Forms.Label();
            this.CurrentRemoteLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InQueueLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
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
            // SyncButton
            // 
            this.SyncButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SyncButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SyncButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SyncButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SyncButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SyncButton.Location = new System.Drawing.Point(220, 14);
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.Size = new System.Drawing.Size(371, 106);
            this.SyncButton.TabIndex = 4;
            this.SyncButton.Text = "Sync";
            this.SyncButton.UseVisualStyleBackColor = false;
            this.SyncButton.Click += new System.EventHandler(this.SyncButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.SyncButton);
            this.panel1.Location = new System.Drawing.Point(12, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 197);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Repeat Sync";
            // 
            // RepeatSyncLabel
            // 
            this.RepeatSyncLabel.AutoSize = true;
            this.RepeatSyncLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RepeatSyncLabel.Location = new System.Drawing.Point(147, 23);
            this.RepeatSyncLabel.Name = "RepeatSyncLabel";
            this.RepeatSyncLabel.Size = new System.Drawing.Size(139, 28);
            this.RepeatSyncLabel.TabIndex = 7;
            this.RepeatSyncLabel.Text = "Not specified";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Next Sync";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last synced";
            // 
            // NextSyncLabel
            // 
            this.NextSyncLabel.AutoSize = true;
            this.NextSyncLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NextSyncLabel.Location = new System.Drawing.Point(147, 61);
            this.NextSyncLabel.Name = "NextSyncLabel";
            this.NextSyncLabel.Size = new System.Drawing.Size(101, 28);
            this.NextSyncLabel.TabIndex = 10;
            this.NextSyncLabel.Text = "Unknown";
            // 
            // LastSyncedLabel
            // 
            this.LastSyncedLabel.AutoSize = true;
            this.LastSyncedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LastSyncedLabel.Location = new System.Drawing.Point(147, 99);
            this.LastSyncedLabel.Name = "LastSyncedLabel";
            this.LastSyncedLabel.Size = new System.Drawing.Size(101, 28);
            this.LastSyncedLabel.TabIndex = 11;
            this.LastSyncedLabel.Text = "Unknown";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Currently Syncing";
            // 
            // CurrentlySyncingLabel
            // 
            this.CurrentlySyncingLabel.AutoSize = true;
            this.CurrentlySyncingLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentlySyncingLabel.Location = new System.Drawing.Point(147, 137);
            this.CurrentlySyncingLabel.Name = "CurrentlySyncingLabel";
            this.CurrentlySyncingLabel.Size = new System.Drawing.Size(63, 28);
            this.CurrentlySyncingLabel.TabIndex = 13;
            this.CurrentlySyncingLabel.Text = "None";
            // 
            // CurrentRemoteLabel
            // 
            this.CurrentRemoteLabel.AutoSize = true;
            this.CurrentRemoteLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentRemoteLabel.Location = new System.Drawing.Point(147, 175);
            this.CurrentRemoteLabel.Name = "CurrentRemoteLabel";
            this.CurrentRemoteLabel.Size = new System.Drawing.Size(63, 28);
            this.CurrentRemoteLabel.TabIndex = 15;
            this.CurrentRemoteLabel.Text = "None";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Current Remote";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "In Queue";
            // 
            // InQueueLabel
            // 
            this.InQueueLabel.AutoSize = true;
            this.InQueueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InQueueLabel.Location = new System.Drawing.Point(147, 213);
            this.InQueueLabel.Name = "InQueueLabel";
            this.InQueueLabel.Size = new System.Drawing.Size(24, 28);
            this.InQueueLabel.TabIndex = 17;
            this.InQueueLabel.Text = "0";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CancelButton.Location = new System.Drawing.Point(290, 126);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(230, 52);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 515);
            this.Controls.Add(this.InQueueLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CurrentRemoteLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CurrentlySyncingLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastSyncedLabel);
            this.Controls.Add(this.NextSyncLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RepeatSyncLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
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
        private Button SyncButton;
        private Panel panel1;
        private Label label2;
        private Label RepeatSyncLabel;
        private Label label3;
        private Label label4;
        private Label NextSyncLabel;
        private Label LastSyncedLabel;
        private Label label1;
        private Label CurrentlySyncingLabel;
        private Label CurrentRemoteLabel;
        private Label label6;
        private Label label5;
        private Label InQueueLabel;
        private Button CancelButton;
    }
}