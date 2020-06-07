namespace ArchiveOrgUploader
{
    partial class FormKeys
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
            this.linkKeys = new System.Windows.Forms.LinkLabel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textS3Access = new System.Windows.Forms.TextBox();
            this.textS3Secret = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your S3 access key:";
            // 
            // linkKeys
            // 
            this.linkKeys.AutoSize = true;
            this.linkKeys.Location = new System.Drawing.Point(12, 9);
            this.linkKeys.Name = "linkKeys";
            this.linkKeys.Size = new System.Drawing.Size(221, 13);
            this.linkKeys.TabIndex = 1;
            this.linkKeys.TabStop = true;
            this.linkKeys.Text = "Click here to retrieve your keys at Archive.org";
            this.linkKeys.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkKeys_LinkClicked);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(238, 87);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(184, 38);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save keys";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textS3Access
            // 
            this.textS3Access.Location = new System.Drawing.Point(123, 35);
            this.textS3Access.Name = "textS3Access";
            this.textS3Access.PasswordChar = '*';
            this.textS3Access.Size = new System.Drawing.Size(299, 20);
            this.textS3Access.TabIndex = 14;
            // 
            // textS3Secret
            // 
            this.textS3Secret.Location = new System.Drawing.Point(123, 61);
            this.textS3Secret.Name = "textS3Secret";
            this.textS3Secret.PasswordChar = '*';
            this.textS3Secret.Size = new System.Drawing.Size(299, 20);
            this.textS3Secret.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Your S3 secret key:";
            // 
            // FormKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 136);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textS3Secret);
            this.Controls.Add(this.textS3Access);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.linkKeys);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormKeys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Change keys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkKeys;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textS3Access;
        private System.Windows.Forms.TextBox textS3Secret;
        private System.Windows.Forms.Label label2;
    }
}