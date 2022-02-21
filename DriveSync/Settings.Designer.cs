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
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BrowseFolderButton);
            this.Controls.Add(this.SelectFolderTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
    }
}