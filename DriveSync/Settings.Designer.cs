namespace DriveSync
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SelectRCloneButton = new System.Windows.Forms.Button();
            this.RCloneConfigTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RepeatSyncTxt = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.TestCmbx = new System.Windows.Forms.ComboBox();
            this.FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddMoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // SelectRCloneButton
            // 
            this.SelectRCloneButton.Location = new System.Drawing.Point(696, 62);
            this.SelectRCloneButton.Name = "SelectRCloneButton";
            this.SelectRCloneButton.Size = new System.Drawing.Size(94, 48);
            this.SelectRCloneButton.TabIndex = 6;
            this.SelectRCloneButton.Text = "Select";
            this.SelectRCloneButton.UseVisualStyleBackColor = true;
            this.SelectRCloneButton.Click += new System.EventHandler(this.SelectRCloneButton_Click);
            // 
            // RCloneConfigTxt
            // 
            this.RCloneConfigTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RCloneConfigTxt.Location = new System.Drawing.Point(121, 64);
            this.RCloneConfigTxt.Multiline = true;
            this.RCloneConfigTxt.Name = "RCloneConfigTxt";
            this.RCloneConfigTxt.ReadOnly = true;
            this.RCloneConfigTxt.Size = new System.Drawing.Size(569, 43);
            this.RCloneConfigTxt.TabIndex = 1;
            this.RCloneConfigTxt.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "RClone Path";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveButton.Location = new System.Drawing.Point(87, 752);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(291, 52);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 697);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Repeat Sync";
            // 
            // RepeatSyncTxt
            // 
            this.RepeatSyncTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RepeatSyncTxt.Location = new System.Drawing.Point(127, 687);
            this.RepeatSyncTxt.Multiline = true;
            this.RepeatSyncTxt.Name = "RepeatSyncTxt";
            this.RepeatSyncTxt.PlaceholderText = "Enter time in milliseconds";
            this.RepeatSyncTxt.Size = new System.Drawing.Size(537, 43);
            this.RepeatSyncTxt.TabIndex = 2;
            this.RepeatSyncTxt.TextChanged += new System.EventHandler(this.RepeatSyncTxt_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(670, 697);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "in Milliseconds";
            // 
            // TestCmbx
            // 
            this.TestCmbx.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TestCmbx.FormattingEnabled = true;
            this.TestCmbx.Items.AddRange(new object[] {
            "Hello",
            "World"});
            this.TestCmbx.Location = new System.Drawing.Point(747, 570);
            this.TestCmbx.Name = "TestCmbx";
            this.TestCmbx.Size = new System.Drawing.Size(229, 45);
            this.TestCmbx.TabIndex = 10;
            // 
            // FlowLayoutPanel
            // 
            this.FlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayoutPanel.Location = new System.Drawing.Point(12, 113);
            this.FlowLayoutPanel.Name = "FlowLayoutPanel";
            this.FlowLayoutPanel.Size = new System.Drawing.Size(1091, 328);
            this.FlowLayoutPanel.TabIndex = 11;
            // 
            // AddMoreButton
            // 
            this.AddMoreButton.Image = ((System.Drawing.Image)(resources.GetObject("AddMoreButton.Image")));
            this.AddMoreButton.Location = new System.Drawing.Point(1041, 62);
            this.AddMoreButton.Name = "AddMoreButton";
            this.AddMoreButton.Size = new System.Drawing.Size(62, 48);
            this.AddMoreButton.TabIndex = 13;
            this.AddMoreButton.UseVisualStyleBackColor = true;
            this.AddMoreButton.Click += new System.EventHandler(this.AddMoreButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 949);
            this.Controls.Add(this.AddMoreButton);
            this.Controls.Add(this.FlowLayoutPanel);
            this.Controls.Add(this.TestCmbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RepeatSyncTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SelectRCloneButton);
            this.Controls.Add(this.RCloneConfigTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings - DriveSync";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private FolderBrowserDialog folderBrowserDialog;
        private Button SelectRCloneButton;
        private TextBox RCloneConfigTxt;
        private Label label3;
        private Button SaveButton;
        private Label label4;
        private TextBox RepeatSyncTxt;
        private OpenFileDialog openFileDialog;
        private Label label5;
        private ComboBox TestCmbx;
        private FlowLayoutPanel FlowLayoutPanel;
        private Button AddMoreButton;
    }
}