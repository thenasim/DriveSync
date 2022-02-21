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
            this.button1 = new System.Windows.Forms.Button();
            this.BrowseFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1035, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BrowseFolder
            // 
            this.BrowseFolder.Location = new System.Drawing.Point(448, 105);
            this.BrowseFolder.Name = "BrowseFolder";
            this.BrowseFolder.Size = new System.Drawing.Size(180, 29);
            this.BrowseFolder.TabIndex = 1;
            this.BrowseFolder.Text = "Select Folder";
            this.BrowseFolder.UseVisualStyleBackColor = true;
            this.BrowseFolder.Click += new System.EventHandler(this.BrowseFolder_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 620);
            this.Controls.Add(this.BrowseFolder);
            this.Controls.Add(this.button1);
            this.Name = "StartForm";
            this.Text = "Home - DriveSync";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button BrowseFolder;
        private FolderBrowserDialog folderBrowserDialog;
    }
}