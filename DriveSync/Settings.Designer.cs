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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectFolderTxt = new System.Windows.Forms.TextBox();
            this.BrowseFolderButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SelectRCloneButton = new System.Windows.Forms.Button();
            this.RCloneConfigTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Folder to sync";
            // 
            // SelectFolderTxt
            // 
            this.SelectFolderTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectFolderTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectFolderTxt.Location = new System.Drawing.Point(119, 87);
            this.SelectFolderTxt.Multiline = true;
            this.SelectFolderTxt.Name = "SelectFolderTxt";
            this.SelectFolderTxt.Size = new System.Drawing.Size(569, 43);
            this.SelectFolderTxt.TabIndex = 2;
            // 
            // BrowseFolderButton
            // 
            this.BrowseFolderButton.Location = new System.Drawing.Point(694, 85);
            this.BrowseFolderButton.Name = "BrowseFolderButton";
            this.BrowseFolderButton.Size = new System.Drawing.Size(94, 48);
            this.BrowseFolderButton.TabIndex = 3;
            this.BrowseFolderButton.Text = "Select";
            this.BrowseFolderButton.UseVisualStyleBackColor = true;
            this.BrowseFolderButton.Click += new System.EventHandler(this.BrowseFolderButton_Click);
            // 
            // SelectRCloneButton
            // 
            this.SelectRCloneButton.Location = new System.Drawing.Point(694, 154);
            this.SelectRCloneButton.Name = "SelectRCloneButton";
            this.SelectRCloneButton.Size = new System.Drawing.Size(94, 48);
            this.SelectRCloneButton.TabIndex = 6;
            this.SelectRCloneButton.Text = "Select";
            this.SelectRCloneButton.UseVisualStyleBackColor = true;
            this.SelectRCloneButton.Click += new System.EventHandler(this.SelectRCloneButton_Click);
            // 
            // RCloneConfigTxt
            // 
            this.RCloneConfigTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RCloneConfigTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RCloneConfigTxt.Location = new System.Drawing.Point(119, 156);
            this.RCloneConfigTxt.Multiline = true;
            this.RCloneConfigTxt.Name = "RCloneConfigTxt";
            this.RCloneConfigTxt.Size = new System.Drawing.Size(569, 43);
            this.RCloneConfigTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 164);
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
            this.SaveButton.Location = new System.Drawing.Point(263, 356);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(291, 52);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SelectRCloneButton);
            this.Controls.Add(this.RCloneConfigTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BrowseFolderButton);
            this.Controls.Add(this.SelectFolderTxt);
            this.Controls.Add(this.label2);
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
        private Label label2;
        private TextBox SelectFolderTxt;
        private Button BrowseFolderButton;
        private FolderBrowserDialog folderBrowserDialog;
        private Button SelectRCloneButton;
        private TextBox RCloneConfigTxt;
        private Label label3;
        private Button SaveButton;
    }
}