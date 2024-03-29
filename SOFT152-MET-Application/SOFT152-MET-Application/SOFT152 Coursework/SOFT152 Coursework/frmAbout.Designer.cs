﻿namespace SOFT152_Coursework
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblMetApplication = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblOrganisation = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMetApplication
            // 
            this.lblMetApplication.AutoSize = true;
            this.lblMetApplication.Location = new System.Drawing.Point(376, 44);
            this.lblMetApplication.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMetApplication.Name = "lblMetApplication";
            this.lblMetApplication.Size = new System.Drawing.Size(160, 25);
            this.lblMetApplication.TabIndex = 0;
            this.lblMetApplication.Text = "Met Application";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.ErrorImage")));
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.InitialImage")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(24, 44);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(334, 564);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(376, 102);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(139, 25);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version 1.0.0";
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Location = new System.Drawing.Point(376, 160);
            this.lblDeveloper.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(201, 25);
            this.lblDeveloper.TabIndex = 3;
            this.lblDeveloper.Text = "Alexander Pritchard";
            // 
            // lblOrganisation
            // 
            this.lblOrganisation.AutoSize = true;
            this.lblOrganisation.Location = new System.Drawing.Point(376, 217);
            this.lblOrganisation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOrganisation.Name = "lblOrganisation";
            this.lblOrganisation.Size = new System.Drawing.Size(230, 25);
            this.lblOrganisation.TabIndex = 4;
            this.lblOrganisation.Text = "University Of Plymouth";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "Created for SOFT152 (Software Engineering for ",
            "Games Development) by Alexander Pritchard.",
            "",
            "m: +44 (0) 7851536840",
            "e: alexander.pritchard@students.plymouth.ac.uk",
            "t: @alexpritc"});
            this.listBox1.Location = new System.Drawing.Point(382, 273);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(506, 279);
            this.listBox1.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Location = new System.Drawing.Point(742, 567);
            this.btnOk.Margin = new System.Windows.Forms.Padding(6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(150, 44);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 637);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblOrganisation);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.lblMetApplication);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMetApplication;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Label lblOrganisation;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnOk;
    }
}