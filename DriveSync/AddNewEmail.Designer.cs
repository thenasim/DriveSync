namespace DriveSync
{
    partial class AddNewEmail
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
            this.EmailAddressTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RootFolderIdTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailAddressTxt
            // 
            this.EmailAddressTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmailAddressTxt.Location = new System.Drawing.Point(165, 93);
            this.EmailAddressTxt.Multiline = true;
            this.EmailAddressTxt.Name = "EmailAddressTxt";
            this.EmailAddressTxt.PlaceholderText = "Enter email";
            this.EmailAddressTxt.Size = new System.Drawing.Size(569, 43);
            this.EmailAddressTxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email Address*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add New Email";
            // 
            // RootFolderIdTxt
            // 
            this.RootFolderIdTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RootFolderIdTxt.Location = new System.Drawing.Point(165, 159);
            this.RootFolderIdTxt.Multiline = true;
            this.RootFolderIdTxt.Name = "RootFolderIdTxt";
            this.RootFolderIdTxt.PlaceholderText = "Root Folder Id";
            this.RootFolderIdTxt.Size = new System.Drawing.Size(569, 43);
            this.RootFolderIdTxt.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Root Folder Id";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveButton.Location = new System.Drawing.Point(926, 93);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(230, 109);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddNewEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 677);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RootFolderIdTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailAddressTxt);
            this.Controls.Add(this.label4);
            this.Name = "AddNewEmail";
            this.Text = "AddNewEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox EmailAddressTxt;
        private Label label4;
        private Label label1;
        private TextBox RootFolderIdTxt;
        private Label label2;
        private Button SaveButton;
    }
}